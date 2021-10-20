using System;

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
            string message = PrepareMessage();

            _bot.CreateMessage(message);
            _bot.SendMessage();
        }

        private string PrepareMessage()
        {
            Random rnd = new Random();
            string message;

            switch (rnd.Next(1, 4))
            {
                case 1:
                    message = "Меня зовут " + _bot.Nickname;
                    break;

                case 2:
                    message = "Мое имя " + _bot.Nickname;
                    break;

                case 3:
                    message = "Меня зовут " + _bot.Nickname + ", я бэтмен";
                    break;

                default:
                    message = "";
                    break;
            }

            return message;
        }
    }
}
