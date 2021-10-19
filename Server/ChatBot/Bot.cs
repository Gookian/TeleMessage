using System;

namespace Server.ChatBot
{
    class Bot : ISenderEntity
    {
        private static Invoker _invoker = new Invoker();
        private static MessageInterpreter _interpreter;
        private Chat _chat;
        private Message _messageTemp;
        private Timer _timer;
        private string _nickname;

        public string Nickname
        {
            get { return _nickname; }
            private set { _nickname = value; }
        }

        public Chat Chat
        {
            get { return _chat; }
            private set { _chat = value; }
        }

        public Timer Timer
        {
            get { return _timer; }
            private set { _timer = value; }
        }

        public Bot(string nickname, Chat chat)
        {
            _interpreter = new MessageInterpreter(this);
            _timer = new Timer();
            _timer.Start();
            _nickname = nickname;
            _chat = chat;
            _chat.NewMessageSended += NewMessage;
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

        public static void NewMessage(object sender, NewMessageEventArgs e)
        {
            ICommand command = _interpreter.StringParser(e._message.Text);
            _invoker.SetCommand(command);
            _invoker.ExecuteCommand();
        }
    }
}
