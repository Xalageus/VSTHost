
namespace VSTHost
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.debugMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pltMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aotMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mttMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debugMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // debugMenuItem
            // 
            this.debugMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pltMenuItem,
            this.aotMenuItem,
            this.mitMenuItem,
            this.mttMenuItem});
            this.debugMenuItem.Enabled = false;
            this.debugMenuItem.Name = "debugMenuItem";
            this.debugMenuItem.Size = new System.Drawing.Size(56, 20);
            this.debugMenuItem.Text = "DEBUG";
            this.debugMenuItem.Visible = false;
            // 
            // pltMenuItem
            // 
            this.pltMenuItem.Name = "pltMenuItem";
            this.pltMenuItem.Size = new System.Drawing.Size(167, 22);
            this.pltMenuItem.Text = "PluginLoad Test";
            this.pltMenuItem.Click += new System.EventHandler(this.pltMenuItem_Click);
            // 
            // aotMenuItem
            // 
            this.aotMenuItem.Name = "aotMenuItem";
            this.aotMenuItem.Size = new System.Drawing.Size(167, 22);
            this.aotMenuItem.Text = "AudioOutput Test";
            this.aotMenuItem.Click += new System.EventHandler(this.aotMenuItem_Click);
            // 
            // mitMenuItem
            // 
            this.mitMenuItem.Name = "mitMenuItem";
            this.mitMenuItem.Size = new System.Drawing.Size(167, 22);
            this.mitMenuItem.Text = "MIDIInput Test";
            this.mitMenuItem.Click += new System.EventHandler(this.mitMenuItem_Click);
            // 
            // mttMenuItem
            // 
            this.mttMenuItem.Name = "mttMenuItem";
            this.mttMenuItem.Size = new System.Drawing.Size(167, 22);
            this.mttMenuItem.Text = "MIDIThru Test";
            this.mttMenuItem.Click += new System.EventHandler(this.mttMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem debugMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pltMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aotMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mttMenuItem;
    }
}

