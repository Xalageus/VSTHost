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

namespace VSTHost
{
    public partial class MIDIInputTest : Form
    {
        private MidiIn midiInput;
        private BindingList<string> logList;

        public MIDIInputTest()
        {
            InitializeComponent();

            logList = new BindingList<string>();
            midiInLogLB.DataSource = logList;
            logList.ListChanged += new ListChangedEventHandler(logList_ListChanged);
            searchForMIDIInDevices();
        }

        private void searchForMIDIInDevices()
        {
            midiDevicesCB.Items.Clear();

            for (int i = 0; i < MidiIn.NumberOfDevices; i++)
            {
                midiDevicesCB.Items.Add(MidiIn.DeviceInfo(i).ProductName);
            }
            if (midiDevicesCB.Items.Count == 0)
            {
                midiDevicesCB.Enabled = false;
                midiDevicesCB.Items.Add("No MIDI Input devices found");
                midiDevicesCB.SelectedIndex = 0;
            }
            else
            {
                midiDevicesCB.SelectedIndex = 0;
                midiDevicesCB.Enabled = true;
            }
        }

        private void refreshMIDIButton_Click(object sender, EventArgs e)
        {
            searchForMIDIInDevices();
        }

        private void listenButton_Click(object sender, EventArgs e)
        {
            midiDevicesCB.Enabled = false;
            listenButton.Enabled = false;
            refreshMIDIButton.Enabled = false;

            midiInput = new MidiIn(midiDevicesCB.SelectedIndex);
            midiInput.MessageReceived += midiInput_MessageReceived;
            midiInput.ErrorReceived += midiInput_ErrorReceived;
            midiInput.Start();
        }

        void midiInput_ErrorReceived(object sender, MidiInMessageEventArgs e)
        {
            midiInLogLB.Invoke((Action)delegate
            {
                logList.Add(String.Format("Time {0} Message 0x{1:X8} Event {2}", e.Timestamp, e.RawMessage, e.MidiEvent));
            });
        }

        void midiInput_MessageReceived(object sender, MidiInMessageEventArgs e)
        {
            midiInLogLB.Invoke((Action)delegate
            {
                logList.Add(String.Format("Time {0} Message 0x{1:X8} Event {2}", e.Timestamp, e.RawMessage, e.MidiEvent));
            });
        }

        private void MIDIInputTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                midiInput.Stop();
                midiInput.Close();
                midiInput.Dispose();
            }
            catch (NullReferenceException)
            {
                //Do Nothing
            }catch(NAudio.MmException){
                //MIDI Device was disconnected before stopping
            }
        }

        void logList_ListChanged(object sender, ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.ItemAdded:
                    if(logList.Count > 0)
                    {
                        midiInLogLB.SelectedIndex = logList.Count - 1;
                        midiInLogLB.SelectedIndex = -1;
                    }
                    break;
            }
        }
    }
}
