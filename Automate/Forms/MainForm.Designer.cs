namespace Automate
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnRun = new System.Windows.Forms.Button();
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.pInput = new System.Windows.Forms.Panel();
            this.cbFunctions = new System.Windows.Forms.ComboBox();
            this.lblFunctions = new System.Windows.Forms.Label();
            this.btnLoadExample = new System.Windows.Forms.Button();
            this.txtScriptName = new System.Windows.Forms.TextBox();
            this.btnSaveScript = new System.Windows.Forms.Button();
            this.lblScriptName = new System.Windows.Forms.Label();
            this.btnRemoveScript = new System.Windows.Forms.Button();
            this.btnAddMouseMove = new System.Windows.Forms.Button();
            this.lblLineDelay = new System.Windows.Forms.Label();
            this.nudLineDelay = new System.Windows.Forms.NumericUpDown();
            this.lblLineDelayMiliseconds = new System.Windows.Forms.Label();
            this.lblKeys = new System.Windows.Forms.Label();
            this.cbKeys = new System.Windows.Forms.ComboBox();
            this.lblHotkey = new System.Windows.Forms.Label();
            this.btnHotkey = new ShareX.HelpersLib.Controls.HotkeySelectionButton();
            this.lvScripts = new ShareX.HelpersLib.MyListView();
            this.chScriptName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chScriptHotkey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNew = new System.Windows.Forms.Button();
            this.pbGitHub = new System.Windows.Forms.PictureBox();
            this.ttMain = new System.Windows.Forms.ToolTip(this.components);
            this.pInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLineDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGitHub)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRun.Location = new System.Drawing.Point(248, 456);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(168, 24);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Start";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // rtbInput
            // 
            this.rtbInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbInput.Font = new System.Drawing.Font("Verdana", 12F);
            this.rtbInput.Location = new System.Drawing.Point(3, 3);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(504, 384);
            this.rtbInput.TabIndex = 0;
            this.rtbInput.Text = "";
            this.rtbInput.TextChanged += new System.EventHandler(this.rtbInput_TextChanged);
            // 
            // pInput
            // 
            this.pInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pInput.Controls.Add(this.rtbInput);
            this.pInput.Location = new System.Drawing.Point(248, 56);
            this.pInput.Name = "pInput";
            this.pInput.Padding = new System.Windows.Forms.Padding(3);
            this.pInput.Size = new System.Drawing.Size(512, 392);
            this.pInput.TabIndex = 0;
            // 
            // cbFunctions
            // 
            this.cbFunctions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFunctions.FormattingEnabled = true;
            this.cbFunctions.Location = new System.Drawing.Point(248, 24);
            this.cbFunctions.Name = "cbFunctions";
            this.cbFunctions.Size = new System.Drawing.Size(168, 21);
            this.cbFunctions.TabIndex = 4;
            this.cbFunctions.SelectionChangeCommitted += new System.EventHandler(this.cbFunctions_SelectionChangeCommitted);
            // 
            // lblFunctions
            // 
            this.lblFunctions.AutoSize = true;
            this.lblFunctions.Location = new System.Drawing.Point(245, 8);
            this.lblFunctions.Name = "lblFunctions";
            this.lblFunctions.Size = new System.Drawing.Size(56, 13);
            this.lblFunctions.TabIndex = 3;
            this.lblFunctions.Text = "Functions:";
            // 
            // btnLoadExample
            // 
            this.btnLoadExample.Location = new System.Drawing.Point(96, 8);
            this.btnLoadExample.Name = "btnLoadExample";
            this.btnLoadExample.Size = new System.Drawing.Size(144, 24);
            this.btnLoadExample.TabIndex = 2;
            this.btnLoadExample.Text = "Load example script";
            this.btnLoadExample.UseVisualStyleBackColor = true;
            this.btnLoadExample.Click += new System.EventHandler(this.btnLoadExample_Click);
            // 
            // txtScriptName
            // 
            this.txtScriptName.Location = new System.Drawing.Point(8, 56);
            this.txtScriptName.Name = "txtScriptName";
            this.txtScriptName.Size = new System.Drawing.Size(232, 20);
            this.txtScriptName.TabIndex = 6;
            // 
            // btnSaveScript
            // 
            this.btnSaveScript.Location = new System.Drawing.Point(8, 128);
            this.btnSaveScript.Name = "btnSaveScript";
            this.btnSaveScript.Size = new System.Drawing.Size(112, 24);
            this.btnSaveScript.TabIndex = 7;
            this.btnSaveScript.Text = "Save";
            this.btnSaveScript.UseVisualStyleBackColor = true;
            this.btnSaveScript.Click += new System.EventHandler(this.btnSaveScript_Click);
            // 
            // lblScriptName
            // 
            this.lblScriptName.AutoSize = true;
            this.lblScriptName.Location = new System.Drawing.Point(5, 40);
            this.lblScriptName.Name = "lblScriptName";
            this.lblScriptName.Size = new System.Drawing.Size(66, 13);
            this.lblScriptName.TabIndex = 8;
            this.lblScriptName.Text = "Script name:";
            // 
            // btnRemoveScript
            // 
            this.btnRemoveScript.Location = new System.Drawing.Point(128, 128);
            this.btnRemoveScript.Name = "btnRemoveScript";
            this.btnRemoveScript.Size = new System.Drawing.Size(112, 24);
            this.btnRemoveScript.TabIndex = 9;
            this.btnRemoveScript.Text = "Remove";
            this.btnRemoveScript.UseVisualStyleBackColor = true;
            this.btnRemoveScript.Click += new System.EventHandler(this.btnRemoveScript_Click);
            // 
            // btnAddMouseMove
            // 
            this.btnAddMouseMove.Location = new System.Drawing.Point(600, 22);
            this.btnAddMouseMove.Name = "btnAddMouseMove";
            this.btnAddMouseMove.Size = new System.Drawing.Size(160, 24);
            this.btnAddMouseMove.TabIndex = 10;
            this.btnAddMouseMove.Text = "Add cursor position";
            this.btnAddMouseMove.UseVisualStyleBackColor = true;
            this.btnAddMouseMove.Click += new System.EventHandler(this.btnAddMouseMove_Click);
            // 
            // lblLineDelay
            // 
            this.lblLineDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLineDelay.AutoSize = true;
            this.lblLineDelay.Location = new System.Drawing.Point(421, 462);
            this.lblLineDelay.Name = "lblLineDelay";
            this.lblLineDelay.Size = new System.Drawing.Size(58, 13);
            this.lblLineDelay.TabIndex = 11;
            this.lblLineDelay.Text = "Line delay:";
            // 
            // nudLineDelay
            // 
            this.nudLineDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudLineDelay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudLineDelay.Location = new System.Drawing.Point(480, 458);
            this.nudLineDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudLineDelay.Name = "nudLineDelay";
            this.nudLineDelay.Size = new System.Drawing.Size(88, 20);
            this.nudLineDelay.TabIndex = 12;
            this.nudLineDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudLineDelay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblLineDelayMiliseconds
            // 
            this.lblLineDelayMiliseconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLineDelayMiliseconds.AutoSize = true;
            this.lblLineDelayMiliseconds.Location = new System.Drawing.Point(573, 462);
            this.lblLineDelayMiliseconds.Name = "lblLineDelayMiliseconds";
            this.lblLineDelayMiliseconds.Size = new System.Drawing.Size(20, 13);
            this.lblLineDelayMiliseconds.TabIndex = 13;
            this.lblLineDelayMiliseconds.Text = "ms";
            // 
            // lblKeys
            // 
            this.lblKeys.AutoSize = true;
            this.lblKeys.Location = new System.Drawing.Point(421, 8);
            this.lblKeys.Name = "lblKeys";
            this.lblKeys.Size = new System.Drawing.Size(33, 13);
            this.lblKeys.TabIndex = 14;
            this.lblKeys.Text = "Keys:";
            // 
            // cbKeys
            // 
            this.cbKeys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKeys.FormattingEnabled = true;
            this.cbKeys.Location = new System.Drawing.Point(424, 24);
            this.cbKeys.Name = "cbKeys";
            this.cbKeys.Size = new System.Drawing.Size(168, 21);
            this.cbKeys.TabIndex = 15;
            this.cbKeys.SelectionChangeCommitted += new System.EventHandler(this.cbKeys_SelectionChangeCommitted);
            // 
            // lblHotkey
            // 
            this.lblHotkey.AutoSize = true;
            this.lblHotkey.Location = new System.Drawing.Point(5, 80);
            this.lblHotkey.Name = "lblHotkey";
            this.lblHotkey.Size = new System.Drawing.Size(44, 13);
            this.lblHotkey.TabIndex = 1;
            this.lblHotkey.Text = "Hotkey:";
            // 
            // btnHotkey
            // 
            this.btnHotkey.Location = new System.Drawing.Point(8, 96);
            this.btnHotkey.Name = "btnHotkey";
            this.btnHotkey.Size = new System.Drawing.Size(232, 23);
            this.btnHotkey.TabIndex = 1;
            this.btnHotkey.UseVisualStyleBackColor = true;
            // 
            // lvScripts
            // 
            this.lvScripts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvScripts.AutoFillColumn = true;
            this.lvScripts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chScriptName,
            this.chScriptHotkey});
            this.lvScripts.FullRowSelect = true;
            this.lvScripts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvScripts.HideSelection = false;
            this.lvScripts.Location = new System.Drawing.Point(8, 160);
            this.lvScripts.MultiSelect = false;
            this.lvScripts.Name = "lvScripts";
            this.lvScripts.Size = new System.Drawing.Size(232, 320);
            this.lvScripts.TabIndex = 5;
            this.lvScripts.UseCompatibleStateImageBehavior = false;
            this.lvScripts.View = System.Windows.Forms.View.Details;
            this.lvScripts.SelectedIndexChanged += new System.EventHandler(this.lvScripts_SelectedIndexChanged);
            // 
            // chScriptName
            // 
            this.chScriptName.Text = "Name";
            this.chScriptName.Width = 115;
            // 
            // chScriptHotkey
            // 
            this.chScriptHotkey.Text = "Hotkey";
            this.chScriptHotkey.Width = 113;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(8, 8);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(80, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pbGitHub
            // 
            this.pbGitHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbGitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbGitHub.Image = global::Automate.Properties.Resources.GitHub;
            this.pbGitHub.Location = new System.Drawing.Point(743, 460);
            this.pbGitHub.Name = "pbGitHub";
            this.pbGitHub.Size = new System.Drawing.Size(16, 16);
            this.pbGitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbGitHub.TabIndex = 16;
            this.pbGitHub.TabStop = false;
            this.ttMain.SetToolTip(this.pbGitHub, "Open GitHub web page");
            this.pbGitHub.Click += new System.EventHandler(this.pbGitHub_Click);
            // 
            // ttMain
            // 
            this.ttMain.AutoPopDelay = 10000;
            this.ttMain.InitialDelay = 100;
            this.ttMain.ReshowDelay = 100;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(769, 489);
            this.Controls.Add(this.pbGitHub);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnHotkey);
            this.Controls.Add(this.lblHotkey);
            this.Controls.Add(this.btnLoadExample);
            this.Controls.Add(this.lblKeys);
            this.Controls.Add(this.cbKeys);
            this.Controls.Add(this.lblLineDelayMiliseconds);
            this.Controls.Add(this.nudLineDelay);
            this.Controls.Add(this.lblLineDelay);
            this.Controls.Add(this.btnAddMouseMove);
            this.Controls.Add(this.btnRemoveScript);
            this.Controls.Add(this.lblScriptName);
            this.Controls.Add(this.btnSaveScript);
            this.Controls.Add(this.txtScriptName);
            this.Controls.Add(this.lvScripts);
            this.Controls.Add(this.lblFunctions);
            this.Controls.Add(this.cbFunctions);
            this.Controls.Add(this.pInput);
            this.Controls.Add(this.btnRun);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutomateForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.pInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudLineDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGitHub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.Panel pInput;
        private System.Windows.Forms.ComboBox cbFunctions;
        private System.Windows.Forms.Label lblFunctions;
        private System.Windows.Forms.Button btnLoadExample;
        private ShareX.HelpersLib.MyListView lvScripts;
        private System.Windows.Forms.TextBox txtScriptName;
        private System.Windows.Forms.Button btnSaveScript;
        private System.Windows.Forms.Label lblScriptName;
        private System.Windows.Forms.Button btnRemoveScript;
        private System.Windows.Forms.ColumnHeader chScriptName;
        private System.Windows.Forms.Button btnAddMouseMove;
        private System.Windows.Forms.Label lblLineDelay;
        private System.Windows.Forms.NumericUpDown nudLineDelay;
        private System.Windows.Forms.Label lblLineDelayMiliseconds;
        private System.Windows.Forms.Label lblKeys;
        private System.Windows.Forms.ComboBox cbKeys;
        private System.Windows.Forms.Label lblHotkey;
        private ShareX.HelpersLib.Controls.HotkeySelectionButton btnHotkey;
        private System.Windows.Forms.ColumnHeader chScriptHotkey;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.PictureBox pbGitHub;
        private System.Windows.Forms.ToolTip ttMain;
    }
}

