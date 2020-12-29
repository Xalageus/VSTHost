
namespace VSTHost
{
    partial class PluginLoadTest
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
            this.vstPathTB = new System.Windows.Forms.TextBox();
            this.selectVSTButton = new System.Windows.Forms.Button();
            this.loadVSTButton = new System.Windows.Forms.Button();
            this.showPluginWindowButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.logtombCB = new System.Windows.Forms.CheckBox();
            this.powerOnCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // vstPathTB
            // 
            this.vstPathTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vstPathTB.Location = new System.Drawing.Point(13, 13);
            this.vstPathTB.Name = "vstPathTB";
            this.vstPathTB.Size = new System.Drawing.Size(680, 23);
            this.vstPathTB.TabIndex = 0;
            // 
            // selectVSTButton
            // 
            this.selectVSTButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectVSTButton.Location = new System.Drawing.Point(699, 12);
            this.selectVSTButton.Name = "selectVSTButton";
            this.selectVSTButton.Size = new System.Drawing.Size(89, 23);
            this.selectVSTButton.TabIndex = 1;
            this.selectVSTButton.Text = "Select VST...";
            this.selectVSTButton.UseVisualStyleBackColor = true;
            this.selectVSTButton.Click += new System.EventHandler(this.selectVSTButton_Click);
            // 
            // loadVSTButton
            // 
            this.loadVSTButton.Location = new System.Drawing.Point(713, 41);
            this.loadVSTButton.Name = "loadVSTButton";
            this.loadVSTButton.Size = new System.Drawing.Size(75, 23);
            this.loadVSTButton.TabIndex = 2;
            this.loadVSTButton.Text = "Load VST";
            this.loadVSTButton.UseVisualStyleBackColor = true;
            this.loadVSTButton.Click += new System.EventHandler(this.loadVSTButton_Click);
            // 
            // showPluginWindowButton
            // 
            this.showPluginWindowButton.Location = new System.Drawing.Point(658, 70);
            this.showPluginWindowButton.Name = "showPluginWindowButton";
            this.showPluginWindowButton.Size = new System.Drawing.Size(130, 23);
            this.showPluginWindowButton.TabIndex = 3;
            this.showPluginWindowButton.Text = "Show Plugin Window";
            this.showPluginWindowButton.UseVisualStyleBackColor = true;
            this.showPluginWindowButton.Click += new System.EventHandler(this.showPluginWindowButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "dll";
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "VST Plugin|*.dll|VST3 Plugin|*.vst3";
            // 
            // logtombCB
            // 
            this.logtombCB.AutoSize = true;
            this.logtombCB.Location = new System.Drawing.Point(13, 73);
            this.logtombCB.Name = "logtombCB";
            this.logtombCB.Size = new System.Drawing.Size(129, 19);
            this.logtombCB.TabIndex = 4;
            this.logtombCB.Text = "Log to MessageBox";
            this.logtombCB.UseVisualStyleBackColor = true;
            // 
            // powerOnCB
            // 
            this.powerOnCB.AutoSize = true;
            this.powerOnCB.Location = new System.Drawing.Point(13, 48);
            this.powerOnCB.Name = "powerOnCB";
            this.powerOnCB.Size = new System.Drawing.Size(78, 19);
            this.powerOnCB.TabIndex = 5;
            this.powerOnCB.Text = "Power On";
            this.powerOnCB.UseVisualStyleBackColor = true;
            this.powerOnCB.CheckedChanged += new System.EventHandler(this.powerOnCB_CheckedChanged);
            // 
            // PluginLoadTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 104);
            this.Controls.Add(this.powerOnCB);
            this.Controls.Add(this.logtombCB);
            this.Controls.Add(this.showPluginWindowButton);
            this.Controls.Add(this.loadVSTButton);
            this.Controls.Add(this.selectVSTButton);
            this.Controls.Add(this.vstPathTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PluginLoadTest";
            this.Text = "PluginLoad Test";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PluginLoadTest_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vstPathTB;
        private System.Windows.Forms.Button selectVSTButton;
        private System.Windows.Forms.Button loadVSTButton;
        private System.Windows.Forms.Button showPluginWindowButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.CheckBox logtombCB;
        private System.Windows.Forms.CheckBox powerOnCB;
    }
}