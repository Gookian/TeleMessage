using System;

namespace Server
{
    class UI
    {
        public static void ConsoleWrite(Message message)
        {
            Console.Write("[Чат] ");
            Console.Write(message.DateTime + " ");
            Console.Write(message.Author.getName() + ": ");
            Console.WriteLine(message.Text);
        }
    }
}
