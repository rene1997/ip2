using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network.Packets
{
    public class PacketBroadcastResponse : Packet
    {
        public string message { get; set; }
        public string sender { get; set; }

        public PacketBroadcastResponse(string message, string sender)
        {
            this.message = message;
            this.sender = sender;
        }

        public override void handleClientSide(ClientInterface clientinterface)
        {
            clientinterface.BroadcastResponse(sender, message);
        }
    }
}
