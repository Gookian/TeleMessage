namespace Server.ChatBot
{
    class MessageInterpreter
    {
        private Bot _bot;

        public MessageInterpreter(Bot bot)
        {
            _bot = bot;
        }

        public ICommand StringParser(string text)
        {
            ICommand _command;

            switch (text.ToLower())
            {
                case "сколько сейчас времени?":
                    _command = new CommandTimeNow(_bot);
                    break;

                case "как тебя зовут?":
                    _command = new CommandName(_bot);
                    break;

                case "как дела?":
                    _command = new CommandNowAreYou(_bot);
                    break;

                case "сколько времени ты работаешь?":
                    _command = new CommandTimeWork(_bot);
                    break;

                case "покажи нашу переписку":
                    _command = new CommandShowMessages(_bot);
                    break;

                case "очисти экран":
                    _command = new CommandClear();
                    break;

                case "помощь":
                    _command = new CommandHelp(_bot);
                    break;

                default:
                    _command = new CommandNull();
                    break;
            }

            return _command;
        }
    }
}
