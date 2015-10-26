using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Net.Security;
using Network;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;


namespace server_application
{
    [Serializable]
    public class Serverapplication
    {
        // Certificaat
        private X509Certificate2 cert = new X509Certificate2(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\Shared Server Client\cyclemaster.pfx",
                                                              "admin", X509KeyStorageFlags.MachineKeySet);

        private List<ServerClient> ConnectedClients { get; }

        public List<User> users = new List<User>();

        private SslStream ssl;

        public Serverapplication()
        {
            ConnectedClients = new List<ServerClient>();
            LoadAllData();
            
            //DO NOT UNCOMMENT THIS, OTHERWISE ALL USERS WILL BE ADDED MULTIPLE TIMES!
            /*//add test users obviously for testing
            users.Add(new UserClient("Henk", "banaan"));     
            //Test online users:
            ServerClient boefjeeee = new ServerClient(null, this);
            UserClient boefje = new UserClient("Boef", "lol");
            boefjeeee.user = boefje;
            ConnectedClients.Add(boefjeeee);
            ServerClient boefje2 = new ServerClient(null, this);
            boefje2.user = new UserClient("Boef2", "lol");
            ConnectedClients.Add(boefje2);
            Physician jaap = new Physician("Jaap", "appel");
            jaap.addClient(boefje);
            users.Add(jaap);*/

            //SaveAllData();

            TcpListener listener = new TcpListener(IPAddress.Any, 130);
            listener.Start();
            

            while (true)
            {
                Console.WriteLine("Waiting for Client Connections");
                TcpClient client = listener.AcceptTcpClient();
                // Authenticate cert
                ssl = new SslStream(client.GetStream());
                ssl.AuthenticateAsServer(cert, true, SslProtocols.Tls12, true);

                string ipAddress = "" + IPAddress.Parse(((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString());
                Console.WriteLine("Connected by {0} ({1}) on {2} ", ssl.CipherAlgorithm, ssl.CipherStrength, ipAddress.ToString());
                ConnectedClients.Add(new ServerClient(client, this, ssl));
            }
        }

        public List<ServerClient> getConnectedClients()
        {
            return ConnectedClients;
        }

        public User GetUserFromPhysician(string username)
        {
            //Boolean isonline;
            foreach (User user in users)
            {
                if (user is Physician)
                {
                    foreach (User user2 in ((Physician)user).clients)
                    {
                        if (user2.username.Equals(username))
                        {
                            Console.WriteLine("gevonde use: " + user2);
                            return user2;
                        }
                    }
                }
            }
            return null;
        }

        public List<UserClient> GetConnectedUsers(string physicianName)
        {
            List<User> users = new List<User>();
            Physician physician = null;
            foreach (ServerClient client in ConnectedClients)
            {
                if (client.user is Physician)
                {
                    if (client.user.username.Equals(physicianName))
                        physician = (Physician)client.user;
                }
                else
                    users.Add(client.user);
            }
            /*
            Console.WriteLine("\nThe users: ");
            foreach(User user in users)
                Console.WriteLine(user);
            Console.WriteLine("\nThe physician shit");
            foreach (User user in physician.clients)
                Console.WriteLine(user);*/

            try
            {
                //Console.WriteLine("usersss: " + users.Count + "  specia: " + physician.clients.Count );
                //List<UserClient> connectedUsers = physician.clients;
                //Console.WriteLine("size: " + connectedUsers.Count);
                return physician.clients;
            }
            catch(Exception e)
            {
                Console.WriteLine("FATAL ERROR");
                return null;
            }
        }

        public void AddNewUser(User newUser, string physicianName)
        {
            Console.WriteLine("naam2: " + physicianName);
            Physician physician = null;
            foreach (ServerClient client in ConnectedClients)
            {
                if (client.user is Physician)
                {
                    Console.WriteLine("found one");
                    if (client.user.username.Equals(physicianName))
                    {
                        Console.WriteLine("sameee");
                        physician = (Physician)client.user;
                    }
                }
                   
            }
            physician.addClient((UserClient)newUser);
            users.Add(newUser);
            SaveAllData();
        }

        public ServerClient getUser(string username)
        {
            foreach(ServerClient client in ConnectedClients)
            {
                if (client.user.username.ToLower().Equals(username.ToLower()))
                    return client;
            }
            return null;
        }

        public User getUserClient(string username)
        {
            foreach (User user in users)
            {
                if (user.username.ToLower().Equals(username.ToLower()))
                    return user;
            }
            return null;
        }

        public ServerClient getPhysicianClient(string name)
        {
            foreach(ServerClient client in ConnectedClients) 
                if (client.user is Physician)
                    if (client.user.username.Equals(name))
                        return client;
            return null;
        }

        public void SaveAllData()
        {
            Console.WriteLine(users.Count);
            //save clientfiles
            FileStream streamClient = new FileStream("clients.a3", FileMode.Create);
            BinaryFormatter bformatter = new BinaryFormatter();

            Console.WriteLine("Writing clients Information");
            foreach (User u in users)
            {
                Console.WriteLine(u.username);
                bformatter.Serialize(streamClient, u);
            }
                

            streamClient.Close();
        }

        public void LoadAllData()
        {
            BinaryFormatter bformatter = new BinaryFormatter();

            //Open the file and read values from client.
            FileStream streamClient = new FileStream("clients.a3", FileMode.Open);
            bformatter = new BinaryFormatter();

            Console.WriteLine("Reading client Information");
            
            while (streamClient.Position < streamClient.Length)
                try
                {
                    User u = (User)bformatter.Deserialize(streamClient);
                    Console.WriteLine(u.username);
                    if (u is UserClient)
                        users.Add((UserClient)u);
                    else if (u is Physician)
                        users.Add((Physician)u);
                    else
                        Console.WriteLine("error loading client" + u.username);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    //TODO show error
                }
            Console.WriteLine(users.Count);
            streamClient.Close();
        }
    }
}