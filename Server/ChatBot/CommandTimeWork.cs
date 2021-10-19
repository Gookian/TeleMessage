namespace Server.ChatBot
{
    class CommandTimeWork : ICommand
    {
        public Bot _bot;

        public CommandTimeWork(Bot bot)
        {
            _bot = bot;
        }

        public void Execute()
        {
            _bot.CreateMessage("Я работаю уже " + _bot.Timer.Time());
            _bot.SendMessage();
        }
    }
}
