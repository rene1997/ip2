namespace Network
{
    public interface ServerInterface
    {
        void Login(string username, string password);
        void GiveUser(string username, bool allUsers, string physicianName);
        void AddUser(User user, string physicianName);
        void BikeValues(string power, string time, string distance, string username);
        void ChatMessage(string sender, string receiver, string message);
        void Broadcast(string sender, string message);
        void ReceiveMeasurement(Measurement measurement, string physcianName, string sessionType);
        void SaveData();
    }
}
