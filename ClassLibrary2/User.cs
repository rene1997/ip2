using System;
using System.Runtime.Serialization;

namespace Network
{
    [Serializable]
    public class User 
    {
        public string username { get; set; }
        public string password { get; set; }
        public bool isMale { get; set; }
        public bool isOnline { get; set; }

        public User (string username, string password, bool isMale)
        {
            this.username = username.ToLower();
            this.password = PasswordHash.HashPassword(password);
            this.isMale = isMale;
        }

        //deserialization function
        public User(SerializationInfo info, StreamingContext ctxt)
        {
            username = (string)info.GetValue("username", typeof(string));
            password = (string)info.GetValue("password", typeof(string));
            try
            {
                isMale = (bool)info.GetValue("isMale", typeof(bool));
            }
            catch (Exception e)
            {
                isMale = true;
            }
            isOnline = (bool)info.GetValue("isOnline", typeof(bool));
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
            info.AddValue("isOnline", isOnline);
            info.AddValue("isMale", isMale);
        }

        public override string ToString()
        {
            return username;
        }

    }
}
