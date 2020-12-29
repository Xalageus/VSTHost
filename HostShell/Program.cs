using System;
using VSTHost;
using System.Threading;

namespace HostShell
{
    class Program
    {
        static void Main(string[] args)
        {
            VSTHost.Loader host = new VSTHost.Loader();
            Thread thread = new Thread(() => host.Init());
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
