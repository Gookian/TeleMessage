using System;
using Server.ChatBot;

namespace Server
{
    class Program
    {
        public static string strLine = "";

        static void Main(string[] args)
        {
            Chat chat = new Chat();

            User user = new User("Gookian", chat);
            chat.AddSenderEntity(user);

            Bot bot = new Bot("Bot Vit", chat);
            chat.AddSenderEntity(bot);

            do
            {
                Console.Write("Введите сообщение: ");
                strLine = Console.ReadLine();
                user.CreateMessage(strLine);
                user.SendMessage();
            } while (strLine != "exit");
        }
    }
}
