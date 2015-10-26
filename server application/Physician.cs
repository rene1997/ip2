using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace server_application
{
    [Serializable]
    public class Physician : User, ISerializable
    {
        private List<UserClient> clients = new List<UserClient>();
        public Physician(String username, string password): base(username, password)
        {
        }

        //deserialize method (constructor)
        public Physician(SerializationInfo info, StreamingContext ctxt)
        {
            username = (string)info.GetValue("username", typeof(string));
            password = (string)info.GetValue("password", typeof(string));
            //clients = (List<clients>)info.GetValue("clients", typeof(List<>));

        }

        public void addClient(UserClient client)
        {
            clients.Add(client);
        }

        //serialize method
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("username", username);
            info.AddValue("password", password);
            //info.AddValue("clients", clients);
        }
    }
}
