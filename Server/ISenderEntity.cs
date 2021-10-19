namespace Server
{
    interface ISenderEntity
    {
        public string getName();
        public void CreateMessage(string text);
        public void SendMessage();
    }
}
