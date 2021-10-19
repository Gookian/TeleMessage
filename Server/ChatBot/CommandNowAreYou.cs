namespace Server.ChatBot
{
    class CommandNowAreYou : ICommand
    {
        public Bot _bot;

        public CommandNowAreYou(Bot bot)
        {
            _bot = bot;
        }

        public void Execute()
        {
            _bot.CreateMessage("Мои дела хорошо, а твои как?");
            _bot.SendMessage();
        }
    }
}
