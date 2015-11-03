using System;

namespace Network
{
    [Serializable]
    public class PacketMeasurement : Packet
    {
        public Measurement measurement { get; }
        public string physicianName { get; }
        public trainingen training { get; }

        public PacketMeasurement(Measurement measurement, string physicianName, trainingen training)
        {
            this.measurement = measurement;
            this.physicianName = physicianName;
            this.training = training;
        }

        public override void handleServerSide(ServerInterface serverInterface)
        {
            serverInterface.ReceiveMeasurement(measurement, physicianName, training);
        }
    }
}
