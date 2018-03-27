using CSI6111.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace CSI6111.Client
{
    public class Connection
    {
        TcpClientChannel _channel;
        string _host;
        string _port;
        bool _loggedIn;

        /// <summary>
        /// Check if the connection is already registered
        /// </summary>
        public bool Active {
            get {
                var channels = ChannelServices.RegisteredChannels;
                return channels.Any() ? channels.Select(c=>c.ChannelName).Contains(_channel.ChannelName) : false;
            }
        }

        public bool LoggedIn { get { return _loggedIn; } }

        public bool Connect(string host, string port)
        {
            _host = host;
            _port = port;
            _channel = new TcpClientChannel();
            // if already registered exit
            if (Active) return true;
            // Call the method to ensure connection can be made
            try
            {
                ChannelServices.RegisterChannel(_channel, true);
                IRuOK command = (IRuOK)Activator.GetObject(typeof(IRuOK), $"tcp://{_host}:{_port}/{nameof(RuOK)}");
                return command.Run();
            }
            catch (SocketException ex)
            {
                return false;
            }
        }

        public bool Disconnect()
        {
            ChannelServices.UnregisterChannel(_channel);
            return true;
        }

        /// <summary>
        /// Try to connect
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string username, string password)
        {
            try
            {
                ILogin command = (ILogin)Activator.GetObject(typeof(ILogin), $"tcp://{_host}:{_port}/{nameof(Login)}");
                _loggedIn = command.Run(username, password);
            }
            catch (SocketException ex)
            {
                return false;
            }
            return _loggedIn;
        }

        public bool Logoff()
        {
            try
            {
                ILogoff command = (ILogoff)Activator.GetObject(typeof(ILogoff), $"tcp://{_host}:{_port}/{nameof(Logoff)}");
                command.Run();
                _loggedIn = false;
            }
            catch (SocketException ex)
            {
                return false;
            }
            return true;
        }
    }
}
