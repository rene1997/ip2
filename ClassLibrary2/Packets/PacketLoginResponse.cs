using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    [Serializable]
    public class PacketLoginResponse : Packet
    {
        public bool loginOk { get; }
        public bool isPhysician { get; }

        public PacketLoginResponse(bool loginOk, bool isPhysician)
        {
            this.loginOk = loginOk;
            this.isPhysician = isPhysician;
        }

        public override void handleClientSide(ClientInterface clientInterface)
        {
            clientInterface.LoginResponse(loginOk,isPhysician);
        }
    }
}
