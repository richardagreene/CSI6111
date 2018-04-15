using CSI6111.Shared;
using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

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

        /// <summary>
        /// Register the command
        /// </summary>
        /// <param name="name"></param>
        /// <param name="command"></param>
        private static void RegisterCommand(string name, Type command)
        {
            WellKnownServiceTypeEntry remObj = new WellKnownServiceTypeEntry
            ( command, name, WellKnownObjectMode.SingleCall );
            RemotingConfiguration.RegisterWellKnownServiceType(remObj);
        }
    }
}
