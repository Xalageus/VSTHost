using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSTHost
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

#if DEBUG
            debugMenuItem.Visible = true;
            debugMenuItem.Enabled = true;
#endif
        }

        private void pltMenuItem_Click(object sender, EventArgs e)
        {
            PluginLoadTest plt = new PluginLoadTest();
            plt.Show();
        }

        private void aotMenuItem_Click(object sender, EventArgs e)
        {
            AudioOutputTest aot = new AudioOutputTest();
            aot.Show();
        }

        private void mitMenuItem_Click(object sender, EventArgs e)
        {
            MIDIInputTest mit = new MIDIInputTest();
            mit.Show();
        }

        private void mttMenuItem_Click(object sender, EventArgs e)
        {
            MIDIThruTest mtt = new MIDIThruTest();
            mtt.Show();
        }
    }
}
