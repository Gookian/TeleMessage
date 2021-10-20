namespace Server.ChatBot
{
    class CommandShowMessages : ICommand
    {
        public Bot _bot;

        public CommandShowMessages(Bot bot)
        {
            _bot = bot;
        }

        public void Execute()
        {
            int n = _bot.Chat.Messages.Count - 1;
            for (int i = 0;  i < n; i++)
            {
                UI.ConsoleWrite("[Бот]", _bot.Chat.Messages[i]);
            }
        }
    }
}
