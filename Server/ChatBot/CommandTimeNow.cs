using System;

namespace Server.ChatBot
{
    class CommandTimeNow : ICommand
    {
        public Bot _bot;

        public CommandTimeNow(Bot bot)
        {
            _bot = bot;
        }

        public void Execute()
        {
            _bot.CreateMessage("Сейчса на часах " + DateTime.Now.ToString("HH:mm:ss"));
            _bot.SendMessage();
        }
    }
}
