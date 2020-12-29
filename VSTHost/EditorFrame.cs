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
    public partial class EditorFrame : Form
    {
        public EditorFrame()
        {
            InitializeComponent();
        }

        public Jacobi.Vst.Core.Host.IVstPluginCommandStub PluginCommandStub { get; set; }

        public new DialogResult ShowDialog(IWin32Window owner)
        {
            this.Text = PluginCommandStub.Commands.GetEffectName();

            if(PluginCommandStub.Commands.EditorGetRect(out Rectangle wndRect))
            {
                this.Size = this.SizeFromClientSize(new Size(wndRect.Width, wndRect.Height));
                PluginCommandStub.Commands.EditorOpen(this.Handle);
            }

            return base.ShowDialog(owner);
        }

        public new void ShowWindow()
        {
            this.Text = PluginCommandStub.Commands.GetEffectName();

            if(PluginCommandStub.Commands.EditorGetRect(out Rectangle wndRect))
            {
                this.Size = this.SizeFromClientSize(new Size(wndRect.Width, wndRect.Height));
                PluginCommandStub.Commands.EditorOpen(this.Handle);
            }

            base.Show();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            if (!e.Cancel)
            {
                PluginCommandStub.Commands.EditorClose();
            }
        }
    }
}