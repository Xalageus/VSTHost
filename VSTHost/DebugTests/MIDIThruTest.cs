using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Midi;
using System.IO;
using System.Threading;

namespace VSTHost
{
    public partial class MIDIThruTest : Form
    {
        private MidiIn midiInput;
        private MidiOut midiOutput;
        private bool inReady = false;
        private bool outReady = false;
        private bool imageActive = false;

        public MIDIThruTest()
        {
            InitializeComponent();

            searchForMIDIInDevices();
            searchForMIDIOutDevices();
        }

        private void searchForMIDIInDevices()
        {
            midiInDevicesCB.Items.Clear();

            for (int i = 0; i < MidiIn.NumberOfDevices; i++)
            {
                midiInDevicesCB.Items.Add(MidiIn.DeviceInfo(i).ProductName);
            }
            if (midiInDevicesCB.Items.Count == 0)
            {
                midiInDevicesCB.Enabled = false;
                midiInDevicesCB.Items.Add("No MIDI Input devices found");
                midiInDevicesCB.SelectedIndex = 0;
            }
            else
            {
                midiInDevicesCB.SelectedIndex = 0;
                midiInDevicesCB.Enabled = true;
            }
        }

        private void searchForMIDIOutDevices()
        {
            midiOutDevicesCB.Items.Clear();

            for (int i = 0; i < MidiOut.NumberOfDevices; i++)
            {
                midiOutDevicesCB.Items.Add(MidiOut.DeviceInfo(i).ProductName);
            }
            if (midiOutDevicesCB.Items.Count == 0)
            {
                midiOutDevicesCB.Enabled = false;
                midiOutDevicesCB.Items.Add("No MIDI Output devices found");
                midiOutDevicesCB.SelectedIndex = 0;
            }
            else
            {
                midiOutDevicesCB.SelectedIndex = 0;
                midiOutDevicesCB.Enabled = true;
            }
        }

        private void refreshMidiInButton_Click(object sender, EventArgs e)
        {
            searchForMIDIInDevices();
        }

        private void refreshMidiOutButton_Click(object sender, EventArgs e)
        {
            searchForMIDIOutDevices();
        }

        private void midiInConfirmButton_Click(object sender, EventArgs e)
        {
            if (inReady)
            {
                midiInput.Stop();
                midiInput.Close();
                midiInput.Dispose();

                midiInDevicesCB.Enabled = true;
                refreshMidiInButton.Enabled = true;
                midiInConfirmButton.ImageIndex = 0;
                inReady = false;
                checkReady(true);
            }
            else
            {
                midiInDevicesCB.Enabled = false;
                refreshMidiInButton.Enabled = false;

                midiInput = new MidiIn(midiInDevicesCB.SelectedIndex);
                midiInput.MessageReceived += midiInput_MessageReceived;
                midiInput.ErrorReceived += midiInput_ErrorReceived;
                midiInput.Start();

                midiInConfirmButton.ImageIndex = 1;
                inReady = true;
                checkReady(true);
            }
        }

        void midiInput_ErrorReceived(object sender, MidiInMessageEventArgs e)
        {
            
        }

        void midiInput_MessageReceived(object sender, MidiInMessageEventArgs e)
        {
            if (checkReady(false))
            {
                if (!imageActive)
                {
                    imageActivitySet(true);

                    Thread ia = new Thread(
                        o =>
                        {
                            imageActivityWait(100);
                        });
                    ia.Start();
                }
                midiOutput.Send(e.MidiEvent.GetAsShortMessage());
            }
        }

        private void imageActivityWait(int sleepTime)
        {
            Thread.Sleep(sleepTime);
            this.Invoke(new Action(() => imageActivitySet(false)));
        }

        private void imageActivitySet(bool enable)
        {
            if (enable)
            {
                midiActivityPB.Image = activityImages.Images[1];
                imageActive = true;
            }
            else
            {
                midiActivityPB.Image = activityImages.Images[0];
                imageActive = false;
            }
        }

        private void midiOutConfirmButton_Click(object sender, EventArgs e)
        {
            if (outReady)
            {
                midiOutput.Close();
                midiOutput.Dispose();

                midiOutDevicesCB.Enabled = true;
                refreshMidiOutButton.Enabled = true;
                midiOutConfirmButton.ImageIndex = 0;
                outReady = false;
                checkReady(true);
            }
            else
            {
                midiOutDevicesCB.Enabled = false;
                refreshMidiOutButton.Enabled = false;

                midiOutput = new MidiOut(midiOutDevicesCB.SelectedIndex);

                midiOutConfirmButton.ImageIndex = 1;
                outReady = true;
                checkReady(true);
            }
        }

        private bool checkReady(bool act)
        {
            if(inReady && outReady)
            {
                if (act)
                {
                    midiConnectivityPB.Image = connectedImages.Images[1];
                }
                return true;
            }
            else
            {
                if (act)
                {
                    midiConnectivityPB.Image = connectedImages.Images[0];
                    midiActivityPB.Image = activityImages.Images[0];
                }
                return false;
            }
        }

        private void MIDIThruTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                midiInput.Stop();
                midiInput.Close();
                midiInput.Dispose();
                midiOutput.Close();
                midiOutput.Dispose();
            }
            catch (NullReferenceException)
            {
                //Do Nothing
            }
            catch (NAudio.MmException)
            {
                //MIDI Device was disconnected before stopping
            }
        }
    }
}
