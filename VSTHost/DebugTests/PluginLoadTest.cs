using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jacobi.Vst.Host.Interop;
using Jacobi.Vst.Core;
using System.Diagnostics;

namespace VSTHost
{
    public partial class PluginLoadTest : Form
    {
        private VstPluginContext _plugin;

        public PluginLoadTest()
        {
            InitializeComponent();
        }

        private void selectVSTButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                vstPathTB.Text = openFileDialog.FileName;
            }
        }

        private void loadVSTButton_Click(object sender, EventArgs e)
        {
            _plugin = LoadPlugin(vstPathTB.Text);
        }

        private VstPluginContext LoadPlugin(string pluginPath)
        {
            try
            {
                HostCommandStub hostCommandStub = new HostCommandStub();
                hostCommandStub.PluginCalled += new EventHandler<PluginCalledEventArgs>(hostCommandStub_PluginCalled);
                VstPluginContext ctx = VstPluginContext.Create(pluginPath, hostCommandStub);
                ctx.Set("PluginPath", pluginPath);
                ctx.Set("HostCmdStub", hostCommandStub);
                ctx.PluginCommandStub.Commands.Open();

                selectVSTButton.Enabled = false;
                loadVSTButton.Enabled = false;

                return ctx;
            }
            catch(Exception e)
            {
                MessageBox.Show(this, e.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        private void showPluginWindowButton_Click(object sender, EventArgs e)
        {
            EditorFrame dlg = new EditorFrame
            {
                PluginCommandStub = _plugin.PluginCommandStub
            };

            _plugin.PluginCommandStub.Commands.MainsChanged(true);
            //dlg.ShowDialog(this);
            dlg.ShowWindow();
            _plugin.PluginCommandStub.Commands.MainsChanged(false);
        }

        private void hostCommandStub_PluginCalled(object sender, PluginCalledEventArgs e)
        {
            HostCommandStub hostCmdStub = (HostCommandStub)sender;

            if(hostCmdStub.PluginContext.PluginInfo != null)
            {
                if (logtombCB.Checked)
                {
                    MessageBox.Show(this, "Plugin " + hostCmdStub.PluginContext.PluginInfo.PluginID + " called: " + e.Message, "Plugin message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Debug.WriteLine("Plugin " + hostCmdStub.PluginContext.PluginInfo.PluginID + " called: " + e.Message);
                }
            }
            else
            {
                if (logtombCB.Checked)
                {
                    MessageBox.Show(this, "The loading Plugin called: " + e.Message, "Plugin message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Debug.WriteLine("The loading Plugin called: " + e.Message);
                }
            }
        }

        private void powerOnCB_CheckedChanged(object sender, EventArgs e)
        {
            if (powerOnCB.Checked)
            {
                _plugin.PluginCommandStub.Commands.SetBlockSize(1024);
                _plugin.PluginCommandStub.Commands.SetSampleRate(44100f);
                _plugin.PluginCommandStub.Commands.MainsChanged(true);
                _plugin.PluginCommandStub.Commands.StartProcess();
                StartVoidBuffers(1024);
            }
            else
            {
                _plugin.PluginCommandStub.Commands.StopProcess();
                _plugin.PluginCommandStub.Commands.MainsChanged(false);
            }
        }

        private void StartVoidBuffers(int blockSize)
        {
            int inputCount = _plugin.PluginInfo.AudioInputCount;
            int outputCount = _plugin.PluginInfo.AudioOutputCount;

            using VstAudioBufferManager inputMgr = new VstAudioBufferManager(inputCount, blockSize);
            using VstAudioBufferManager outputMgr = new VstAudioBufferManager(outputCount, blockSize);
            VstAudioBuffer[] inputBuffers = inputMgr.Buffers.ToArray();
            VstAudioBuffer[] outputBuffers = outputMgr.Buffers.ToArray();
            _plugin.PluginCommandStub.Commands.ProcessReplacing(inputBuffers, outputBuffers);

        }

        private void PluginLoadTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReleasePlugin();
        }

        private void ReleasePlugin()
        {
            try
            {
                _plugin.Dispose();
            }
            catch (NullReferenceException)
            {
                //Do Nothing
            }
        }
    }
}
