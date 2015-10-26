using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network
{
    [Serializable]
    public class Measurement : IComparable<Measurement>
    {
        public int pulse { get; }
        public int rpm { get; }
        public int speed { get; }
        public int distance { get; }
        public int requested_power { get; }
        public int energy { get; }
        public int actual_power { get; }
        public string time { get; }

        public Measurement(int pulse, int rpm, int speed, int distance, int requested_power, int energy, string time, int actual_power)
        {
            this.pulse = pulse;
            this.rpm = rpm;
            this.speed = speed;
            this.distance = distance;
            this.requested_power = requested_power;
            this.energy = energy;
            this.actual_power = actual_power;
            this.time = time;
        }

        //Sorting on time
        public int CompareTo(Measurement other)
        {
            //time of this Measurement 
            string[] splittedTime = time.Split(':');
            int hours = Int32.Parse(splittedTime[0]);
            int minutes = Int32.Parse(splittedTime[1]);

            //time of the other Measurement
            string[] splittedTimeOther = other.time.Split(':');
            int hoursOther = Int32.Parse(splittedTimeOther[0]);
            int minutesOther = Int32.Parse(splittedTimeOther[1]);

            if (hours > hoursOther)
                return -1;
            else if (hours < hoursOther)
                return 1;
            else
            {
                if (minutes > minutesOther)
                    return -1;
                else if (minutes < minutesOther)
                    return 1;
                else
                    return 0;
            }
        }

        public override string ToString()
        {
            return "pulse: \t" + pulse +
                   "\nrpm: \t" + rpm +
                   "\nspeed: \t" + speed +
                   "\ndistance: \t" + distance +
                   "\nrequested power: \t" + requested_power +
                   "\nenergy: \t" + energy +
                   "\nactual power: \t" + actual_power +
                   "\ntime: \t" + time;
        }
    }
}
