﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Network
{
    [Serializable]
    public class UserClient : User, ISerializable
    {
        public List<Session> sessions { get; }
        public string physician { get; }
        
        public UserClient(string username, string userPassword, string physician, bool isMale): base(username,userPassword, isMale)
        {
            this.physician = physician;
            sessions =  new List<Session>();
        }

        //deserialize method
        public UserClient(SerializationInfo info, StreamingContext ctxt)
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
            
            try
            {
                isOnline = (bool)info.GetValue("isOnline", typeof(bool));
            }
            catch(Exception e )
            {
                isOnline = false;
            }
            try {
                physician = (string)info.GetValue("physician", typeof(string));
            }
            catch(Exception e)
            {
                physician = "jaap";
            }
            try { 
                sessions = (List<Session>)info.GetValue("sessions", typeof(List<Session>));
            }
            catch(Exception e)
            {
               sessions = new List<Session>();
            }
        }


        public void addSession(DateTime startedDate, trainingen training)
        {
            Session s = new Session(startedDate, training, sessions.Count + 1);
            sessions.Add(s);
        }

        public void addMeasurement(Measurement measurement)
        {
            Session s = sessions.Last();
            addMeasurement(s, measurement);
        }


        public void addMeasurement(Session session, Measurement measurement)
        {
            session.AddMeasurement(measurement);
        }

        public List<Session> getSessions()
        {
            return sessions;
        }

        public Session lastSession()
        {
            if (sessions.Count == 0)
                sessions.Add(new Session(DateTime.Now, trainingen.other, sessions.Count +1));

            return sessions.Last();
        }

        public Measurement lastMeasurement()
        {
            return lastSession().GetLastMeasurement();
        }

        public int getSizeDing()
        {
            return sessions.Count;
        }
         
        //serialize method
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("username", username);
            info.AddValue("password", password);
            info.AddValue("isOnline", isOnline);
            info.AddValue("physician", physician);
            info.AddValue("sessions", sessions);
            info.AddValue("isMale", isMale);

        }
    }
}
