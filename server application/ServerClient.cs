using System;
using System.Net.Security;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using Network;
using Network.Packets;

namespace server_application
{
    [Serializable]
    public class ServerClient : ServerInterface
    {
        public TcpClient client { get; set; }
        private Serverapplication server;
        public User user { get; set; }
        public SslStream stream { get; }

        public ServerClient(TcpClient client, Serverapplication server, SslStream stream)
        {
            this.server = server;
            this.client = client;
            this.stream = stream;
            if (client != null)
            {
                new Thread(() =>
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    while (client.Connected)
                    {
                        Packet packet = NetworkFlow.ReadPacket(stream);
                        if (packet != null)
                        {
                            Console.WriteLine("recieved packet");
                            packet.handleServerSide(this);
                        }
                    }
                    server.getConnectedClients().Remove(this);
                    if (user != null)
                        user.isOnline = false;
                    Console.WriteLine("Client disconnected");
                }).Start();
            }
        }

        public void Login(string username, string password)
        {
            Console.WriteLine("Iemand probeert in te loggen als " + username + ", wachtwoord: " + password);
            //Actual login checking:
            foreach (User user in server.users)
            {
                if (user.username.ToLower().Equals(username.ToLower()))
                {
                    if (PasswordHash.ValidatePassword(password, user.password)) //succesfull login
                    { 
                        NetworkFlow.SendPacket(new PacketLoginResponse(true, user is Physician), stream);
                        Console.WriteLine("{0} succesfully logged in.",username);
                        if (user is Physician)
                           this.user = user;
                        else
                           this.user = server.GetUserFromPhysician(username);
                        this.user.isOnline = true;
                        Console.WriteLine("This is the user: " + user);
                        if (!(user is Physician) && server.getPhysicianClient(((UserClient)user).physician) != null)
                        {
                            List<UserClient> clients = server.GetConnectedUsers(((UserClient)user).physician);
                            NetworkFlow.SendPacket(new PacketGiveUserResponse(clients), server.getPhysicianClient(((UserClient)user).physician).stream);
                        }
                        break;
                    }
                    else //wrong password
                    {
                        Console.WriteLine("wrong password");
                        NetworkFlow.SendPacket(new PacketLoginResponse(false, user is Physician), stream);
                        break;
                    }
                }
            }
        }

        public void GiveUser(string username, bool allUsers, string physicianName)
        {
            Console.WriteLine("Someone is requesting the user: " + username);
            if(username.Equals("*"))
            {
                NetworkFlow.SendPacket(new PacketGiveUserResponse(server.GetConnectedUsers(physicianName)),stream);
                Console.WriteLine("Sending all users " + allUsers );
            }
            else
            {
                Console.WriteLine("Sending user: " + server.getUserClient(username));
                NetworkFlow.SendPacket(new PacketGiveUserResponse(server.GetUserFromPhysician(username)),stream);
            }
        }

        public void AddUser(User newUser, string physicianName)
        {
            Boolean addUser = true;

            //Last check to prevent creating an user that already excists
            foreach (User user in server.users)
            {
                if (user.username.ToLower().Equals(newUser.username.ToLower()))
                {
                    addUser = false;
                    break;
                }
            }
            //if no duplicate has been found, newUser can be added to the userlist
            if (addUser)
                server.AddNewUser(newUser, physicianName);

            Console.WriteLine("Succesfully created new user {0} with password {1}.", newUser.username, newUser.password);

        }

        public void Broadcast(string sender, string message)
        {
            foreach(User user in server.users)
            {
                ServerClient client = server.getUser(user.username);
                NetworkFlow.SendPacket(new PacketBroadcastResponse(sender, message),stream);
            }
        }
        public void ChatMessage(string sender, string receiver, string message)
        {
            if (receiver == sender)
            {
                foreach (User u in server.users)
                {
                    try
                    {
                        Physician p = (Physician)u;
                        if ((p != null) && (receiver == sender))
                        {
                            if (p.hashClient(sender) && (receiver == sender))
                            {
                                receiver = p.username;
                            }
                        }
                    }
                    catch { }
                }
            }
            
            ServerClient client = server.getUser(receiver);
            if (client != null)
            {
                Console.WriteLine("sending packet to: " + client.user.username);

                NetworkFlow.SendPacket(new PacketChatMessage(message, sender, receiver), client.stream);
            }
                
        }


        public void BikeValues(string power, string time, string distance, string username)
        {
            ServerClient client = server.getUser(username);
            if (client != null)
            { 
                Console.WriteLine("Send bike values to: " + client.user.username);
                NetworkFlow.SendPacket(new PacketBikeValuesResponse(power, time, distance), client.stream);
            }
        }

        public void ReceiveMeasurement(Measurement measurement, string physcianName, string sessionType)
        {
            UserClient userClient = (UserClient)user;
            Console.WriteLine("measurement shizzle");
            if (sessionType.Equals("Create"))
                userClient.addSession(DateTime.Now);
            else
            {
                userClient.addMeasurement(measurement);
                //ServerClient physician = server.getPhysicianClient(physcianName);
                //if (physician != null)
                //{
                //    Console.WriteLine("sending new user " + user.isOnline);
                //    NetworkFlow.SendPacket(new PacketGiveUserResponse(user), server.getPhysicianClient(((UserClient)user).physician).stream);
                //}
            }
        }

        public override string ToString()
        {
            return "ServerClient: " + user;
        }

        public void SaveData()
        {
            server.SaveAllData();
        }
    }
}
