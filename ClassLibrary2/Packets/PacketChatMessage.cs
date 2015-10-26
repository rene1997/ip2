using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Network
{
    [Serializable]
    public class PacketChatMessage:Packet
    {
        public string message { get; set; }
        public string sender { get; set; }
        public string receiver { get; set; }

        public PacketChatMessage(string message,string sender, string receiver)
        {
            this.message = message;
            this.sender = sender;
            this.receiver = receiver;
        }

       

        public override void handleServerSide(ServerInterface serverInterface)
        {
            serverInterface.ChatMessage(sender, receiver, message);
        }

        public override void handleClientSide(ClientInterface clientInterface)
        {
            clientInterface.ChatMessageResponse(sender, receiver, message);
        }
    }
}
