using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;
using TerminalMK.BLL.Interfaces;
using TerminalMKTerminalBot;


namespace TerminalMKTelegramBot
{
    public class MenuBuilder
    {

        public static IBotService botService;
        MenuBuilder()
        {

        }

     

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
                            "Отправить запрос на регистрацию"
                        },
                    };
                    keyboard.ResizeKeyboard = true;


                    break;

                case Utils.Rules.AuthUser:

                    keyboard = new[]
                    {
                        new[]
                        {
                            "Расчитать стоимость доставки"
                        },
                        new[]
                        {
                            "Заявка онлайн"
                        },
                        new[]
                        {
                            "Запросить обратный звонок"
                        },
                        new[]
                        {
                            "Наши контакты",
                            "Наш сайт"
                        },

                    };
                    keyboard.ResizeKeyboard = true;

                    break;

                default:
                    break;
            }

            return keyboard;
        }

        public static Telegram.Bot.Types.ReplyMarkups.ReplyKeyboardMarkup ProductionMenu(long telegramUserId)
        {
            botService = Program.kernel.Get<IBotService>();

            var productionOrder = botService.GetProductionByContractorId(telegramUserId);
            List<string> production = new List<string>();
            foreach (var item in productionOrder)
                production.Add(item.FullName);
            production.Add("Отмена");

            ReplyKeyboardMarkup productionTypeKeyboard = KeyboardHelper.GetKeyboard(production);
            productionTypeKeyboard.ResizeKeyboard = true;

            return productionTypeKeyboard;
        }

        public static Telegram.Bot.Types.ReplyMarkups.ReplyKeyboardMarkup LoadAreaMenu(long telegramUserId)
        {
            var loadCity = botService.GetLoadAreaByContractorId(telegramUserId, (int)botService.GetTelegramUserByUserTelegramId(telegramUserId).CheckProductionId);
            List<string> cityLoadList = new List<string>();
            foreach (var item in loadCity)
                cityLoadList.Add(item.Name);
            cityLoadList.Add("Отмена");

            ReplyKeyboardMarkup loadCityKeyboard = KeyboardHelper.GetKeyboard(cityLoadList);
            loadCityKeyboard.ResizeKeyboard = true;

            return loadCityKeyboard;
        }

        public static Telegram.Bot.Types.ReplyMarkups.ReplyKeyboardMarkup UnloadAreaMenu(long telegramUserId)
        {
            var unloadCity = botService.GetUnloadAreaByContractorId(telegramUserId, (int)botService.GetTelegramUserByUserTelegramId(telegramUserId).CheckProductionId);
            List<string> cityUnloadList = new List<string>();
            foreach (var item in unloadCity)
                cityUnloadList.Add(item.Name);
            cityUnloadList.Add("Отмена");

            ReplyKeyboardMarkup unloadCityKeyboard = KeyboardHelper.GetKeyboard(cityUnloadList);
            unloadCityKeyboard.ResizeKeyboard = true;

            return unloadCityKeyboard;
        }

        public static Telegram.Bot.Types.ReplyMarkups.ReplyKeyboardMarkup NumberOfCarMenu()
        {
            ReplyKeyboardMarkup numberMachineKeyboard = new[]
                                {
                                                new[] // row 1
                                                {
                                                    "1","2","3",
                                                },
                                                new[] // row 1
                                                {
                                                    "4", "5","6",
                                                },
                                                new[] // row 1
                                                {
                                                    "7", "8","9",
                                                },
                                                 new[] // row 1
                                                {
                                                    "Отмена",
                                                },
                                };

            numberMachineKeyboard.ResizeKeyboard = true;

            return numberMachineKeyboard;
        }

        public static Telegram.Bot.Types.ReplyMarkups.ReplyKeyboardMarkup OrderDateMenu()
        {
            DateTime[] masDate = new DateTime[9];

            DateTime current = DateTime.Now;

            for (int i = 0; i < 9; i++)
            {
                int j = i + 1;
                masDate[i] = current.AddDays(j);
            }

            ReplyKeyboardMarkup dateKeyboard = new[]
            {
                                                new[] // row 1
                                                {
                                                    masDate[0].ToShortDateString(),
                                                    masDate[1].ToShortDateString(),
                                                    masDate[2].ToShortDateString(),

                                                },
                                                new[] // row 1
                                                {
                                                    masDate[3].ToShortDateString(),
                                                    masDate[4].ToShortDateString(),
                                                    masDate[5].ToShortDateString()
                                                },
                                                new[] // row 1
                                                {
                                                    masDate[6].ToShortDateString(),
                                                    masDate[7].ToShortDateString(),
                                                    masDate[8].ToShortDateString(),
                                                },
                                                 new[] // row 1
                                                {
                                                    "Отмена",
                                                },
            };
            dateKeyboard.ResizeKeyboard = true;

            return dateKeyboard;
        }

        public static Telegram.Bot.Types.ReplyMarkups.ReplyKeyboardMarkup AccessOrderMenu()
        {
            ReplyKeyboardMarkup acessKeyboard = new[]
                                {
                                                new[] // row 1
                                                {
                                                    "Подтвердить заявку",
                                                },
                                                new[] // row 1
                                                {
                                                    "Отменить заявку",
                                                },
                                };
            acessKeyboard.ResizeKeyboard = true;

            return acessKeyboard;
        }


        
    }
}
