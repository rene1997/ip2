using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network   
{
    [Serializable]
    public class Packet
    {
        public virtual void handleClientSide(ClientInterface clientInterface)
        { }
        public virtual void handleServerSide(ServerInterface serverInterface)
        { }
    }
}
