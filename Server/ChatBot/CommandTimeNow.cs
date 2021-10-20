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
                    message = "Сейчса на часах " + DateTime.Now.ToString("HH:mm:ss");
                    break;

                case 2:
                    message = "Сейчса на часах ";
                    if (DateTime.Now.Hour == 1 || DateTime.Now.Hour == 21)
                        message += DateTime.Now.Hour + " час";
                    else if (DateTime.Now.Hour > 1 && DateTime.Now.Hour < 5 || DateTime.Now.Hour > 21 && DateTime.Now.Hour < 25)
                        message += DateTime.Now.Hour + " часа";
                    else
                        message += DateTime.Now.Hour + " часов";

                    message += " ";
                    if (DateTime.Now.Minute == 1 || DateTime.Now.Minute == 21 || DateTime.Now.Minute == 31 || DateTime.Now.Minute == 41 || DateTime.Now.Minute == 51)
                        message += DateTime.Now.Minute + " минута";
                    else if (DateTime.Now.Minute > 1 && DateTime.Now.Minute < 5 || DateTime.Now.Minute > 21 && DateTime.Now.Minute < 25 || DateTime.Now.Minute > 31 && DateTime.Now.Minute < 35 || DateTime.Now.Minute > 41 && DateTime.Now.Minute < 45 || DateTime.Now.Minute > 51 && DateTime.Now.Minute < 55)
                        message += DateTime.Now.Minute + " минуты";
                    else
                        message += DateTime.Now.Minute + " минут";
                    message += " ";

                    if (DateTime.Now.Second == 1 || DateTime.Now.Second == 21 || DateTime.Now.Second == 31 || DateTime.Now.Second == 41 || DateTime.Now.Second == 51)
                        message += DateTime.Now.Second + " секунда";
                    else if (DateTime.Now.Second > 1 && DateTime.Now.Second < 5 || DateTime.Now.Second > 21 && DateTime.Now.Second < 25 || DateTime.Now.Second > 31 && DateTime.Now.Second < 35 || DateTime.Now.Second > 41 && DateTime.Now.Second < 45 || DateTime.Now.Second > 51 && DateTime.Now.Second < 55)
                        message += DateTime.Now.Second + " секунды";
                    else
                        message += DateTime.Now.Second + " секунд";
                    break;

                default:
                    message = "";
                    break;
            }

            return message;
        }
    }
}
