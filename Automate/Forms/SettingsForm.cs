﻿#region License Information (GPL v3)

/*
    ShareX - A program that allows you to take screenshots and share any file type
    Copyright (c) 2007-2016 ShareX Team

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
using System;
using System.Windows.Forms;

namespace Automate
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            Icon = Resources.Icon;

            UpdateControls();
        }

        private void UpdateControls()
        {
            nudScriptStartDelay.Value = Program.Settings.ScriptStartDelay;
            cbAutoMinimizeMainWindow.Checked = Program.Settings.AutoMinimizeMainWindow;
            cbAutoShowMainWindow.Checked = Program.Settings.AutoShowMainWindow;
        }

        private void ApplySettings()
        {
            Program.Settings.ScriptStartDelay = (int)nudScriptStartDelay.Value;
            Program.Settings.AutoMinimizeMainWindow = cbAutoMinimizeMainWindow.Checked;
            Program.Settings.AutoShowMainWindow = cbAutoShowMainWindow.Checked;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ApplySettings();

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}