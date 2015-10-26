using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    [Serializable]
    public class PacketBikeValuesResponse : Packet
    {
        private string power { get; }
        private string time { get; }
        private string distance { get; }
        private string username { get; }

        public PacketBikeValuesResponse(string power, string time, string distance)
        {
            this.power = power;
            this.time = time;
            this.distance = distance;
        }

        public override void handleClientSide(ClientInterface clientInterface)
        {
            clientInterface.BikeValuesResponse(power, time, distance);
        }
    }
}
