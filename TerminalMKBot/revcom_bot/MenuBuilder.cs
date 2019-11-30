using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;

namespace TerminalMKBot
{
    public class MenuBuilder
    {
        MenuBuilder()
        {

        }

        //public static Telegram.Bot.Types.ReplyMarkups.ReplyKeyboardMarkup Menu()
        //{





        //    return keyboard;
        //}

        public static Telegram.Bot.Types.ReplyMarkups.ReplyKeyboardMarkup Menu(Utils.Rules rules)
        {
            Telegram.Bot.Types.ReplyMarkups.ReplyKeyboardMarkup keyboard = new Telegram.Bot.Types.ReplyMarkups.ReplyKeyboardMarkup();

            switch (rules)
            {
                case Utils.Rules.NoAuthUser:

                    keyboard = new[]
                    {
                        new[] 
                        {
                            "Наш Сайт"
                        },
                        new[]
                        {
                            "Контакты",
                            "Оставить заявку"
                        },
                        new[]
                        {
                            "Расчитать стоимость"
                        },
                        new[]
                        { 
                            "Наша продукция"
                        },

                    };
                    keyboard.ResizeKeyboard = true;


                    break;



                case Utils.Rules.AuthUser:

                    keyboard = new[]
                    {
                        new[]
                        {
                            "Наш Сайт"
                        },
                        new[]
                        {
                            "Контакты",
                            "Оставить заявку"
                        },
                        new[]
                        {
                            "Расчитать стоимость"
                        },
                        new[]
                        {
                            "Наша продукция"
                        },

                    };
                    keyboard.ResizeKeyboard = true;


                    break;

                case Utils.Rules.Manager:
                    keyboard = new[]
                    {
                        new[]
                        {
                            "Наш Сайт"
                        },
                        new[]
                        {
                            "Контакты",
                            "Оставить заявку"
                        },
                        new[]
                        {
                            "Расчитать стоимость"
                        },
                        new[]
                        {
                            "Наша продукция"
                        },

                    };
                    keyboard.ResizeKeyboard = true;


                    break;



                default:
                    break;
            }

            return keyboard;

        }


        public static Telegram.Bot.Types.ReplyMarkups.ReplyKeyboardMarkup PostMenu()
        {
            Telegram.Bot.Types.ReplyMarkups.ReplyKeyboardMarkup keyboard = new Telegram.Bot.Types.ReplyMarkups.ReplyKeyboardMarkup();

            keyboard = new[]
                    {
                        new[]
                        {
                            "Посмотреть как выглядит пост"
                        },
                        new[]
                        {
                            "Отправить пост подписчикам",
                        },
                        new[]
                        {
                            "Отложить пост",
                            "Отменить пост",
                        },
                        new[]
                        {
                            "Управление отложенными постами",
                            "Главное меню",
                        },
                    };
            keyboard.ResizeKeyboard = true;

            return keyboard;
        }

        public static Telegram.Bot.Types.ReplyMarkups.ReplyKeyboardMarkup ControlDeferredPost()
        {
            Telegram.Bot.Types.ReplyMarkups.ReplyKeyboardMarkup keyboard = new Telegram.Bot.Types.ReplyMarkups.ReplyKeyboardMarkup();

            keyboard = new[]
                    {
                        new[]
                        {
                            "Посмотреть все отложенные посты"
                        },
                        new[]
                        {
                            "Удалить пост по его номеру",
                        },
                        new[]
                        {
                            "Удалить все посты",
                        },
                        new[]
                        {
                            "Отмена",
                        },
                    };
            keyboard.ResizeKeyboard = true;

            return keyboard;
        }
    }
}
