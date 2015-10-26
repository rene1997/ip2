using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    public class PacketChatMessageResponse : Packet
    {
        public string message { get; set; }
        public string sender { get; set; }
        public string receiver { get; set; }

        public PacketChatMessageResponse(string message, string sender, string receiver)
        {
            this.message = message;
            this.sender = sender;
            this.receiver = receiver;
        }

        public override void handleClientSide(ClientInterface clientInterface)
        {
            Console.WriteLine("sender: " + sender + " receiver: " + receiver);
            clientInterface.ChatMessageResponse(sender, receiver, message);
        }
    }
}
