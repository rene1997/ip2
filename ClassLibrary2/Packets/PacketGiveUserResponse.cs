using System;
using System.Collections.Generic;

namespace Network
{
    [Serializable]
    public class PacketGiveUserResponse : Packet
    {
        private List<User> users1;

        private User user { get; }
        private List<UserClient> users { get; }

        public PacketGiveUserResponse(User user)
        {
            this.user = user;
        }

        public PacketGiveUserResponse(List<UserClient> users)
        {
            this.users = users;
        }

        public PacketGiveUserResponse(List<User> users1)
        {
            this.users1 = users1;
        }

        public override void handleClientSide(ClientInterface clientInterface)
        {
            if (user != null)
                clientInterface.GiveUserResponse(user);
            else
                clientInterface.GiveUserResponse(users); 
        }
    }
}
