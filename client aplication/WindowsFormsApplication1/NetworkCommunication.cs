using System;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Net.Security;
using Network;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsApplication1
{
    class NetworkCommunication 
    {

        // Certificaat (Maar hier gebruiken we een collectie van certificaten)
        private X509Certificate2Collection certs = new X509Certificate2Collection();

        private string ipAdress;
        private int port;
        private TcpClient server;
        private SslStream ssl;
        private Networkconnect parent;

        public NetworkCommunication(string ipAdress, int port, Networkconnect parent)
        {
            this.ipAdress = ipAdress;
            this.port = port;
            this.parent = parent;

            // Certificaat toevoegen
            certs.Add(new X509Certificate2(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + @"\Shared Server Client\cyclemaster.pfx",
                                                              "admin", X509KeyStorageFlags.MachineKeySet));
        }

        public bool ConnectToServer()
        {

            try
            {
                server = new TcpClient(ipAdress, port);
                ssl = new SslStream(server.GetStream(), true, new RemoteCertificateValidationCallback(ValidateCertificate));
                ssl.AuthenticateAsClient("cyclemaster", certs, SslProtocols.Tls12, true);
                
            }
            catch(Exception e)
            {
                return false; //failed to connect.
            }
            Thread receiveThread = new Thread(new ThreadStart(ReceiveThread));
            receiveThread.IsBackground = true;
            receiveThread.Start();
            return true; //succesfully connected to server.
        }

        public void sendPacket(Packet packet)
        {
            NetworkFlow.SendPacket(packet, ssl);
        }

        private void ReceiveThread()
        {
            while (true)
            {
                Packet packet = NetworkFlow.ReadPacket(ssl);
                if(packet != null)
                     packet.handleClientSide(parent);
            }   
        }

        private bool ValidateCertificate(object sender, X509Certificate certificate, X509Chain certChain, SslPolicyErrors errors)
        {
            if (errors == SslPolicyErrors.None)
                return true;

            return false;
        }
    }
}
