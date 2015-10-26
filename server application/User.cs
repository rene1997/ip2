using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace server_application
{
    [Serializable]
    public class User 
    {
        public string username { get; set; }
        public string password { get; set; }

        public User (string username, string password)
        {
            this.username = username;
            this.password = password;
        }



        //deserialization function
        public User(SerializationInfo info, StreamingContext ctxt)
        {
            username = (string)info.GetValue("username", typeof(string));
            password = (String)info.GetValue("password", typeof(string));
        }

        public User()
        {

        }

        public bool checkPassword(string passwordTry)
        {
            return password.Equals(passwordTry);
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
