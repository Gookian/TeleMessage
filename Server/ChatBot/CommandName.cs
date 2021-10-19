namespace Server.ChatBot
{
    class CommandName : ICommand
    {
        public Bot _bot;

        public CommandName(Bot bot)
        {
            _bot = bot;
        }

        public void Execute()
        {
            _bot.CreateMessage("Меня зовут " + _bot.Nickname);
            _bot.SendMessage();
        }
    }
}
