using CSI6111.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace CSI6111.ServerSide
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpServerChannel channel = new TcpServerChannel(9000);
            ChannelServices.RegisterChannel(channel, true);

            // -- Register any commands --
            RegisterCommand(nameof(Login), typeof(Login));
            RegisterCommand(nameof(Logoff), typeof(Logoff));
            RegisterCommand(nameof(Evaluate), typeof(Evaluate));
            RegisterCommand(nameof(RuOK), typeof(RuOK));

            Console.WriteLine("Press [ENTER] to exit.");
            Console.ReadLine();
        }

        private static void RegisterCommand(string name, Type command)
        {
            WellKnownServiceTypeEntry remObj = new WellKnownServiceTypeEntry
            ( command, name, WellKnownObjectMode.SingleCall );
            RemotingConfiguration.RegisterWellKnownServiceType(remObj);
        }
    }
}
