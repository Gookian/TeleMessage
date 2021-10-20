using System;

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
            string message = PrepareMessage();

            _bot.CreateMessage(message);
            _bot.SendMessage();
        }

        private string PrepareMessage()
        {
            Random rnd = new Random();
            string message;

            switch (rnd.Next(1, 11))
            {
                case 1:
                    message = "Лучше всех!";
                    break;

                case 2:
                    message = "Лучше всех!";
                    break;

                case 3:
                    message = "Как всегда, то есть хорошо";
                    break;

                case 4:
                    message = "Дела мои отлично!";
                    break;

                case 5:
                    message = "Все хорошо, а будет еще лучше!";
                    break;

                case 6:
                    message = "Хорошо! А у тебя?";
                    break;

                case 7:
                    message = "Нормально";
                    break;

                case 8:
                    message = "Всё ок!";
                    break;

                case 9:
                    message = "Мои дела хорошо, а твои как?";
                    break;

                case 10:
                    message = "Нет никаких дел";
                    break;

                default:
                    message = "";
                    break;
            }

            return message;
        }
    }
}
