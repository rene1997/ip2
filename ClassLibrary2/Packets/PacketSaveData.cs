using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    [Serializable]
    public class PacketSaveData : Packet
    {
        public bool succesfull { get; set; }
        public PacketSaveData()
        {
            
        }

        public override void handleServerSide(ServerInterface serverInterface)
        {
            serverInterface.SaveData();
        }

        public override void handleClientSide(ClientInterface clientInterface)
        {
            clientInterface.SaveDataResponse(succesfull);
        }
    }

}
