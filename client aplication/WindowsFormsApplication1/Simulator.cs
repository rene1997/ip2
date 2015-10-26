using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WindowsFormsApplication1
{
    class Simulator
    {
        private int pulse, rpm, speed, minutes, seconds, distance, requested_power, energy, actual_power;

        private bool commandMode;

        public Simulator()
        {
            pulse = 50;
            Thread updateThread = new Thread(new ThreadStart(update));
            updateThread.IsBackground = true;
            updateThread.Start();
        }

        public String SendMessage(String command)
        {
            String splittedCommand = command.Substring(0,2);
            switch(splittedCommand)
            {
                case "RS":
                    speed = 0;
                    seconds = 0;
                    minutes = 0;
                    pulse = 0;
                    rpm = 0;
                    distance = 0;
                    requested_power = 0;
                    energy = 0;
                    actual_power = 0;
                    commandMode = false;
                    return "ACK";
                case "ID":
                    //return "SF1B1706";
                    return "Sim123";
                case "VE":
                    return "120";
                case "CM":
                    commandMode = true;
                    return "ACK";
                case "ST":
                    return getStatus();
                case "PW":
                    if (commandMode)
                    {
                        String[] newPower = command.Split(' ');
                        int convertedPower;
                        if (!Int32.TryParse(newPower[1], out convertedPower))
                        {
                            return "ERROR";
                        }
                        else
                        {
                            if (requested_power > 400)
                                requested_power = 400;
                            else if (requested_power < 0)
                                requested_power = 0;
                            else 
                                requested_power = convertedPower;
                            return getStatus();
                        }
                    }
                    return "";
                case "PD":
                    if (commandMode)
                    {
                        String[] newDistance = command.Split(' ');
                        int convertedDistance;
                        if (!Int32.TryParse(newDistance[1], out convertedDistance))
                        {
                            return "ERROR";
                        }
                        else
                        {
                            distance = convertedDistance / 10;
                            return getStatus();
                        }
                    }
                    return "";
                case "PT":
                    if (commandMode)
                    {
                        String[] newTime = command.Split(' ');
                        int convertedTime;
                        if (!Int32.TryParse(newTime[1], out convertedTime))
                        {
                            return "ERROR";
                        }
                        else
                        {
                            this.seconds = Int32.Parse(newTime[1])% 60;
                            this.minutes = Int32.Parse(newTime[1]) / 60;

                            return getStatus();
                        }
                    }
                    return "";
                default:
                    return "";
            }
        }

        private string getStatus()
        {

            string timeString;

            if (seconds < 10 && minutes < 10)
                timeString = "0" + minutes + ":0" + seconds;
            else if (seconds < 10 && minutes >= 10)
                timeString = minutes + ":0" + seconds;
            else if (seconds >= 10 && minutes < 10)
                timeString = "0" + minutes + ":" + seconds;
            else
                timeString = minutes + ":" + seconds;
           

           return pulse + "\t" + rpm + "\t" + speed + "\t" + distance + "\t" + requested_power + "\t" + energy + "\t" + timeString + "\t" + actual_power;
        }

        private void update()
        {
            while(true)
            {
                seconds += 1;
                if (seconds >= 60)
                {
                    seconds -= 60;
                    minutes++;
                }
                
                
                UpdateValues();
                Thread.Sleep(1000);
            }
        }

        private void UpdateValues()
        {
            //generate rpm
            Random r = new Random();
            int newrpm = r.Next(rpm - 10, rpm + 20);
            if (newrpm > 0)
                rpm = newrpm;
            if (rpm > 150)
                rpm -= r.Next(rpm - 145);


            //generate pulse 
            pulse = 60 + (int)(0.5 * rpm);

            //generate speed (km/uur)
            speed = (int)(rpm / 2.5);

            //generate distance (meter)
            int actualDistance = (int)(speed / 3.6);
                distance += actualDistance;

            //generate engergy (kcal)
            energy = (int)(distance * 0.75 * (requested_power + 1));

            //generate actual power
            actual_power = requested_power;
            
        }
    }
}
