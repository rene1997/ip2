using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Network
{
    public enum trainingen { none, astrand, newAstrand, other }

    [Serializable]
    public class Session 
    {
        public DateTime startedDate { get; private set; }
        public List<Measurement> measurements = new List<Measurement>();
        public int training;
        public int id;

        public Session(DateTime startedDate, trainingen training, int id)
        {
            this.startedDate = startedDate;
            this.training = (int)training;
            this.id = id;
        }

        //deserialization function
        public Session(SerializationInfo info, StreamingContext ctxt)
        {
            try
            {
                startedDate = (DateTime)info.GetValue("startedDate", typeof(DateTime));
                measurements = (List<Measurement>)info.GetValue("measurements", typeof(List<Measurement>));
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void AddMeasurement(Measurement measurement)
        {
            measurements.Add(measurement);
        }

        public List<Measurement> getMeasurement()
        {
            return measurements;
        }

        public Measurement GetLastMeasurement()
        {
            if (measurements.Count > 0)
                return measurements.Last();
            else
                return null;
        }

        //serialize method
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("startedDate", startedDate);
            info.AddValue("measurements", measurements);
        }

        public override string ToString()
        {
            return "trainingstype is: " +  (trainingen)training +  " id: " + id  + "aantal measurements: " + measurements.Count;
        }
    }
}
