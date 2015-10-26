using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    [Serializable]
    public class PacketBikeValues : Packet
    {
        private string power { get; }
        private string time { get; }
        private string distance { get; }
        private string username { get; }

        public PacketBikeValues(string power, string time, string distance, string username)
        {
            this.power = power;
            this.time = time;
            this.distance = distance;
            this.username = username;
        }

        public override void handleServerSide(ServerInterface serverInterface)
        {
            serverInterface.BikeValues(power, time, distance, username);
        }
    }
}
