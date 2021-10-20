using System;

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
            string message = PrepareMessage();

            _bot.CreateMessage(message);
            _bot.SendMessage();
        }

        private string PrepareMessage()
        {
            Random rnd = new Random();
            string message;

            switch (rnd.Next(1, 3))
            {
                case 1:
                    message = "Я работаю уже " + _bot.Timer.Time();
                    break;

                case 2:
                    message = "Я работаю уже ";
                    if (_bot.Timer.Hour == 1 || _bot.Timer.Hour == 21)
                        message += _bot.Timer.Hour + " час";
                    else if (_bot.Timer.Hour > 1 && _bot.Timer.Hour < 5 || _bot.Timer.Hour > 21 && _bot.Timer.Hour < 25)
                        message += _bot.Timer.Hour + " часа";
                    else
                        message += _bot.Timer.Hour + " часов";

                    message += " ";
                    if (_bot.Timer.Minute == 1 || _bot.Timer.Minute == 21 || _bot.Timer.Minute == 31 || _bot.Timer.Minute == 41 || _bot.Timer.Minute == 51)
                        message += _bot.Timer.Minute + " минута";
                    else if (_bot.Timer.Minute > 1 && _bot.Timer.Minute < 5 || _bot.Timer.Minute > 21 && _bot.Timer.Minute < 25 || _bot.Timer.Minute > 31 && _bot.Timer.Minute < 35 || _bot.Timer.Minute > 41 && _bot.Timer.Minute < 45 || _bot.Timer.Minute > 51 && _bot.Timer.Minute < 55)
                        message += _bot.Timer.Minute + " минуты";
                    else
                        message += _bot.Timer.Minute + " минут";

                    message += " ";
                    if (_bot.Timer.Second == 1 || _bot.Timer.Second == 21 || _bot.Timer.Second == 31 || _bot.Timer.Second == 41 || _bot.Timer.Second == 51)
                        message += _bot.Timer.Second + " секунда";
                    else if (_bot.Timer.Second > 1 && _bot.Timer.Second < 5 || _bot.Timer.Second > 21 && _bot.Timer.Second < 25 || _bot.Timer.Second > 31 && _bot.Timer.Second < 35 || _bot.Timer.Second > 41 && _bot.Timer.Second < 45 || _bot.Timer.Second > 51 && _bot.Timer.Second < 55)
                        message += _bot.Timer.Second + " секунды";
                    else
                        message += _bot.Timer.Second + " секунд";
                    break;

                default:
                    message = "";
                    break;
            }

            return message;
        }
    }
}
