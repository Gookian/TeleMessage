using System;

namespace Server
{
    class User : ISenderEntity
    {
        private Chat _chat;
        private Message _messageTemp;
        private string _nickname;

        public User(string nickname, Chat chat)
        {
            _nickname = nickname;
            _chat = chat;
        }

        public string getName() => _nickname;

        public void CreateMessage(string text)
        {
            _messageTemp = new Message(this, DateTime.Now, text);
        }

        public void SendMessage()
        {
            _chat.AddMessage(_messageTemp);
        }
    }
}
