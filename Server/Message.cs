using System;

namespace Server
{
    class Message
    {
        private ISenderEntity _author;
        private DateTime _dateTime;
        private string _text;

        public ISenderEntity Author 
        {
            get { return _author; }
            private set { _author = value; }
        }

        public DateTime DateTime
        {
            get { return _dateTime; }
            private set { _dateTime = value; }
        }

        public string Text
        {
            get { return _text; }
            private set { _text = value; }
        }

        public Message(ISenderEntity author, DateTime dateTime, string text)
        {
            _author = author;
            _dateTime = dateTime;
            _text = text;
        }
    }
}
