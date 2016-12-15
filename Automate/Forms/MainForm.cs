﻿#region License Information (GPL v3)

/*
    Copyright (c) Jaex

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/

#endregion License Information (GPL v3)

using Automate.Properties;
using ShareX.HelpersLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Automate
{
    public partial class MainForm : Form
    {
        public static bool IsRunning { get; private set; }

        private ScriptManager functionManager = new ScriptManager();
        private Tokenizer tokenizer = new Tokenizer();
        private KeyboardHook keyboardHook;
        private bool closing;

        public MainForm()
        {
            InitializeComponent();
            Text = Program.Title;
            Icon = Resources.Icon;

            rtbInput.AddContextMenu();
            tokenizer.Keywords = ScriptManager.Functions.Select(x => x.Key).ToArray();
            cbFunctions.Items.AddRange(tokenizer.Keywords);
            cbKeys.Items.AddRange(Enum.GetNames(typeof(Keys)).Skip(1).ToArray());
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            UpdateControls();

            keyboardHook = new KeyboardHook();
            keyboardHook.KeyDown += KeyboardHook_KeyDown;

#if !DEBUG
            Program.UpdateManager.ConfigureAutoUpdate();
#endif

            this.ForceActivate();
        }

        private void UpdateControls()
        {
            if (Program.Settings.Scripts == null)
            {
                Program.Settings.Scripts = new List<ScriptInfo>();
            }

            foreach (ScriptInfo scriptInfo in Program.Settings.Scripts)
            {
                AddScriptToList(scriptInfo);
            }

            if (lvScripts.Items.Count > 0)
            {
                lvScripts.Items[0].Selected = true;
            }
        }

        private void KeyboardHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (btnHotkey.EditingHotkey) return;

            foreach (ScriptInfo scriptInfo in Program.Settings.Scripts)
            {
                if (scriptInfo.Hotkey == e.KeyData)
                {
                    Start(scriptInfo);
                    e.Handled = true;
                    break;
                }
            }
        }

        private void AddScriptToList(ScriptInfo scriptInfo)
        {
            ListViewItem lvi = new ListViewItem(scriptInfo.Name);
            lvi.SubItems.Add(new HotkeyInfo(scriptInfo.Hotkey).ToString());
            lvi.Tag = scriptInfo;
            lvScripts.Items.Add(lvi);
        }

        private void rtbInput_TextChanged(object sender, EventArgs e)
        {
            Tokenize();
        }

        private void Tokenize()
        {
            if (!string.IsNullOrEmpty(rtbInput.Text))
            {
                List<Token> tokens = tokenizer.Tokenize(rtbInput.Text);
                SyntaxHighlighting(tokens);
            }
        }

        private void SyntaxHighlighting(List<Token> tokens)
        {
            int start = rtbInput.SelectionStart;
            int length = rtbInput.SelectionLength;
            rtbInput.BeginUpdate();

            foreach (Token token in tokens)
            {
                Color color;

                switch (token.Type)
                {
                    default:
                        continue;
                    case TokenType.Symbol:
                        color = Color.Red;
                        break;
                    case TokenType.Literal:
                        color = Color.Brown;
                        break;
                    case TokenType.Identifier:
                        color = Color.DarkBlue;
                        break;
                    case TokenType.Numeric:
                        color = Color.Blue;
                        break;
                    case TokenType.Keyword:
                        color = Color.Green;
                        break;
                }

                rtbInput.SelectionStart = token.Position;
                rtbInput.SelectionLength = token.Text.Length;
                rtbInput.SelectionColor = color;
            }

            rtbInput.SelectionStart = start;
            rtbInput.SelectionLength = length;
            rtbInput.EndUpdate();
        }

        public void Start(ScriptInfo scriptInfo)
        {
            if (!IsRunning)
            {
                IsRunning = true;
                btnRun.Text = "Stop";

                if (Program.Settings.AutoMinimizeMainWindow)
                {
                    WindowState = FormWindowState.Minimized;
                }

                BackgroundWorker bw = new BackgroundWorker();
                bw.DoWork += bw_DoWork;
                bw.RunWorkerCompleted += bw_RunWorkerCompleted;
                bw.RunWorkerAsync(scriptInfo);
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            functionManager.Stop();
        }

        private void SetExample()
        {
            rtbInput.Text = Resources.ExampleScript;
        }

        private void ResetFields()
        {
            foreach (ListViewItem lvi in lvScripts.SelectedItems)
            {
                lvi.Selected = false;
            }

            txtScriptName.Clear();
            btnHotkey.Reset();
            rtbInput.Clear();
            nudLineDelay.Value = 1;
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            ScriptInfo scriptInfo = e.Argument as ScriptInfo;

            try
            {
                functionManager.Start(scriptInfo);
                Thread.Sleep(100);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            IsRunning = false;

            if (!closing)
            {
                btnRun.Text = "Start";

                if (Program.Settings.AutoShowMainWindow)
                {
                    this.ForceActivate();
                }
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (IsRunning)
            {
                Stop();
            }
            else
            {
                ScriptInfo scriptInfo = new ScriptInfo()
                {
                    Script = rtbInput.Text,
                    LineDelay = (int)nudLineDelay.Value
                };

                Start(scriptInfo);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void btnLoadExample_Click(object sender, EventArgs e)
        {
            SetExample();
        }

        private void btnSaveScript_Click(object sender, EventArgs e)
        {
            string scriptName = txtScriptName.Text;

            if (string.IsNullOrEmpty(scriptName))
            {
                MessageBox.Show("Script name can't be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ScriptInfo scriptInfo = Program.Settings.Scripts.FirstOrDefault(x => x.Name.Equals(scriptName, StringComparison.InvariantCultureIgnoreCase));

            if (scriptInfo != null)
            {
                scriptInfo.Script = rtbInput.Text;
                scriptInfo.LineDelay = (int)nudLineDelay.Value;
                scriptInfo.Hotkey = btnHotkey.HotkeyInfo.Hotkey;
            }
            else
            {
                scriptInfo = new ScriptInfo()
                {
                    Name = scriptName,
                    Script = rtbInput.Text,
                    LineDelay = (int)nudLineDelay.Value,
                    Hotkey = btnHotkey.HotkeyInfo.Hotkey
                };

                Program.Settings.Scripts.Add(scriptInfo);
                AddScriptToList(scriptInfo);
            }
        }

        private void btnRemoveScript_Click(object sender, EventArgs e)
        {
            if (lvScripts.SelectedIndices.Count > 0)
            {
                int index = lvScripts.SelectedIndices[0];
                Program.Settings.Scripts.RemoveAt(index);
                lvScripts.Items.RemoveAt(index);
                rtbInput.Clear();
                txtScriptName.Clear();
            }
        }

        private void lvScripts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvScripts.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvScripts.SelectedItems[0];
                ScriptInfo scriptInfo = lvi.Tag as ScriptInfo;
                if (scriptInfo != null)
                {
                    txtScriptName.Text = scriptInfo.Name;
                    btnHotkey.UpdateHotkey(new HotkeyInfo(scriptInfo.Hotkey));
                    rtbInput.Text = scriptInfo.Script;
                    nudLineDelay.SetValue(scriptInfo.LineDelay);
                }
            }
        }

        private void cbFunctions_SelectionChangeCommitted(object sender, EventArgs e)
        {
            rtbInput.SelectedText = cbFunctions.Text;
        }

        private void cbKeys_SelectionChangeCommitted(object sender, EventArgs e)
        {
            rtbInput.SelectedText = cbKeys.Text;
        }

        private void btnAddMouseMove_Click(object sender, EventArgs e)
        {
            btnAddMouseMove.Enabled = false;

            Thread thread = new Thread(() =>
            {
                Thread.Sleep(2000);

                this.InvokeSafe(() =>
                {
                    Point position = Cursor.Position;

                    rtbInput.SelectedText = $"MouseMove {position.X} {position.Y}\r\n";
                    rtbInput.Focus();

                    btnAddMouseMove.Enabled = true;
                });
            });

            thread.Start();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            using (SettingsForm form = new SettingsForm())
            {
                form.ShowDialog();
            }
        }

        private void pbGitHub_Click(object sender, EventArgs e)
        {
            URLHelpers.OpenURL("https://github.com/Jaex/Automate");
        }

        private void AutomateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            closing = true;
            keyboardHook.Dispose();
            Stop();
        }
    }
}