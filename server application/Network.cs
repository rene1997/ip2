using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.Security;

namespace server_application
{
    class Network
    {

        public static string ReadTextMessage(SslStream sslStream)
        {

            StreamReader stream = new StreamReader(sslStream, Encoding.ASCII);
            string line = stream.ReadLine();
            return line;
        }

        public static void WriteTextMessage(SslStream sslStream, string message)
        {
            var stream = new StreamWriter(sslStream, Encoding.ASCII);
            stream.WriteLine(message);
            stream.Flush();
        }
        public static string ReadMessage(SslStream sslStream, TcpClient client)
        {

            byte[] buffer = new byte[256];
            int totalRead = 0;

            //read bytes until stream indicates there are no more
            do
            {
                int read = sslStream.Read(buffer, totalRead, buffer.Length - totalRead);
                totalRead += read;
                Console.WriteLine("ReadMessage: " + read);
            } while (client.GetStream().DataAvailable);

            return Encoding.Unicode.GetString(buffer, 0, totalRead);
        }

        private byte[] ObjectToByteArray(object obj)
        {
            if (obj == null)
                return null;

            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);
            return ms.ToArray();
        }
        private Object ByteArrayToObject(byte[] arrBytes)
        {
            MemoryStream memStream = new MemoryStream();
            BinaryFormatter binForm = new BinaryFormatter();
            memStream.Write(arrBytes, 0, arrBytes.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            Object obj = (Object)binForm.Deserialize(memStream);
            return obj;
        }
    }
}
