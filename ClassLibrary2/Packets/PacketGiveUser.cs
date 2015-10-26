using System;

namespace Network
{
    [Serializable]
   public class PacketGiveUser : Packet
    {
        private string username { get; }
        private string physicianName { get; }
        private bool allUsers { get; }
        
        //Use * to get all users;
        public PacketGiveUser(string username, bool allUsers, string physicianName)
        {
            this.username = username;
            this.allUsers = allUsers;
            this.physicianName = physicianName;
        }

        public override void handleServerSide(ServerInterface serverInterface)
        {
            serverInterface.GiveUser(username, allUsers, physicianName);
        }
    }
}
