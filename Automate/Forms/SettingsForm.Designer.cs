namespace Automate
{
    partial class SettingsForm
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
            this.cbAutoMinimizeMainWindow = new System.Windows.Forms.CheckBox();
            this.cbAutoShowMainWindow = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbAutoMinimizeMainWindow
            // 
            this.cbAutoMinimizeMainWindow.AutoSize = true;
            this.cbAutoMinimizeMainWindow.Location = new System.Drawing.Point(16, 16);
            this.cbAutoMinimizeMainWindow.Name = "cbAutoMinimizeMainWindow";
            this.cbAutoMinimizeMainWindow.Size = new System.Drawing.Size(261, 17);
            this.cbAutoMinimizeMainWindow.TabIndex = 0;
            this.cbAutoMinimizeMainWindow.Text = "On script start automatically minimize main window";
            this.cbAutoMinimizeMainWindow.UseVisualStyleBackColor = true;
            // 
            // cbAutoShowMainWindow
            // 
            this.cbAutoShowMainWindow.AutoSize = true;
            this.cbAutoShowMainWindow.Location = new System.Drawing.Point(16, 40);
            this.cbAutoShowMainWindow.Name = "cbAutoShowMainWindow";
            this.cbAutoShowMainWindow.Size = new System.Drawing.Size(281, 17);
            this.cbAutoShowMainWindow.TabIndex = 1;
            this.cbAutoShowMainWindow.Text = "On script stop automatically bring main window to front";
            this.cbAutoShowMainWindow.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(200, 216);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(320, 216);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 24);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(440, 248);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbAutoShowMainWindow);
            this.Controls.Add(this.cbAutoMinimizeMainWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automate - Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbAutoMinimizeMainWindow;
        private System.Windows.Forms.CheckBox cbAutoShowMainWindow;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}