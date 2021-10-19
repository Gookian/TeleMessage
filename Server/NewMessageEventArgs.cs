namespace Server
{
    class NewMessageEventArgs
    {
        public Message _message { get; private set; }

        public NewMessageEventArgs(Message message)
        {
            _message = message;
        }
    }
}
