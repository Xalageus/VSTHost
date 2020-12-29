using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jacobi.Vst.Core;
using Jacobi.Vst.Core.Host;

namespace VSTHost
{
    class HostCommandStub : IVstHostCommandStub
    {
        public HostCommandStub()
        {
            Commands = new HostCommands(this);
        }

        public event EventHandler<PluginCalledEventArgs> PluginCalled;

        private void RaisePluginCalled(string message)
        {
            PluginCalled?.Invoke(this, new PluginCalledEventArgs(message));
        }

        public IVstPluginContext PluginContext { get; set; }
        public IVstHostCommands20 Commands { get; private set; }

        private class HostCommands : IVstHostCommands20
        {
            private readonly HostCommandStub _cmdStub;

            public HostCommands(HostCommandStub cmdStub)
            {
                _cmdStub = cmdStub;
            }

            #region IVstHostCommands20 Members

            /// <inheritdoc />
            public bool BeginEdit(int index)
            {
                _cmdStub.RaisePluginCalled("BeginEdit(" + index + ")");

                return false;
            }

            /// <inheritdoc />
            public Jacobi.Vst.Core.VstCanDoResult CanDo(string cando)
            {
                _cmdStub.RaisePluginCalled("CanDo(" + cando + ")");
                return Jacobi.Vst.Core.VstCanDoResult.Unknown;
            }

            /// <inheritdoc />
            public bool CloseFileSelector(Jacobi.Vst.Core.VstFileSelect fileSelect)
            {
                _cmdStub.RaisePluginCalled("CloseFileSelector(" + fileSelect.Command + ")");
                return false;
            }

            /// <inheritdoc />
            public bool EndEdit(int index)
            {
                _cmdStub.RaisePluginCalled("EndEdit(" + index + ")");
                return false;
            }

            /// <inheritdoc />
            public Jacobi.Vst.Core.VstAutomationStates GetAutomationState()
            {
                _cmdStub.RaisePluginCalled("GetAutomationState()");
                return Jacobi.Vst.Core.VstAutomationStates.Off;
            }

            /// <inheritdoc />
            public int GetBlockSize()
            {
                _cmdStub.RaisePluginCalled("GetBlockSize()");
                return 1024;
            }

            /// <inheritdoc />
            public string GetDirectory()
            {
                _cmdStub.RaisePluginCalled("GetDirectory()");
                return null;
            }

            /// <inheritdoc />
            public int GetInputLatency()
            {
                _cmdStub.RaisePluginCalled("GetInputLatency()");
                return 0;
            }

            /// <inheritdoc />
            public Jacobi.Vst.Core.VstHostLanguage GetLanguage()
            {
                _cmdStub.RaisePluginCalled("GetLanguage()");
                return Jacobi.Vst.Core.VstHostLanguage.NotSupported;
            }

            /// <inheritdoc />
            public int GetOutputLatency()
            {
                _cmdStub.RaisePluginCalled("GetOutputLatency()");
                return 0;
            }

            /// <inheritdoc />
            public Jacobi.Vst.Core.VstProcessLevels GetProcessLevel()
            {
                _cmdStub.RaisePluginCalled("GetProcessLevel()");
                return Jacobi.Vst.Core.VstProcessLevels.Unknown;
            }

            /// <inheritdoc />
            public string GetProductString()
            {
                _cmdStub.RaisePluginCalled("GetProductString()");
                return "VSTHost";
            }

            /// <inheritdoc />
            public float GetSampleRate()
            {
                _cmdStub.RaisePluginCalled("GetSampleRate()");
                return 44.8f;
            }

            /// <inheritdoc />
            public Jacobi.Vst.Core.VstTimeInfo GetTimeInfo(Jacobi.Vst.Core.VstTimeInfoFlags filterFlags)
            {
                _cmdStub.RaisePluginCalled("GetTimeInfo(" + filterFlags + ")");
                return null;
            }

            /// <inheritdoc />
            public string GetVendorString()
            {
                _cmdStub.RaisePluginCalled("GetVendorString()");
                return "Xalageus";
            }

            /// <inheritdoc />
            public int GetVendorVersion()
            {
                _cmdStub.RaisePluginCalled("GetVendorVersion()");
                return 1000;
            }

            /// <inheritdoc />
            public bool IoChanged()
            {
                _cmdStub.RaisePluginCalled("IoChanged()");
                return false;
            }

            /// <inheritdoc />
            public bool OpenFileSelector(Jacobi.Vst.Core.VstFileSelect fileSelect)
            {
                _cmdStub.RaisePluginCalled("OpenFileSelector(" + fileSelect.Command + ")");
                return false;
            }

            /// <inheritdoc />
            public bool ProcessEvents(Jacobi.Vst.Core.VstEvent[] events)
            {
                _cmdStub.RaisePluginCalled("ProcessEvents(" + events.Length + ")");
                return false;
            }

            /// <inheritdoc />
            public bool SizeWindow(int width, int height)
            {
                _cmdStub.RaisePluginCalled("SizeWindow(" + width + ", " + height + ")");
                return false;
            }

            /// <inheritdoc />
            public bool UpdateDisplay()
            {
                _cmdStub.RaisePluginCalled("UpdateDisplay()");
                return false;
            }

            #endregion

            #region IVstHostCommands10 Members

            /// <inheritdoc />
            public int GetCurrentPluginID()
            {
                _cmdStub.RaisePluginCalled("GetCurrentPluginID()");
                return _cmdStub.PluginContext.PluginInfo.PluginID;
            }

            /// <inheritdoc />
            public int GetVersion()
            {
                _cmdStub.RaisePluginCalled("GetVersion()");
                return 1000;
            }

            /// <inheritdoc />
            public void ProcessIdle()
            {
                _cmdStub.RaisePluginCalled("ProcessIdle()");
            }

            /// <inheritdoc />
            public void SetParameterAutomated(int index, float value)
            {
                _cmdStub.RaisePluginCalled("SetParameterAutomated(" + index + ", " + value + ")");
            }

            #endregion
        }
    }

    class PluginCalledEventArgs : EventArgs
    {
        public string Message { get; private set; }

        public PluginCalledEventArgs(string message)
        {
            Message = message;
        }
    }
}
