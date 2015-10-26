using System;
using System.Collections.Generic;
using Network;
using System.Threading;
using Network.Packets;

namespace WindowsFormsApplication1
{
    public class Networkconnect : ClientInterface
    {
        private NetworkCommunication networkCommunication;
        public string status { get; set; }
        public string power { get; set; }
        public string time { get; set; }
        public string distance { get; set; }
        private string ipAdress;
        private int port;
        private bool loginOk, isPhysician;
        public List<User> users { get; private set; }
        public User user { get; private set; }
        private FormClient parent;

        public Networkconnect(string ipAdress, int port)
        {
            this.ipAdress = ipAdress;
            this.port = port;
            networkCommunication = new NetworkCommunication(ipAdress, port, this);
            Thread connectionThread = new Thread(new ThreadStart(TryConnecting));
            connectionThread.IsBackground = true;
            connectionThread.Start();    
        }

        public void SetParent(FormClient parent)
        {
            this.parent = parent;
        }

        public void TryConnecting()
        {
            while(!networkCommunication.ConnectToServer())
            {
                status = "Can't connect to: " + ipAdress + ":" + port;
                Thread.Sleep(5000);
            }
            status = "Connected";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username">The username</param>
        /// <param name="password">The password</param>
        /// <returns>Whether or not the login was succesful</returns>
        public Tuple<bool,bool> login(string username, string password)
        {
            networkCommunication.sendPacket(new PacketLogin(username,password));
            Thread.Sleep(1000);
            return new Tuple<bool, bool>(loginOk,isPhysician);
        }

        public void addNewClient(User user, string physicianName)
        {
            networkCommunication.sendPacket(new PacketAddClient(user, physicianName));
        }

        public void sendBikeValues(string power, string time, string distance, string username)
        {
            networkCommunication.sendPacket(new PacketBikeValues(power, time, distance, username));
        }

        public void sendMeasurement(Measurement measurement, string physicianName, string sessionType)
        {
            networkCommunication.sendPacket(new PacketMeasurement(measurement, physicianName,sessionType));
        }
        
        public void sendChatMessage(string message, string sender, string receiver)
        {
            networkCommunication.sendPacket(new PacketChatMessage(message, sender, receiver));
        }

        public void sendSaveData()
        {
            networkCommunication.sendPacket(new PacketSaveData());
        }

        public void sendBroadcast(string message, string sender)
        {
            networkCommunication.sendPacket(new PacketBroadcast(message, sender));
        }

        public void getChatMessage(PacketChatMessage chatPacket)
        {
            parent.getChatMessage(chatPacket.sender, chatPacket.message);
        }

        public void getBroadcast(PacketBroadcast broadcastPacket)
        {
            parent.getChatMessage(broadcastPacket.sender, broadcastPacket.message);
        }

        public void loginResponse(bool loginOk, bool isPhysician)
        {
            this.loginOk = loginOk;
            this.isPhysician = isPhysician;
        }

        //Get all users that are currently online.
        public List<User> GetAllConnectedUsers(string physicianName)
        {
            networkCommunication.sendPacket(new PacketGiveUser("*",false,physicianName));
            Thread.Sleep(1000);
            return users;
        }

        //Get all users in the database.
        public List<User> GetAllUsers()
        {
            networkCommunication.sendPacket(new PacketGiveUser("*", true, ""));
            Thread.Sleep(1000);
            return users;
        }

        public User getUser(string username)
        {
            networkCommunication.sendPacket(new PacketGiveUser(username, true, ""));
            Thread.Sleep(50);
            return user;
        }

        public void GiveUserResponse(User user)
        {
            this.user = user;
        } 

        public void GiveUserResponse(List<User> users)
        {
            this.users = users;
        }

        public void LoginResponse(bool loginOk, bool isPhysician)
        {
            this.loginOk = loginOk;
            this.isPhysician = isPhysician;
        }

        public void GiveUserResponse(List<UserClient> users)
        {
            try
            {
                List<User> tempusers = users.ConvertAll(user => (User)user);
                this.users = tempusers;
                parent.FillUserComboBox();
            }
            catch(Exception e){
                Console.WriteLine("error in NetworkConnect GiveUserResponse(List<UserClient> user) /n"  + e);
            }
        }

        public void BikeValuesResponse(string power, string time, string distance)
        {
            this.power = power;
            this.time = time;
            this.distance = distance;
            parent.SetBikeValues(power, time, distance);
        }

        public void ChatMessageResponse(string sender, string receiver, string message)
        {
            parent.getChatMessage(sender, message);
        }

        public void BroadcastResponse(string sender, string message)
        {
            parent.getChatMessage(sender, message);
        }

        public void SaveDataResponse(bool succesfull)
        {
            parent.DataSaved(true);
        }
    }
}
