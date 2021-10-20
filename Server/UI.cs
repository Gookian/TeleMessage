using System;

namespace Server
{
    class UI
    {
        public static void ConsoleWrite(string title, Message message)
        {
            Console.Write(title + " ");
            Console.Write(message.DateTime + " ");
            Console.Write(message.Author.getName() + ": ");
            Console.WriteLine(message.Text);
        }
    }
}
