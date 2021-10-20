using System;

namespace Server.ChatBot
{
    class CommandHelp : ICommand
    {
        public Bot _bot;

        public CommandHelp(Bot bot)
        {
            _bot = bot;
        }

        public void Execute()
        {
            string message = "[Помощь]\n";
            message += "\t[Команда] {сколько сейчас времени?} - Бот выводит текущее время.\n";
            message += "\t[Команда] {как тебя зовут?} - Бот выводит свое имя.\n";
            message += "\t[Команда] {как дела?} - Бот отвечает на вопрос \"как дела?\".\n";
            message += "\t[Команда] {сколько времени ты работаешь?} - Бот выводит время его работы.\n";
            message += "\t[Команда] {покажи нашу переписку} - Бот показывает всю переписку.\n";
            message += "\t[Команда] {очисти экран} - Бот отчищает экран.\n";
            message += "\t[Команда] {помощь} - Бот выводть справочную информацию о его функционале.";

            _bot.CreateMessage(message);
            _bot.SendMessage();
        }
    }
}
