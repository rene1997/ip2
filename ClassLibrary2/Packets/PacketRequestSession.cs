using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network.Packets
{
    [Serializable]
    class PacketRequestSession:Packet
    {
        string client;
        int SesionID;

        public PacketRequestSession(string client,int SesionID)
        {
            this.client = client;
            this.SesionID = SesionID;
        }
        
    }
}
