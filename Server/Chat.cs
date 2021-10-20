using System.Collections.Generic;

namespace Server
{
    class Chat
    {
        private List<Message> _messages = new List<Message>();
        private List<ISenderEntity> _senderEntity = new List<ISenderEntity>();

        public delegate void NewMessageHandler(object sender, NewMessageEventArgs e);
        public event NewMessageHandler NewMessageSended;

        public List<Message> Messages
        {
            get { return _messages; }
            private set { _messages = value; }
        }

        public void AddMessage(Message message)
        {
            _messages.Add(message);
            UI.ConsoleWrite("[Чат]", message);
            NewMessageSended?.Invoke(this, new NewMessageEventArgs(message));
        }

        public void AddSenderEntity(ISenderEntity senderEntity)
        {
            _senderEntity.Add(senderEntity);
        }
    }
}
