using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace chat_app.net
{
    class Server
    {
        TcpClient _client;
        public Server()  //server constructor
        {
            _client = new TcpClient();  
        }
        public void ConnectToServer()
        {
            if(!_client.Connected) //check if client is connected
            {
                _client.Connect("127.0.0.1", 8000); 
            }
        }
    }
}
