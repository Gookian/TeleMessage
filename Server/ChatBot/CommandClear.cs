using System;

namespace Server.ChatBot
{
    class CommandClear : ICommand
    {
        public void Execute()
        {
            Console.Clear();
        }
    }
}
