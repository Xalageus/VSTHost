
namespace VSTHost
{
    partial class MIDIThruTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MIDIThruTest));
            this.midiInLabel = new System.Windows.Forms.Label();
            this.midiOutLabel = new System.Windows.Forms.Label();
            this.midiOutDevicesCB = new System.Windows.Forms.ComboBox();
            this.midiInDevicesCB = new System.Windows.Forms.ComboBox();
            this.midiConnectivityPB = new System.Windows.Forms.PictureBox();
            this.midiActivityPB = new System.Windows.Forms.PictureBox();
            this.refreshMidiInButton = new System.Windows.Forms.Button();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.refreshMidiOutButton = new System.Windows.Forms.Button();
            this.midiInConfirmButton = new System.Windows.Forms.Button();
            this.confirmCancelImages = new System.Windows.Forms.ImageList(this.components);
            this.midiOutConfirmButton = new System.Windows.Forms.Button();
            this.connectedImages = new System.Windows.Forms.ImageList(this.components);
            this.activityImages = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.midiConnectivityPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midiActivityPB)).BeginInit();
            this.SuspendLayout();
            // 
            // midiInLabel
            // 
            this.midiInLabel.AutoSize = true;
            this.midiInLabel.Location = new System.Drawing.Point(13, 13);
            this.midiInLabel.Name = "midiInLabel";
            this.midiInLabel.Size = new System.Drawing.Size(45, 15);
            this.midiInLabel.TabIndex = 0;
            this.midiInLabel.Text = "MIDI In";
            // 
            // midiOutLabel
            // 
            this.midiOutLabel.AutoSize = true;
            this.midiOutLabel.Location = new System.Drawing.Point(12, 148);
            this.midiOutLabel.Name = "midiOutLabel";
            this.midiOutLabel.Size = new System.Drawing.Size(55, 15);
            this.midiOutLabel.TabIndex = 1;
            this.midiOutLabel.Text = "MIDI Out";
            // 
            // midiOutDevicesCB
            // 
            this.midiOutDevicesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.midiOutDevicesCB.FormattingEnabled = true;
            this.midiOutDevicesCB.Location = new System.Drawing.Point(73, 145);
            this.midiOutDevicesCB.Name = "midiOutDevicesCB";
            this.midiOutDevicesCB.Size = new System.Drawing.Size(335, 23);
            this.midiOutDevicesCB.TabIndex = 2;
            // 
            // midiInDevicesCB
            // 
            this.midiInDevicesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.midiInDevicesCB.FormattingEnabled = true;
            this.midiInDevicesCB.Location = new System.Drawing.Point(73, 10);
            this.midiInDevicesCB.Name = "midiInDevicesCB";
            this.midiInDevicesCB.Size = new System.Drawing.Size(335, 23);
            this.midiInDevicesCB.TabIndex = 3;
            // 
            // midiConnectivityPB
            // 
            this.midiConnectivityPB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.midiConnectivityPB.Image = ((System.Drawing.Image)(resources.GetObject("midiConnectivityPB.Image")));
            this.midiConnectivityPB.Location = new System.Drawing.Point(216, 39);
            this.midiConnectivityPB.Name = "midiConnectivityPB";
            this.midiConnectivityPB.Size = new System.Drawing.Size(50, 100);
            this.midiConnectivityPB.TabIndex = 4;
            this.midiConnectivityPB.TabStop = false;
            // 
            // midiActivityPB
            // 
            this.midiActivityPB.Image = ((System.Drawing.Image)(resources.GetObject("midiActivityPB.Image")));
            this.midiActivityPB.Location = new System.Drawing.Point(272, 83);
            this.midiActivityPB.Name = "midiActivityPB";
            this.midiActivityPB.Size = new System.Drawing.Size(13, 13);
            this.midiActivityPB.TabIndex = 5;
            this.midiActivityPB.TabStop = false;
            // 
            // refreshMidiInButton
            // 
            this.refreshMidiInButton.BackColor = System.Drawing.Color.Transparent;
            this.refreshMidiInButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshMidiInButton.Image")));
            this.refreshMidiInButton.Location = new System.Drawing.Point(414, 9);
            this.refreshMidiInButton.Name = "refreshMidiInButton";
            this.refreshMidiInButton.Size = new System.Drawing.Size(26, 23);
            this.refreshMidiInButton.TabIndex = 6;
            this.tt.SetToolTip(this.refreshMidiInButton, "Refresh device list");
            this.refreshMidiInButton.UseVisualStyleBackColor = false;
            this.refreshMidiInButton.Click += new System.EventHandler(this.refreshMidiInButton_Click);
            // 
            // refreshMidiOutButton
            // 
            this.refreshMidiOutButton.BackColor = System.Drawing.Color.Transparent;
            this.refreshMidiOutButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshMidiOutButton.Image")));
            this.refreshMidiOutButton.Location = new System.Drawing.Point(414, 145);
            this.refreshMidiOutButton.Name = "refreshMidiOutButton";
            this.refreshMidiOutButton.Size = new System.Drawing.Size(26, 23);
            this.refreshMidiOutButton.TabIndex = 7;
            this.tt.SetToolTip(this.refreshMidiOutButton, "Refresh device list");
            this.refreshMidiOutButton.UseVisualStyleBackColor = false;
            this.refreshMidiOutButton.Click += new System.EventHandler(this.refreshMidiOutButton_Click);
            // 
            // midiInConfirmButton
            // 
            this.midiInConfirmButton.BackColor = System.Drawing.Color.Transparent;
            this.midiInConfirmButton.ImageIndex = 0;
            this.midiInConfirmButton.ImageList = this.confirmCancelImages;
            this.midiInConfirmButton.Location = new System.Drawing.Point(446, 9);
            this.midiInConfirmButton.Name = "midiInConfirmButton";
            this.midiInConfirmButton.Size = new System.Drawing.Size(26, 23);
            this.midiInConfirmButton.TabIndex = 8;
            this.tt.SetToolTip(this.midiInConfirmButton, "Confirm");
            this.midiInConfirmButton.UseVisualStyleBackColor = false;
            this.midiInConfirmButton.Click += new System.EventHandler(this.midiInConfirmButton_Click);
            // 
            // confirmCancelImages
            // 
            this.confirmCancelImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.confirmCancelImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("confirmCancelImages.ImageStream")));
            this.confirmCancelImages.TransparentColor = System.Drawing.Color.Transparent;
            this.confirmCancelImages.Images.SetKeyName(0, "Check.png");
            this.confirmCancelImages.Images.SetKeyName(1, "Cross.png");
            // 
            // midiOutConfirmButton
            // 
            this.midiOutConfirmButton.BackColor = System.Drawing.Color.Transparent;
            this.midiOutConfirmButton.ImageIndex = 0;
            this.midiOutConfirmButton.ImageList = this.confirmCancelImages;
            this.midiOutConfirmButton.Location = new System.Drawing.Point(446, 145);
            this.midiOutConfirmButton.Name = "midiOutConfirmButton";
            this.midiOutConfirmButton.Size = new System.Drawing.Size(26, 23);
            this.midiOutConfirmButton.TabIndex = 9;
            this.tt.SetToolTip(this.midiOutConfirmButton, "Confirm");
            this.midiOutConfirmButton.UseVisualStyleBackColor = false;
            this.midiOutConfirmButton.Click += new System.EventHandler(this.midiOutConfirmButton_Click);
            // 
            // connectedImages
            // 
            this.connectedImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.connectedImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("connectedImages.ImageStream")));
            this.connectedImages.TransparentColor = System.Drawing.Color.Transparent;
            this.connectedImages.Images.SetKeyName(0, "MIDIDisconnected.png");
            this.connectedImages.Images.SetKeyName(1, "MIDIConnected.png");
            // 
            // activityImages
            // 
            this.activityImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.activityImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("activityImages.ImageStream")));
            this.activityImages.TransparentColor = System.Drawing.Color.Transparent;
            this.activityImages.Images.SetKeyName(0, "MIDINoActivity.png");
            this.activityImages.Images.SetKeyName(1, "MIDIActivity.png");
            // 
            // MIDIThruTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 177);
            this.Controls.Add(this.midiOutConfirmButton);
            this.Controls.Add(this.midiInConfirmButton);
            this.Controls.Add(this.refreshMidiOutButton);
            this.Controls.Add(this.refreshMidiInButton);
            this.Controls.Add(this.midiActivityPB);
            this.Controls.Add(this.midiConnectivityPB);
            this.Controls.Add(this.midiInDevicesCB);
            this.Controls.Add(this.midiOutDevicesCB);
            this.Controls.Add(this.midiOutLabel);
            this.Controls.Add(this.midiInLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MIDIThruTest";
            this.Text = "MIDIThru Test";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MIDIThruTest_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.midiConnectivityPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midiActivityPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label midiInLabel;
        private System.Windows.Forms.Label midiOutLabel;
        private System.Windows.Forms.ComboBox midiOutDevicesCB;
        private System.Windows.Forms.ComboBox midiInDevicesCB;
        private System.Windows.Forms.PictureBox midiConnectivityPB;
        private System.Windows.Forms.PictureBox midiActivityPB;
        private System.Windows.Forms.Button refreshMidiInButton;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.Button refreshMidiOutButton;
        private System.Windows.Forms.Button midiInConfirmButton;
        private System.Windows.Forms.ImageList confirmCancelImages;
        private System.Windows.Forms.Button midiOutConfirmButton;
        private System.Windows.Forms.ImageList connectedImages;
        private System.Windows.Forms.ImageList activityImages;
    }
}