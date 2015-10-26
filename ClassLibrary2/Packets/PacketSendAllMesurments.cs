using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network.Packets
{
    class PacketSendAllMesurments
    {
        public ArrayList Measurement;
        public PacketSendAllMesurments(ArrayList Measurement)
        {
            this.Measurement = Measurement;
        }
    }
}
