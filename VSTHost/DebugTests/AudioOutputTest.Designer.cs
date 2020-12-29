
namespace VSTHost
{
    partial class AudioOutputTest
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
            this.audioTypeCB = new System.Windows.Forms.ComboBox();
            this.playButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.playbackStatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // audioTypeCB
            // 
            this.audioTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.audioTypeCB.FormattingEnabled = true;
            this.audioTypeCB.Items.AddRange(new object[] {
            "Sine Wave",
            "Sawtooth",
            "White Noise"});
            this.audioTypeCB.Location = new System.Drawing.Point(12, 12);
            this.audioTypeCB.Name = "audioTypeCB";
            this.audioTypeCB.Size = new System.Drawing.Size(121, 23);
            this.audioTypeCB.TabIndex = 1;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(139, 12);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(220, 12);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // playbackStatusLabel
            // 
            this.playbackStatusLabel.AutoSize = true;
            this.playbackStatusLabel.Location = new System.Drawing.Point(12, 44);
            this.playbackStatusLabel.Name = "playbackStatusLabel";
            this.playbackStatusLabel.Size = new System.Drawing.Size(86, 15);
            this.playbackStatusLabel.TabIndex = 4;
            this.playbackStatusLabel.Text = "playbackStatus";
            // 
            // AudioOutputTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 68);
            this.Controls.Add(this.playbackStatusLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.audioTypeCB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AudioOutputTest";
            this.Text = "AudioOutput Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox audioTypeCB;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label playbackStatusLabel;
    }
}