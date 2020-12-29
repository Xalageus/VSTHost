
namespace VSTHost
{
    partial class MIDIInputTest
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
            this.midiInLabel = new System.Windows.Forms.Label();
            this.midiDevicesCB = new System.Windows.Forms.ComboBox();
            this.refreshMIDIButton = new System.Windows.Forms.Button();
            this.listenButton = new System.Windows.Forms.Button();
            this.midiInLogLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // midiInLabel
            // 
            this.midiInLabel.AutoSize = true;
            this.midiInLabel.Location = new System.Drawing.Point(13, 13);
            this.midiInLabel.Name = "midiInLabel";
            this.midiInLabel.Size = new System.Drawing.Size(101, 15);
            this.midiInLabel.TabIndex = 0;
            this.midiInLabel.Text = "MIDI Input Device";
            // 
            // midiDevicesCB
            // 
            this.midiDevicesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.midiDevicesCB.Enabled = false;
            this.midiDevicesCB.FormattingEnabled = true;
            this.midiDevicesCB.Location = new System.Drawing.Point(120, 10);
            this.midiDevicesCB.Name = "midiDevicesCB";
            this.midiDevicesCB.Size = new System.Drawing.Size(586, 23);
            this.midiDevicesCB.TabIndex = 1;
            // 
            // refreshMIDIButton
            // 
            this.refreshMIDIButton.Location = new System.Drawing.Point(12, 39);
            this.refreshMIDIButton.Name = "refreshMIDIButton";
            this.refreshMIDIButton.Size = new System.Drawing.Size(133, 23);
            this.refreshMIDIButton.TabIndex = 2;
            this.refreshMIDIButton.Text = "Refresh MIDI Devices";
            this.refreshMIDIButton.UseVisualStyleBackColor = true;
            this.refreshMIDIButton.Click += new System.EventHandler(this.refreshMIDIButton_Click);
            // 
            // listenButton
            // 
            this.listenButton.Location = new System.Drawing.Point(151, 39);
            this.listenButton.Name = "listenButton";
            this.listenButton.Size = new System.Drawing.Size(75, 23);
            this.listenButton.TabIndex = 3;
            this.listenButton.Text = "Listen";
            this.listenButton.UseVisualStyleBackColor = true;
            this.listenButton.Click += new System.EventHandler(this.listenButton_Click);
            // 
            // midiInLogLB
            // 
            this.midiInLogLB.FormattingEnabled = true;
            this.midiInLogLB.ItemHeight = 15;
            this.midiInLogLB.Location = new System.Drawing.Point(12, 68);
            this.midiInLogLB.Name = "midiInLogLB";
            this.midiInLogLB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.midiInLogLB.Size = new System.Drawing.Size(694, 304);
            this.midiInLogLB.TabIndex = 4;
            // 
            // MIDIInputTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 390);
            this.Controls.Add(this.midiInLogLB);
            this.Controls.Add(this.listenButton);
            this.Controls.Add(this.refreshMIDIButton);
            this.Controls.Add(this.midiDevicesCB);
            this.Controls.Add(this.midiInLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MIDIInputTest";
            this.Text = "MIDIInput Test";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MIDIInputTest_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label midiInLabel;
        private System.Windows.Forms.ComboBox midiDevicesCB;
        private System.Windows.Forms.Button refreshMIDIButton;
        private System.Windows.Forms.Button listenButton;
        private System.Windows.Forms.ListBox midiInLogLB;
    }
}