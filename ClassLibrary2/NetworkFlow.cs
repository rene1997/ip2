using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.Security;

namespace Network
{
    public class NetworkFlow
    {
        public static bool SendPacket(Packet packet, SslStream ssl)
        {
            BinaryFormatter binairyFormatter = new BinaryFormatter();

            try
            {
                binairyFormatter.Serialize(ssl, packet);
                ssl.Flush();
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }

        public static Packet ReadPacket(SslStream ssl)
        {
            BinaryFormatter binairyFormatter = new BinaryFormatter();
            Packet packet;
            try
            {
                packet = (Packet) binairyFormatter.Deserialize(ssl);
                ssl.Flush();
            }
            catch (Exception e)
            {
                return null;
            }
            return packet;
        }
    }
}