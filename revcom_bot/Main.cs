using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using System.IO;

using System.Drawing.Imaging;

using System.Globalization;
using System.Timers;
using Telegram.Bot.Types.ReplyMarkups;
using System.Net;
using System.Text.RegularExpressions;
using TerminalMKTerminalBot;

using TerminalMK.BLL.ModelsDTO;
using TerminalMK.BLL.Interfaces;

namespace TerminalMKTelegramBot
{

    public partial class Main : Form
    {
        BackgroundWorker bw = new BackgroundWorker();
        //BackgroundWorker bws;
        public static IBotService botService;
        public static IControlPanelService controlPanelService;
        public static Telegram.Bot.TelegramBotClient botTelegram;



        List<UsersTelegramDTO> allUsers = new List<UsersTelegramDTO>();
        List<TelegramBotDTO> allBots = new List<TelegramBotDTO>();
        //List<PostTelegramDTO> allAutopostPost = new List<PostTelegramDTO>();

        string botToken = "810022910:AAGXsYcVViTbBH-sq1VpKX5Hd0oD7ZDWKKs";


        public Main()
        {
            InitializeComponent();
            bw = new BackgroundWorker();
            bw.DoWork += bw_DoWork;
        }





        public async Task SendContactManagers(string message, Telegram.Bot.Types.Message contact)
        {

            botService = Program.kernel.Get<IBotService>();

            var managerUser = botService.GetTelegramBotUsers(1).Where(mn => mn.Rules == 3);

            foreach (var item in managerUser)
            {
                await botTelegram.SendTextMessageAsync(item.UserTelegramId, message, parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown, disableWebPagePreview: true, disableNotification: false);
                await botTelegram.SendContactAsync(item.UserTelegramId, contact.Contact.PhoneNumber, contact.Contact.FirstName, contact.Contact.LastName, disableNotification: false);
            }

        }

        public async Task SendLocationManagers(string messageType, Telegram.Bot.Types.Message message)
        {

            botService = Program.kernel.Get<IBotService>();

            var managerUser = botService.GetTelegramBotUsers(1).Where(mn => mn.Rules == 3);

            foreach (var item in managerUser)
            {
                await botTelegram.SendTextMessageAsync(item.UserTelegramId, messageType, parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown, disableWebPagePreview: true, disableNotification: false);
                await botTelegram.SendLocationAsync(item.UserTelegramId, message.Location.Latitude, message.Location.Longitude, disableNotification: false);
            }

        }










        async void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            var key = e.Argument as String; // получаем ключ из аргументов
            try
            {
                botTelegram = new Telegram.Bot.TelegramBotClient(botToken); // инициализируем API
                await botTelegram.SetWebhookAsync(""); // Обязательно! убираем старую привязку к вебхуку для бота



                botService = Program.kernel.Get<IBotService>();

                allBots = botService.GetTelegramBots().ToList();
                allUsers = botService.GetTelegramBotUsers(1).ToList();

                List<string> allComands = new List<string>() { "\U0001F4BB Сайт" , "\U0001F60E Комерческие предложения" ,
                 "\U0001F4A5 Акции","\U0001F4AA Наши работы", "\U0001F4F2 Контакты", "\U0001F4BB Заказать настройку бота",
                 "\U0001F632 Жалобы","\U0001F4DD Связаться с менеджером","\U0001F4B2 Оплата","Подписаться","Отписаться",
                 "Отправить сообщение", "\U0001F3A5 Видео","\U0001F464 Соц. сети", "Главное меню","Отмена","Instagram","Facebook",
                     "Отложить пост", "Посмотреть как выглядит пост","Отменить пост","/start", "Отправить пост подписчикам", "Оплата", "Изменить комерческое","Изменить акции",
                     "Изменить комерческое", "\U0001F527 Техподдержка","Управление отложенными постами","Посмотреть все отложенные посты","Удалить пост по его номеру","Удалить все посты",
                     "Facebook","Instagram"
                 };


                botTelegram.OnUpdate += async (object su, Telegram.Bot.Args.UpdateEventArgs evu) =>
                {
                    if (evu.Update.CallbackQuery != null || evu.Update.InlineQuery != null) return;
                    var update = evu.Update;
                    var message = update.Message;
                    if (message == null) return;

                    botService = Program.kernel.Get<IBotService>();


                    // добавление нового пользователя
                    //if (allUsers.Where(x => x.UserTelegramId == message.Chat.Id).Count() == 0)
                    //{
                    //    UsersTelegramDTO newUser = new UsersTelegramDTO { CurrentLevelMenu = 0, UserTelegramId = message.Chat.Id, Name = message.Chat.FirstName + " " + message.Chat.LastName, Rules = 0, UserName = message.Chat.Username, BotId = 1 };
                    //    botService.TelegramUsersCreate(newUser);
                    //}



                    allBots = botService.GetTelegramBots().ToList();
                    allUsers = botService.GetTelegramBotUsers(1).ToList();

                    #region Обработчик видеофайлов

                    if (message.Type == Telegram.Bot.Types.Enums.MessageType.Video)
                    {
                        await botTelegram.SendTextMessageAsync(message.Chat.Id, "В текущий момент я не поддерживаю обработку видеофайлов, но я работаю над собой.");

                    }

                    #endregion

                    #region Обработчик аудиофайлов

                    if (message.Type == Telegram.Bot.Types.Enums.MessageType.Audio)
                    {
                        await botTelegram.SendTextMessageAsync(message.Chat.Id, "В текущий момент я не поддерживаю обработку аудиофайлов, но я работаю над собой.");

                    }

                    #endregion

                    #region Обработчик стикеров

                    if (message.Type == Telegram.Bot.Types.Enums.MessageType.Sticker)
                    {
                        await botTelegram.SendTextMessageAsync(message.Chat.Id, "В текущий момент я не поддерживаю обработку стикеров, но я работаю над собой.");

                    }

                    #endregion

                    #region Обработчик геоданных

                    if (message.Type == Telegram.Bot.Types.Enums.MessageType.Location)
                    {

                        await botTelegram.SendTextMessageAsync(message.Chat.Id, "В текущий момент я не поддерживаю обработку геоданных, но я работаю над собой.");

                    }

                    #endregion

                    #region Обработчик контактов

                    if (message.Type == Telegram.Bot.Types.Enums.MessageType.Contact)
                    {
                        if (message.Contact != null && allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.CurrentLevelMenu == 20))
                        {

                            if (allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.Rules > 1))
                            {
                                botService = Program.kernel.Get<IBotService>();
                                botService.TelegramUsersUpdateRulesByTelegramUserId(message.Chat.Id, 0);

                                var keyboard1 = MenuBuilder.Menu(Utils.Rules.Manager);

                                await SendContactManagers("Свяжитесь со мной: ", message);

                                //await botTelegram.SendTextMessageAsync(799808566, "Свяжитесь со мной: ");
                                //await botTelegram.SendContactAsync(799808566, message.Contact.PhoneNumber, message.Contact.FirstName, message.Contact.LastName);
                                await botTelegram.SendTextMessageAsync(message.Chat.Id, "Ваша заявка отправлена менеджеру и в ближайшее время будет обработана", replyMarkup: keyboard1);
                            }
                            else if (allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.Rules == 1))
                            {
                                botService = Program.kernel.Get<IBotService>();
                                botService.TelegramUsersUpdateRulesByTelegramUserId(message.Chat.Id, 0);

                                var keyboard2 = MenuBuilder.Menu(Utils.Rules.NoAuthUser);

                                await SendContactManagers("Свяжитесь со мной: ", message);

                                //await botTelegram.SendTextMessageAsync(799808566, "Свяжитесь со мной: ");
                                //await botTelegram.SendContactAsync(799808566, message.Contact.PhoneNumber, message.Contact.FirstName, message.Contact.LastName);
                                await botTelegram.SendTextMessageAsync(message.Chat.Id, "Ваша заявка отправлена менеджеру и в ближайшее время будет обработана", replyMarkup: keyboard2);
                            }
                            else
                            {
                                botService = Program.kernel.Get<IBotService>();
                                botService.TelegramUsersUpdateRulesByTelegramUserId(message.Chat.Id, 0);

                                var keyboard3 = MenuBuilder.Menu(Utils.Rules.NoAuthUser);

                                await SendContactManagers("Свяжитесь со мной: ", message);

                                //await botTelegram.SendTextMessageAsync(799808566, "Свяжитесь со мной: ");
                                //await botTelegram.SendContactAsync(799808566, message.Contact.PhoneNumber, message.Contact.FirstName, message.Contact.LastName);
                                await botTelegram.SendTextMessageAsync(message.Chat.Id, "Ваша заявка отправлена менеджеру и в ближайшее время будет обработана", replyMarkup: keyboard3);
                            }
                        }
                        else if (message.Contact != null && allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.CurrentLevelMenu == 20))
                        {

                            if (allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.Rules > 1))
                            {
                                botService = Program.kernel.Get<IBotService>();
                                botService.TelegramUsersUpdateRulesByTelegramUserId(message.Chat.Id, 0);

                                var keyboard1 = MenuBuilder.Menu(Utils.Rules.Manager);

                                await SendContactManagers("Хочу заказать разработку телеграм бота, свяжитесь со мной: ", message);

                                //await botTelegram.SendTextMessageAsync(799808566, "Хочу заказать разработку телеграм бота, свяжитесь со мной: ");
                                //await botTelegram.SendContactAsync(799808566, message.Contact.PhoneNumber, message.Contact.FirstName, message.Contact.LastName);
                                await botTelegram.SendTextMessageAsync(message.Chat.Id, "Ваша заявка отправлена менеджеру и в ближайшее время будет обработана", replyMarkup: keyboard1);
                            }
                            else if (allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.Rules == 1))
                            {
                                botService = Program.kernel.Get<IBotService>();
                                botService.TelegramUsersUpdateRulesByTelegramUserId(message.Chat.Id, 0);

                                var keyboard2 = MenuBuilder.Menu(Utils.Rules.NoAuthUser);

                                await SendContactManagers("Хочу заказать разработку телеграм бота, свяжитесь со мной: ", message);

                                //await botTelegram.SendTextMessageAsync(799808566, "Хочу заказать разработку телеграм бота, свяжитесь со мной: ");
                                //await botTelegram.SendContactAsync(799808566, message.Contact.PhoneNumber, message.Contact.FirstName, message.Contact.LastName);
                                await botTelegram.SendTextMessageAsync(message.Chat.Id, "Ваша заявка отправлена менеджеру и в ближайшее время будет обработана", replyMarkup: keyboard2);
                            }
                            else
                            {
                                botService = Program.kernel.Get<IBotService>();
                                botService.TelegramUsersUpdateRulesByTelegramUserId(message.Chat.Id, 0);

                                var keyboard3 = MenuBuilder.Menu(Utils.Rules.NoAuthUser);

                                //await SendContactManagers("Хочу заказать разработку телеграм бота, свяжитесь со мной: ", message);

                                //await botTelegram.SendTextMessageAsync(799808566, "Хочу заказать разработку телеграм бота, свяжитесь со мной: ");
                                //await botTelegram.SendContactAsync(799808566, message.Contact.PhoneNumber, message.Contact.FirstName, message.Contact.LastName);
                                await botTelegram.SendTextMessageAsync(message.Chat.Id, "Ваша заявка отправлена менеджеру и в ближайшее время будет обработана", replyMarkup: keyboard3);
                            }
                        }
                        else if (message.Contact != null && allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.CurrentLevelMenu == 55))
                        {

                            if (allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.Rules > 1))
                            {
                                botService = Program.kernel.Get<IBotService>();
                                botService.TelegramUsersUpdateRulesByTelegramUserId(message.Chat.Id, 0);

                                var keyboard1 = MenuBuilder.Menu(Utils.Rules.Manager);

                                await SendContactManagers("Хочу заказать продвижение: ", message);

                                //await botTelegram.SendTextMessageAsync(799808566, "Хочу заказать разработку телеграм бота, свяжитесь со мной: ");
                                //await botTelegram.SendContactAsync(799808566, message.Contact.PhoneNumber, message.Contact.FirstName, message.Contact.LastName);
                                await botTelegram.SendTextMessageAsync(message.Chat.Id, "Ваша заявка отправлена менеджеру и в ближайшее время будет обработана", replyMarkup: keyboard1);
                            }
                            else if (allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.Rules == 1))
                            {
                                botService = Program.kernel.Get<IBotService>();
                                botService.TelegramUsersUpdateRulesByTelegramUserId(message.Chat.Id, 0);

                                var keyboard2 = MenuBuilder.Menu(Utils.Rules.NoAuthUser);

                                await SendContactManagers("Хочу заказать продвижение: ", message);

                                //await botTelegram.SendTextMessageAsync(799808566, "Хочу заказать разработку телеграм бота, свяжитесь со мной: ");
                                //await botTelegram.SendContactAsync(799808566, message.Contact.PhoneNumber, message.Contact.FirstName, message.Contact.LastName);
                                await botTelegram.SendTextMessageAsync(message.Chat.Id, "Ваша заявка отправлена менеджеру и в ближайшее время будет обработана", replyMarkup: keyboard2);
                            }
                            else
                            {
                                botService = Program.kernel.Get<IBotService>();
                                botService.TelegramUsersUpdateRulesByTelegramUserId(message.Chat.Id, 0);

                                var keyboard3 = MenuBuilder.Menu(Utils.Rules.NoAuthUser);

                                await SendContactManagers("Хочу заказать продвижение: ", message);

                                //await botTelegram.SendTextMessageAsync(799808566, "Хочу заказать разработку телеграм бота, свяжитесь со мной: ");
                                //await botTelegram.SendContactAsync(799808566, message.Contact.PhoneNumber, message.Contact.FirstName, message.Contact.LastName);
                                await botTelegram.SendTextMessageAsync(message.Chat.Id, "Ваша заявка отправлена менеджеру и в ближайшее время будет обработана", replyMarkup: keyboard3);
                            }
                        }
                        else
                        {
                            await botTelegram.SendTextMessageAsync(message.Chat.Id, "Отправка контактных даных возможна в режимах: 'Заказать настройку бота', 'Заказать рекламу', 'Связаться с менеджером'");
                        }

                    }


                    #endregion

                    #region Обработчик документов

                    if (message.Type == Telegram.Bot.Types.Enums.MessageType.Document && allUsers.Any(x => x.UserTelegramId == message.Chat.Id))
                    {
                        await botTelegram.SendTextMessageAsync(message.Chat.Id, "В текущий момент я не поддерживаю обработку документов, но я работаю над собой.");

                    }

                    #endregion

                    #region Обработчик картинок


                    if (message.Type == Telegram.Bot.Types.Enums.MessageType.Photo)
                    {

                        await botTelegram.SendTextMessageAsync(message.Chat.Id, "В текущий момент я не поддерживаю обработку фотографий, но я работаю над собой.");

                    }

                    #endregion

                    #region Обработчик сообщений

                    if (message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
                    {
                        if (message.Text != "" && !allComands.Contains(message.Text) && allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.CurrentLevelMenu == 10))
                        {
                            if (!message.Text.HasEmojis())
                            {

                            }
                            else
                                await botTelegram.SendTextMessageAsync(message.Chat.Id, "Сообщение содержит эмодзи, создайте сообщение без них!");


                        }
                        else if (message.Text != "" && allUsers.All(x => x.UserTelegramId != message.Chat.Id))
                        {
                            botService = Program.kernel.Get<IBotService>();
                            controlPanelService = Program.kernel.Get<IControlPanelService>();

                            var keyboard1 = MenuBuilder.Menu(Utils.Rules.NoAuthUser);

                            if (!controlPanelService.ContainMessages(message.Chat.Id))
                            {
                                MessagesDTO messageDTO = new MessagesDTO()
                                {
                                    Read = false,
                                    UserTelegramId = message.Chat.Id,
                                    Text = "Загистрируйте меня в системе " + message.Chat.FirstName + " " + message.Chat.LastName
                                };

                                controlPanelService.MessagesCreate(messageDTO);
                                await botTelegram.SendTextMessageAsync(message.Chat.Id, "Вы не зарегистрирвоаны в системе, ваша заявка отправлена и в ближайшее время будет обработана нашим оператором.", replyMarkup: MenuBuilder.Menu(Utils.Rules.NoAuthUser));
                            }
                            else
                            {
                                await botTelegram.SendTextMessageAsync(message.Chat.Id, "Ваша заявка обрабатывается нашим оператором, благодарим за понимание", replyMarkup: MenuBuilder.Menu(Utils.Rules.NoAuthUser));
                            }

                        }
                        else if (message.Text != "" && !allComands.Contains(message.Text) && allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.CurrentLevelMenu == 41))
                        {
                            if (allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.Rules == 1))
                            {
                                botService = Program.kernel.Get<IBotService>();

                                int? productId = botService.GetProductionId(message.Text);

                                if (productId != null)
                                {
                                    botService.TelegramUsersUpdateCheckProductionIdByTelegramUserId(message.Chat.Id, (int)productId);
                                    message.Text = "Пункт загрузки (расчет)";
                                }

                            }
                        }
                        else if (message.Text != "" && !allComands.Contains(message.Text) && allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.CurrentLevelMenu == 42))
                        {
                            if (allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.Rules == 1))
                            {
                                botService = Program.kernel.Get<IBotService>();

                                int? cityId = botService.GetCityId(message.Text);

                                if (cityId != null)
                                {
                                    botService.TelegramUsersUpdateCheckLoadAreaIdByTelegramUserId(message.Chat.Id, (int)cityId);
                                    message.Text = "Пункт доставки (расчет)";
                                }

                            }
                        }
                        else if (message.Text != "" && !allComands.Contains(message.Text) && allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.CurrentLevelMenu == 43))
                        {
                            if (allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.Rules == 1))
                            {
                                botService = Program.kernel.Get<IBotService>();

                                int? cityId = botService.GetCityId(message.Text);

                                if (cityId != null)
                                {
                                    botService.TelegramUsersUpdateCheckUnloadAreaIdByTelegramUserId(message.Chat.Id, (int)cityId);
                                    message.Text = "Количество машин (расчет)";
                                }

                            }
                        }

                        else if (message.Text != "" && !allComands.Contains(message.Text) && allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.CurrentLevelMenu == 44))
                        {
                            if (allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.Rules == 1))
                            {
                                botService = Program.kernel.Get<IBotService>();

                                short numberOfMachine = 0;

                                if (Int16.TryParse(message.Text, out numberOfMachine))
                                {
                                    botService.TelegramUsersUpdateCheckNumberOfMachineByTelegramUserId(message.Chat.Id, (short)numberOfMachine);
                                    message.Text = "Стоимость доставки";
                                }



                            }
                        }

                        else if (message.Text != "" && !allComands.Contains(message.Text) && allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.CurrentLevelMenu == 51))
                        {
                            if (allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.Rules == 1))
                            {
                                botService = Program.kernel.Get<IBotService>();

                                int? productId = botService.GetProductionId(message.Text);

                                if (productId != null)
                                {
                                    botService.TelegramUsersUpdateCheckProductionIdByTelegramUserId(message.Chat.Id, (int)productId);
                                    message.Text = "Пункт загрузки (заявка)";
                                }

                            }
                        }

                        else if (message.Text != "" && !allComands.Contains(message.Text) && allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.CurrentLevelMenu == 52))
                        {
                            if (allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.Rules == 1))
                            {
                                botService = Program.kernel.Get<IBotService>();

                                int? cityId = botService.GetCityId(message.Text);

                                if (cityId != null)
                                {
                                    botService.TelegramUsersUpdateCheckLoadAreaIdByTelegramUserId(message.Chat.Id, (int)cityId);
                                    message.Text = "Пункт доставки (заявка)";
                                }

                            }
                        }

                        else if (message.Text != "" && !allComands.Contains(message.Text) && allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.CurrentLevelMenu == 53))
                        {
                            if (allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.Rules == 1))
                            {
                                botService = Program.kernel.Get<IBotService>();

                                int? cityId = botService.GetCityId(message.Text);

                                if (cityId != null)
                                {
                                    botService.TelegramUsersUpdateCheckUnloadAreaIdByTelegramUserId(message.Chat.Id, (int)cityId);
                                    message.Text = "Количество машин (заявка)";
                                }

                            }
                        }
                        else if (message.Text != "" && !allComands.Contains(message.Text) && allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.CurrentLevelMenu == 54))
                        {
                            if (allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.Rules == 1))
                            {
                                botService = Program.kernel.Get<IBotService>();

                                short numberOfMachine = 0;

                                if (Int16.TryParse(message.Text, out numberOfMachine))
                                {
                                    botService.TelegramUsersUpdateCheckNumberOfMachineByTelegramUserId(message.Chat.Id, (short)numberOfMachine);
                                    message.Text = "Дата доставки";
                                }

                            }
                        }

                        else if (message.Text != "" && !allComands.Contains(message.Text) && allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.CurrentLevelMenu == 55))
                        {
                            if (allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.Rules == 1))
                            {
                                botService = Program.kernel.Get<IBotService>();

                                DateTime enteredDate = DateTime.Parse(message.Text);

                                botService.TelegramUsersUpdateCheckOrderDateByTelegramUserId(message.Chat.Id, enteredDate);

                                message.Text = "Потверждение заявки";

                            }
                        }
                        else if (message.Text != "" && !allComands.Contains(message.Text) && allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.CurrentLevelMenu == 56))
                        {
                            if (allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.Rules == 1))
                            {
                                botService = Program.kernel.Get<IBotService>();
                                controlPanelService = Program.kernel.Get<IControlPanelService>();

                                if (message.Text == "Подтвердить заявку")
                                {

                                    await botTelegram.SendTextMessageAsync(message.Chat.Id, "Ваша заявка отправлена менеджеру");

                                    UsersTelegramDTO userOrderTelegramDTO = botService.GetTelegramUserByUserTelegramId(message.Chat.Id);
                                    //RoutesDTO routesDTO = botService.GetRouteByProductionLoadAreaUnloadArea((int)userTelegramDTO.CheckProductionId, (int)userTelegramDTO.CheckLoadAreaId, (int)userTelegramDTO.CheckUnloadAreaId);

                                    string productOrder = "\nВид продукции: " + botService.GetProductionByid((int)userOrderTelegramDTO.CheckProductionId).FullName;
                                    string routeOrder = "\nМаршрут: " + botService.GetCityByid((int)userOrderTelegramDTO.CheckLoadAreaId).Name + " - " + botService.GetCityByid((int)userOrderTelegramDTO.CheckUnloadAreaId).Name;
                                    //string distance = "\nРасстояние: " + routesDTO.Distance + " км";
                                    string machineNumberOrder = "\nКоличество машин: " + userOrderTelegramDTO.CheckNumberOfMachine;
                                    string orderDateOrder = "\nДата доставки: " + userOrderTelegramDTO.OrderDate.Value.ToShortDateString() + "\n\n";

                                    //await botTelegram.SendTextMessageAsync(message.Chat.Id, "Ваша заявка отправлена нашему менеджеру",
                                    //     replyMarkup: MenuBuilder.AccessOrderMenu(), parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown, disableWebPagePreview: true, disableNotification: false);

                                    MessagesDTO messageDTO = new MessagesDTO()
                                    {
                                        Read = false,
                                        UserTelegramId = message.Chat.Id,
                                        Text = "Хочу заказать битум. " + productOrder + routeOrder + machineNumberOrder + orderDateOrder
                                    };

                                    controlPanelService.MessagesCreate(messageDTO);

                                }
                                else
                                {
                                    await botTelegram.SendTextMessageAsync(message.Chat.Id, "Ваша заявка отменена");
                                }

                                message.Text = "Отмена";
                                //DateTime enteredDate = DateTime.Parse(message.Text);

                                //botService.TelegramUsersUpdateCheckOrderDateByTelegramUserId(message.Chat.Id, enteredDate);

                                //message.Text = "Потверждение заявки";

                            }
                        }
                        else
                        {
                            
                        }

                        switch (message.Text)
                        {
                            #region "/start"
                            case "/start":
                                if (allUsers.All(x => x.UserTelegramId != message.Chat.Id))
                                {
                                    botService = Program.kernel.Get<IBotService>();
                                    controlPanelService = Program.kernel.Get<IControlPanelService>();
                                    //botService.TelegramUsersUpdateRulesByTelegramUserId(message.Chat.Id, 20);



                                    var keyboard1 = MenuBuilder.Menu(Utils.Rules.NoAuthUser);

                                    if (!controlPanelService.ContainMessages(message.Chat.Id))
                                    {
                                        MessagesDTO messageDTO = new MessagesDTO()
                                        {
                                            Read = false,
                                            UserTelegramId = message.Chat.Id,
                                            Text = "Зарегистрируйте меня в системе " + message.Chat.FirstName + " " + message.Chat.LastName
                                        };
                                        Telegram.Bot.Types.ReplyMarkups.ReplyKeyboardMarkup keyboard121 = new Telegram.Bot.Types.ReplyMarkups.ReplyKeyboardMarkup();
                                         keyboard121 = new[]
                                        {
                                            new[]
                                            {
                                                "Отправить запрос на регистрацию"
                                            }
                                        };

                                        keyboard121.ResizeKeyboard = true;

                                        controlPanelService.MessagesCreate(messageDTO);

                                        await botTelegram.SendTextMessageAsync(message.Chat.Id, "Вы не зарегистрирвоаны в системе, ваша заявка отправлена и в ближайшее время будет обработана нашим оператором.", replyMarkup: keyboard121);
                                    }
                                    else
                                    {
                                        Telegram.Bot.Types.ReplyMarkups.ReplyKeyboardMarkup keyboard122 = new Telegram.Bot.Types.ReplyMarkups.ReplyKeyboardMarkup();
                                        keyboard122 = new[]
                                       {
                                            new[]
                                            {
                                                "Отправить запрос на регистрацию"
                                            }
                                        };

                                        keyboard122.ResizeKeyboard = true;

                                        await botTelegram.SendTextMessageAsync(message.Chat.Id, "Ваша заявка обрабатывается нашим оператором, благодарим за понимание", replyMarkup: keyboard122);
                                    }


                                    //await botTelegram.SendTextMessageAsync(message.Chat.Id, "Вы не зарегистрирвоаны в системе, ваша заявка отправлена и в ближайшее время будет обработана нашим оператором.", replyMarkup: keyboard1);
                                    //await botTelegram.SendTextMessageAsync(message.Chat.Id, "Здравствуйте, вы не зарегистрирован в системе, отправте ваши контактные данные и наш менеджер их обработает.", replyMarkup: keyboard1);
                                }
                                else if (allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.Rules > 0))
                                {
                                    botService = Program.kernel.Get<IBotService>();
                                    botService.TelegramUsersUpdateRulesByTelegramUserId(message.Chat.Id, 0);

                                    var keyboard2 = MenuBuilder.Menu(Utils.Rules.AuthUser);

                                    await botTelegram.SendTextMessageAsync(message.Chat.Id, "Здравствуйте, выберети интересуюущую вас услугу.", replyMarkup: keyboard2);
                                }
                                else
                                {

                                }
                                break;

                            #endregion

                            #region Наш сайт

                            case "Наш сайт":

                                if (!CheckUser(message.Chat.Id))
                                    break;

                                await botTelegram.SendTextMessageAsync(message.Chat.Id, "  Наш сайт:   \n  - [TERMINAL-MK](http://terminal-mk.com/) ", replyMarkup: MenuBuilder.Menu(Utils.Rules.AuthUser), parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown, disableWebPagePreview: false, disableNotification: false);

                                break;
                            #endregion

                            #region Наши контакты

                            case "Наши контакты":

                                if (!CheckUser(message.Chat.Id))
                                    break;

                                await botTelegram.SendTextMessageAsync(message.Chat.Id, " Вул. Соборна, 18/4, Кременчук, Полтавська область \n" +
                                    " 6090 с мобильного \n" + " mail@terminal-mk.com \n", parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown, disableWebPagePreview: true, disableNotification: false);

                                break;

                            #endregion

                            #region Заявка онлайн

                            case "Заявка онлайн":

                                if (!CheckUser(message.Chat.Id))
                                    break;

                                botService = Program.kernel.Get<IBotService>();
                                botService.TelegramUsersUpdateRulesByTelegramUserId(message.Chat.Id, 51);

                                await botTelegram.SendTextMessageAsync(message.Chat.Id, "Выберите вид продукции:", replyMarkup: MenuBuilder.ProductionMenu(message.Chat.Id), parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown, disableWebPagePreview: true, disableNotification: false);

                                break;

                            #endregion

                            #region Пункт загрузки (заявка)

                            case "Пункт загрузки (заявка)":

                                if (!CheckUser(message.Chat.Id))
                                    break;

                                botService = Program.kernel.Get<IBotService>();
                                botService.TelegramUsersUpdateRulesByTelegramUserId(message.Chat.Id, 52);

                                await botTelegram.SendTextMessageAsync(message.Chat.Id, "Выберите склад продукции:", replyMarkup: MenuBuilder.LoadAreaMenu(message.Chat.Id), parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown, disableWebPagePreview: true, disableNotification: false);

                                break;

                            #endregion

                            #region Пункт доставки (заявка)

                            case "Пункт доставки (заявка)":

                                if (!CheckUser(message.Chat.Id))
                                    break;

                                botService = Program.kernel.Get<IBotService>();
                                botService.TelegramUsersUpdateRulesByTelegramUserId(message.Chat.Id, 53);

                                await botTelegram.SendTextMessageAsync(message.Chat.Id, "Выберите город доставки продукции:", replyMarkup: MenuBuilder.UnloadAreaMenu(message.Chat.Id), parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown, disableWebPagePreview: true, disableNotification: false);

                                break;

                            #endregion

                            #region Количество машин (заявка)

                            case "Количество машин (заявка)":

                                if (!CheckUser(message.Chat.Id))
                                    break;

                                botService = Program.kernel.Get<IBotService>();
                                botService.TelegramUsersUpdateRulesByTelegramUserId(message.Chat.Id, 54);

                                await botTelegram.SendTextMessageAsync(message.Chat.Id, "Укажите количество машин:", replyMarkup: MenuBuilder.NumberOfCarMenu(), parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown, disableWebPagePreview: true, disableNotification: false);

                                break;

                            #endregion

                            #region Дата доставки

                            case "Дата доставки":

                                if (!CheckUser(message.Chat.Id))
                                    break;

                                botService = Program.kernel.Get<IBotService>();
                                botService.TelegramUsersUpdateRulesByTelegramUserId(message.Chat.Id, 55);

                                await botTelegram.SendTextMessageAsync(message.Chat.Id, "Выберите дату доставки:", replyMarkup: MenuBuilder.OrderDateMenu(), parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown, disableWebPagePreview: true, disableNotification: false);

                                break;

                            #endregion

                            #region Потверждение заявки

                            case "Потверждение заявки":

                                if (!CheckUser(message.Chat.Id))
                                    break;

                                botService = Program.kernel.Get<IBotService>();
                                botService.TelegramUsersUpdateRulesByTelegramUserId(message.Chat.Id, 56);

                                // UsersTelegramDTO currentuser = allUsers.First(x => x.UserTelegramId == message.Chat.Id);

                                UsersTelegramDTO userOrderTelegramDTO = botService.GetTelegramUserByUserTelegramId(message.Chat.Id);
                                //RoutesDTO routesDTO = botService.GetRouteByProductionLoadAreaUnloadArea((int)userTelegramDTO.CheckProductionId, (int)userTelegramDTO.CheckLoadAreaId, (int)userTelegramDTO.CheckUnloadAreaId);

                                string productOrder = "\nВид продукции: " + botService.GetProductionByid((int)userOrderTelegramDTO.CheckProductionId).FullName;
                                string routeOrder = "\nМаршрут: " + botService.GetCityByid((int)userOrderTelegramDTO.CheckLoadAreaId).Name + " - " + botService.GetCityByid((int)userOrderTelegramDTO.CheckUnloadAreaId).Name;
                                //string distance = "\nРасстояние: " + routesDTO.Distance + " км";
                                string machineNumberOrder = "\nКоличество машин: " + userOrderTelegramDTO.CheckNumberOfMachine;
                                string orderDateOrder = "\nДата доставки: " + userOrderTelegramDTO.OrderDate.Value.ToShortDateString() + "\n\n";

                                await botTelegram.SendTextMessageAsync(message.Chat.Id, "Ваша заявка " + productOrder + routeOrder + machineNumberOrder + orderDateOrder
                                    , replyMarkup: MenuBuilder.AccessOrderMenu(), parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown, disableWebPagePreview: true, disableNotification: false);

                                break;

                            #endregion

                            #region Расчитать стоимость доставки

                            case "Расчитать стоимость доставки":

                                if (!CheckUser(message.Chat.Id))
                                    break;

                                botService = Program.kernel.Get<IBotService>();
                                botService.TelegramUsersUpdateRulesByTelegramUserId(message.Chat.Id, 41);

                                await botTelegram.SendTextMessageAsync(message.Chat.Id, "Выберите вид продукции:", replyMarkup: MenuBuilder.ProductionMenu(message.Chat.Id), parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown, disableWebPagePreview: true, disableNotification: false);

                                break;

                            #endregion

                            #region Пункт загрузки (расчет)

                            case "Пункт загрузки (расчет)":

                                if (!CheckUser(message.Chat.Id))
                                    break;

                                botService = Program.kernel.Get<IBotService>();
                                botService.TelegramUsersUpdateRulesByTelegramUserId(message.Chat.Id, 42);

                                await botTelegram.SendTextMessageAsync(message.Chat.Id, "Выберите склад продукции:", replyMarkup: MenuBuilder.LoadAreaMenu(message.Chat.Id), parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown, disableWebPagePreview: true, disableNotification: false);

                                break;

                            #endregion

                            #region Пункт доставки (расчет)

                            case "Пункт доставки (расчет)":

                                if (!CheckUser(message.Chat.Id))
                                    break;

                                botService = Program.kernel.Get<IBotService>();
                                botService.TelegramUsersUpdateRulesByTelegramUserId(message.Chat.Id, 43);

                                await botTelegram.SendTextMessageAsync(message.Chat.Id, "Выберите город доставки продукции:", replyMarkup: MenuBuilder.UnloadAreaMenu(message.Chat.Id), parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown, disableWebPagePreview: true, disableNotification: false);

                                break;

                            #endregion

                            #region Количество машин

                            case "Количество машин (расчет)":

                                if (!CheckUser(message.Chat.Id))
                                    break;

                                botService = Program.kernel.Get<IBotService>();
                                botService.TelegramUsersUpdateRulesByTelegramUserId(message.Chat.Id, 44);

                                await botTelegram.SendTextMessageAsync(message.Chat.Id, "Укажите количество машин:", replyMarkup: MenuBuilder.NumberOfCarMenu(), parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown, disableWebPagePreview: true, disableNotification: false);

                                break;

                            #endregion

                            #region Количество машин

                            case "Отправить запрос на регистрацию":

                                if (!CheckUser(message.Chat.Id))
                                    break;

                                botService = Program.kernel.Get<IBotService>();
                                botService.TelegramUsersUpdateRulesByTelegramUserId(message.Chat.Id, 0);

                                await botTelegram.SendTextMessageAsync(message.Chat.Id, "Здравствуйте, выберети интересуюущую вас услугу.", replyMarkup: MenuBuilder.Menu(Utils.Rules.AuthUser));

                                break;

                            #endregion

                            #region Количество машин

                            case "Запросить обратный звонок":

                                if (!CheckUser(message.Chat.Id))
                                    break;

                                botService = Program.kernel.Get<IBotService>();
                                botService.TelegramUsersUpdateRulesByTelegramUserId(message.Chat.Id, 0);

                                MessagesDTO messageNewDTO = new MessagesDTO()
                                {
                                    Read = false,
                                    UserTelegramId = message.Chat.Id,
                                    Text = "Перезвоните мне пожалуйста"
                                };

                                controlPanelService.MessagesCreate(messageNewDTO);

                                await botTelegram.SendTextMessageAsync(message.Chat.Id, "Наш оператор в ближайшее время с вами свяжется.", replyMarkup: MenuBuilder.Menu(Utils.Rules.AuthUser));

                                break;

                            #endregion

                            #region Стоимость доставки

                            case "Стоимость доставки":

                                if (!CheckUser(message.Chat.Id))
                                    break;

                                botService = Program.kernel.Get<IBotService>();

                                UsersTelegramDTO userTelegramDTO = botService.GetTelegramUserByUserTelegramId(message.Chat.Id);
                                RoutesDTO routesDTO = botService.GetRouteByProductionLoadAreaUnloadArea((int)userTelegramDTO.CheckProductionId, (int)userTelegramDTO.CheckLoadAreaId, (int)userTelegramDTO.CheckUnloadAreaId);

                                string product = "\nВид продукции: " + botService.GetProductionByid((int)userTelegramDTO.CheckProductionId).FullName;
                                string route = "\nМаршрут: " + botService.GetCityByid((int)userTelegramDTO.CheckLoadAreaId).Name + " - " + botService.GetCityByid((int)userTelegramDTO.CheckUnloadAreaId).Name;
                                string distance = "\nРасстояние: " + routesDTO.Distance + " км";
                                string machineNumber = "\nКоличество машин: " + userTelegramDTO.CheckNumberOfMachine;
                                string shipPrice = "\nСтоимость: " + routesDTO.Rate * userTelegramDTO.CheckNumberOfMachine * routesDTO.Distance + " грн";

                                await botTelegram.SendTextMessageAsync(message.Chat.Id, product + route + distance + machineNumber + shipPrice,
                                    replyMarkup: MenuBuilder.Menu(Utils.Rules.AuthUser), parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown, disableWebPagePreview: true, disableNotification: false);

                                botService.TelegramUsersUpdateRulesByTelegramUserId(message.Chat.Id, 0);
                                botService.TelegramUsersClearDeiveryCost(message.Chat.Id);
                                break;

                            #endregion

                            #region Главное меню

                            case "Главное меню":

                                if (!CheckUser(message.Chat.Id))
                                    break;

                                if (allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.Rules > 1))
                                {
                                    botService = Program.kernel.Get<IBotService>();
                                    botService.TelegramUsersUpdateRulesByTelegramUserId(message.Chat.Id, 0);

                                    var keyboard1 = MenuBuilder.Menu(Utils.Rules.Manager);

                                    await botTelegram.SendTextMessageAsync(message.Chat.Id, "Здравствуйте, выберите пункт меню и узнайте о Ad Simple больше.", replyMarkup: keyboard1);
                                }
                                else if (allUsers.Any(x => x.UserTelegramId == message.Chat.Id && x.Rules == 1))
                                {
                                    botService = Program.kernel.Get<IBotService>();
                                    botService.TelegramUsersUpdateRulesByTelegramUserId(message.Chat.Id, 0);

                                    var keyboard2 = MenuBuilder.Menu(Utils.Rules.AuthUser);

                                    await botTelegram.SendTextMessageAsync(message.Chat.Id, "Здравствуйте, выберите пункт меню и узнайте о Ad Simple больше.", replyMarkup: keyboard2);
                                }
                                else
                                {
                                    botService = Program.kernel.Get<IBotService>();
                                    botService.TelegramUsersUpdateRulesByTelegramUserId(message.Chat.Id, 0);

                                    var keyboard3 = MenuBuilder.Menu(Utils.Rules.NoAuthUser);

                                    await botTelegram.SendTextMessageAsync(message.Chat.Id, "Здравствуйте, выберите пункт меню и узнайте о Ad Simple больше.", replyMarkup: keyboard3);
                                }

                                break;

                            #endregion

                            #region Отмена

                            case "Отмена":

                                if (!CheckUser(message.Chat.Id))
                                    break;

                                botService = Program.kernel.Get<IBotService>();

                                UsersTelegramDTO currentUserCancel = botService.GetTelegramUserByUserTelegramId(message.Chat.Id);

                                botService.TelegramUsersUpdateRulesByTelegramUserId(message.Chat.Id, 0);
                                botService.TelegramUsersClearDeiveryCost(message.Chat.Id);



                                //var keyboard2 = MenuBuilder.Menu(Utils.Rules.AuthUser);

                                await botTelegram.SendTextMessageAsync(message.Chat.Id, "Выберети интересуюущую вас услугу.", replyMarkup: MenuBuilder.Menu(Utils.Rules.AuthUser));


                                break;

                            #endregion


                            default:

                                break;
                        }
                    }

                    #endregion

                };


               // botTelegram.OnCallbackQuery += (object sc, Telegram.Bot.Args.CallbackQueryEventArgs ev) =>
               //{
               //    var message = ev.CallbackQuery.Data;
               //    if (ev.CallbackQuery.Data == "callback1")
               //    {
               //        long kkk = ev.CallbackQuery.Message.Chat.Id;
               //         //await; 
               //     }
               //    else
               //    if (ev.CallbackQuery.Data == "callback2")
               //    {
               //         // сюда то что нужно сделать при нажатии на вторую кнопку
               //     }
               //};

                botTelegram.StartReceiving();
            }

            catch (Telegram.Bot.Exceptions.ApiRequestException ex)
            {
                Console.WriteLine(ex.Message); // если ключ не подошел - пишем об этом в консоль отладки
            }

        }



        private void BtnRun_Click(object sender, EventArgs e)
        {

            if (botToken != "" && this.bw.IsBusy != true)
            {
                this.bw.RunWorkerAsync(botToken); // передаем эту переменную в виде аргумента методу bw_DoWork

                BtnRun.Text = "Бот запущен...";
            }

        }

        private bool CheckUser(long telegramUserId)
        {
            return allUsers.Any(x => x.UserTelegramId == telegramUserId);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //string postDate = dateText.Text;
            DateTime postDateTime;

            //if (DateTime.TryParseExact(postDate, "d/M/yyyy/HH/mm", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out postDateTime))
            //{
            //    //botService = Program.kernel.Get<IBotService>();

            //    //var posts = botService.GetPostsByUserTelegramId(message.Chat.Id);

            //    //foreach (var item in posts)
            //    //{
            //    //    if (postDateTime != null)
            //    //    {
            //    //        item.PublicDateTime = postDateTime;
            //    //        botService.TelegramPostUpdate(item);
            //    //    }

            //    //}
            //}
            //else
            //{
            //    // Handle the fact that parse did not succeed
            //}
        }

        private void BtnRun_Click_1(object sender, EventArgs e)
        {
            if (botToken != "" && this.bw.IsBusy != true)
            {
                this.bw.RunWorkerAsync(botToken); // передаем эту переменную в виде аргумента методу bw_DoWork

                BtnRun.Text = "Бот запущен...";
            }
        }
    }

    static class StringExtensions
    {
        static readonly Regex IconRegex = new Regex(@"(\u00a9|\u00ae|[\u2000-\u3300]|\ud83c[\ud000-\udfff]|\ud83d[\ud000-\udfff]|\ud83e[\ud000-\udfff])", RegexOptions.Compiled | RegexOptions.Multiline);
        public static IEnumerable<int> EnumerateSurrogatePairs(this string s)
        {
            foreach (Match match in IconRegex.Matches(s))
                yield return char.ConvertToUtf32(s, match.Index);

            yield break;
        }

        public static IEnumerable<int> EnumerateEmojiCodePoints(this string s) =>
            from symbol in s.EnumerateSurrogatePairs()
            where 0x1F600 <= symbol && symbol <= 0x1F64F
            select symbol;

        public static bool HasEmojis(this string s) => s.EnumerateEmojiCodePoints().Any();
    }
}






