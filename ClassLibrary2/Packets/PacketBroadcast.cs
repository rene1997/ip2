using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network.Packets
{
    [Serializable]
    public class PacketBroadcast : Packet
    {
        public string message { get; set; }
        public string sender { get; set; }
        
        public PacketBroadcast(string message, string sender)
        {
            this.message = message;
            this.sender = sender;
        }

        public override void handleServerSide(ServerInterface serverInterface)
        {
            serverInterface.Broadcast(sender, message);
        }
    }
}
