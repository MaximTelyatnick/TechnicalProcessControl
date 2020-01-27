
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerminalMK.BLL.Interfaces;
using TerminalMK.BLL.ModelsDTO;
using TerminalMK.DAL.Interfaces;
using TerminalMK.DAL.Models;

namespace TerminalMK.BLL.Services
{
    public class BotService : IBotService
    {
        private IUnitOfWork Database { get; set; }
        private IRepository<TelegramBot> telegramBot;
        private IRepository<UsersTelegram> usersTelegram;
        private IRepository<TextTelegram> textTelegram;
        private IRepository<City> city;
        private IRepository<Routes> routes;
        private IRepository<Contractors> contractors;
        private IRepository<Production> production;
        private IRepository<Orders> orders;
        private IRepository<Rules> rules;
        private IRepository<Messages> messages;

        private IMapper mapper;

        public BotService(IUnitOfWork uow)
        {
            Database = uow;

            telegramBot = Database.GetRepository<TelegramBot>();
            usersTelegram = Database.GetRepository<UsersTelegram>();
            textTelegram = Database.GetRepository<TextTelegram>();
            city = Database.GetRepository<City>();
            routes = Database.GetRepository<Routes>();
            contractors = Database.GetRepository<Contractors>();
            production = Database.GetRepository<Production>();
            orders = Database.GetRepository<Orders>();
            rules = Database.GetRepository<Rules>();
            messages = Database.GetRepository<Messages>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TelegramBot, TelegramBotDTO>();
                cfg.CreateMap<TelegramBotDTO, TelegramBot>();
                cfg.CreateMap<UsersTelegram, UsersTelegramDTO>();
                cfg.CreateMap<UsersTelegramDTO, UsersTelegram>();
                cfg.CreateMap<TextTelegram, TextTelegramDTO>();
                cfg.CreateMap<TextTelegramDTO, TextTelegram>();
                cfg.CreateMap<City, CityDTO>();
                cfg.CreateMap<CityDTO, City>();
                cfg.CreateMap<Routes, RoutesDTO>();
                cfg.CreateMap<RoutesDTO, Routes>();
                cfg.CreateMap<Production, ProductionDTO>();
                cfg.CreateMap<ProductionDTO, Production>();
                cfg.CreateMap<City, CityDTO>();
                cfg.CreateMap<CityDTO, City>();
                cfg.CreateMap<Orders, OrdersDTO>();
                cfg.CreateMap<OrdersDTO, Orders>();
                cfg.CreateMap<Contractors, ContractorsDTO>();
                cfg.CreateMap<ContractorsDTO, Contractors>();
                cfg.CreateMap<Rules, RulesDTO>();
                cfg.CreateMap<RulesDTO, Rules>();
                cfg.CreateMap<Messages, MessagesDTO>();
                cfg.CreateMap<MessagesDTO, Messages>();
            });

            mapper = config.CreateMapper();
        }

        public IEnumerable<TelegramBotDTO> GetTelegramBots()
        {
            return mapper.Map<IEnumerable<TelegramBot>, List<TelegramBotDTO>>(telegramBot.GetAll());
        }

        public IEnumerable<ContractorsDTO> GetAllContractors()
        {
            return mapper.Map<IEnumerable<Contractors>, List<ContractorsDTO>>(contractors.GetAll());
        }

        public IEnumerable<RulesDTO> GetAllRules()
        {
            return mapper.Map<IEnumerable<Rules>, List<RulesDTO>>(rules.GetAll());
        }

        public IEnumerable<CityDTO> GetAllCity()
        {
            return mapper.Map<IEnumerable<City>, List<CityDTO>>(city.GetAll());
        }

        public CityDTO GetCityByid(int cityId)
        {
            return mapper.Map<City,CityDTO>(city.GetAll().First(city=>city.Id == cityId));
        }

        public UsersTelegramDTO GetTelegramUserByUserTelegramId(long userTelegramId)
        {
            UsersTelegramDTO user = mapper.Map<UsersTelegram, UsersTelegramDTO>(usersTelegram.GetAll().First(ust => ust.UserTelegramId == userTelegramId));
            return user;
        }

        public ProductionDTO GetProductionByid(int productionId)
        {
            return mapper.Map<Production, ProductionDTO>(production.GetAll().First(prod => prod.Id == productionId));
        }

        public RoutesDTO GetRouteByProductionLoadAreaUnloadArea(int productionId, int loadAreaId, int unloadAreaId)
        {
            return mapper.Map<Routes, RoutesDTO>(routes.GetAll().First(rot=> rot.ProductionId == productionId && rot.LoadAreaId == loadAreaId && rot.UnloadAreaId == unloadAreaId));
        }

        public IEnumerable<RoutesDTO> GetAllRoutes()
        {
            var result = (from rot in routes.GetAll()
                          join prod in production.GetAll() on rot.ProductionId equals prod.Id into prodd
                          from prod in prodd.DefaultIfEmpty()
                          join cyl in city.GetAll() on rot.LoadAreaId equals cyl.Id into cyll
                          from cyl in cyll.DefaultIfEmpty()
                          join cyu in city.GetAll() on rot.UnloadAreaId equals cyu.Id into cyuu
                          from cyu in cyuu.DefaultIfEmpty()
                          join con in contractors.GetAll() on rot.ContractorId equals con.Id into conn
                          from con in conn.DefaultIfEmpty()
                          select new RoutesDTO
                          {
                              Id = rot.Id,
                              ContractorId = rot.ContractorId,
                              ContractorName = con.NameContractors,
                              LoadAreaId = rot.LoadAreaId,
                              LoadAreaName = cyl.Name,
                              UnloadAreaId = rot.UnloadAreaId,
                              UnloadAreaName = cyu.Name,
                              ProductionId = rot.ProductionId,
                              ProductionName = prod.Name,
                              Distance = rot.Distance,
                              Rate = rot.Rate
                          }).ToList();

            return result;
        }

        public IEnumerable<UsersTelegramDTO> GetAllUsers()
        {
            var result = (from ut in usersTelegram.GetAll()
                          join con in contractors.GetAll() on ut.ContractorId equals con.Id into conn
                          from con in conn.DefaultIfEmpty()
                          select new UsersTelegramDTO
                          {
                              Id = ut.Id,
                              ContractorId = ut.ContractorId,
                              NameContractors = con.NameContractors,
                              Name = ut.Name,
                              PhoneNumber = ut.PhoneNumber,
                              Rules = ut.Rules,
                              UserName = ut.UserName,
                              UserTelegramId = ut.UserTelegramId
                          }).ToList();

            return result;
        }



        public IEnumerable<ProductionDTO> GetProductionByContractorId(long userTelegramId)
        {

            var result = (from rot in routes.GetAll()
                          join prod in production.GetAll() on rot.ProductionId equals prod.Id
                          join usr in usersTelegram.GetAll() on rot.ContractorId equals usr.ContractorId
                          where usr.UserTelegramId == userTelegramId
                          select new ProductionDTO
                          {
                              Id = prod.Id,
                              Name = prod.Name,
                              Description = prod.Description,
                              Type = prod.Type,
                              FullName = prod.FullName
                          }).ToList();

            var filterResul = result.GroupBy(x => x.Id).Select(y => y.FirstOrDefault());

            return filterResul;
        }

        public IEnumerable<CityDTO> GetLoadAreaByContractorId(long userTelegramId, int productionId)
        {

            var result = (from rot in routes.GetAll()
                          join usr in usersTelegram.GetAll() on rot.ContractorId equals usr.ContractorId
                          join cit in city.GetAll() on rot.LoadAreaId equals cit.Id
                          where (usr.UserTelegramId == userTelegramId && rot.ProductionId == productionId) 
                          select new CityDTO
                          {
                              Id = cit.Id,
                              Name = cit.Name
                          }).ToList();

            var filterResul = result.GroupBy(x => x.Id).Select(y => y.FirstOrDefault());

            return filterResul;
        }

        public IEnumerable<CityDTO> GetUnloadAreaByContractorId(long userTelegramId, int productionId)
        {

            var result = (from rot in routes.GetAll()
                          join usr in usersTelegram.GetAll() on rot.ContractorId equals usr.ContractorId
                          join cit in city.GetAll() on rot.UnloadAreaId equals cit.Id
                          where (usr.UserTelegramId == userTelegramId && rot.ProductionId == productionId)
                          select new CityDTO
                          {
                              Id = cit.Id,
                              Name = cit.Name
                          }).ToList();

            var filterResul = result.GroupBy(x => x.Id).Select(y => y.FirstOrDefault());

            return filterResul;
        }






        

        public int? GetProductionId(string productionName)
        {

            int? productionId = mapper.Map<IEnumerable<Production>, List<ProductionDTO>>(production.GetAll()).First(ust => ust.FullName == productionName).Id;
            //UsersTelegramDTO user = mapper.Map<UsersTelegram, UsersTelegramDTO>(usersTelegram.GetAll().First(ust => ust.UserTelegramId == userTelegramId));

            return productionId;
        }

        public int? GetCityId(string cityName)
        {

            int? cityId = mapper.Map<IEnumerable<City>, List<CityDTO>>(city.GetAll()).First(st => st.Name == cityName).Id;
            //UsersTelegramDTO user = mapper.Map<UsersTelegram, UsersTelegramDTO>(usersTelegram.GetAll().First(ust => ust.UserTelegramId == userTelegramId));

            return cityId;
        }

        public long GetLastOrder()
        {

            long orderNumber = mapper.Map<IEnumerable<Orders>, List<OrdersDTO>>(orders.GetAll()).Max(bdsm=>bdsm.Number);

            ++orderNumber;
            //UsersTelegramDTO user = mapper.Map<UsersTelegram, UsersTelegramDTO>(usersTelegram.GetAll().First(ust => ust.UserTelegramId == userTelegramId));

            return orderNumber;
        }

        public IEnumerable<UsersTelegramDTO> GetTelegramBotUsers(int telegramBotId)
        {

            var result = (from ut in usersTelegram.GetAll()
                          join tb in telegramBot.GetAll() on ut.BotId equals tb.Id into tbb
                          from tb in tbb.DefaultIfEmpty()
                          select new UsersTelegramDTO
                          {
                              Id = ut.Id,
                              Name = ut.Name,
                              CurrentLevelMenu = ut.CurrentLevelMenu,
                              Rules = ut.Rules,
                              UserName = ut.UserName,
                              UserTelegramId = ut.UserTelegramId,
                              BotId = ut.BotId,
                              ContractorId = ut.ContractorId,
                              OrderLoadAreaId = ut.OrderLoadAreaId,
                              OrderProductionId = ut.OrderProductionId,
                              OrderNumberOfMachine = ut.OrderNumberOfMachine,
                              OrderUnloadAreaId = ut.OrderUnloadAreaId,
                              CheckProductionId = ut.CheckProductionId,
                              CheckLoadAreaId = ut.CheckLoadAreaId,
                              CheckUnloadAreaId = ut.CheckUnloadAreaId,
                              CheckNumberOfMachine = ut.CheckNumberOfMachine,
                               OrderDate = ut.OrderDate

                          });
            return result.ToList();

        }

        public IEnumerable<ProductionDTO> GetProduction()
        {
            return mapper.Map<IEnumerable<Production>, List<ProductionDTO>>(production.GetAll());
        }

        public IEnumerable<MessagesDTO> GetMessages()
        {
            return mapper.Map<IEnumerable<Messages>, List<MessagesDTO>>(messages.GetAll());
        }



        public bool CheckMessages()
        {
            bool? checkMessage = mapper.Map<IEnumerable<Messages>, List<MessagesDTO>>(messages.GetAll()).Any(bdsm => bdsm.Read == false);

            bool newBool = checkMessage.HasValue ? checkMessage.Value : true;

            return newBool;
        }

        public bool ContainMessages(long telegramId)
        {
            bool? checkMessage = mapper.Map<IEnumerable<Messages>, List<MessagesDTO>>(messages.GetAll()).Any(bdsm => bdsm.UserTelegramId == telegramId);

            bool newBool = checkMessage.HasValue ? checkMessage.Value : false;

            return newBool;
        }




        #region Contractor's CRUD method's

        public int ContractorCreate(ContractorsDTO contractorDTO)
        {
            var createContractor = contractors.Create(mapper.Map<Contractors>(contractorDTO));
            return (int)createContractor.Id;
        }


        public void ContractorUpdate(ContractorsDTO contractorDTO)
        {
            var createContractor = contractors.GetAll().SingleOrDefault(c => c.Id == contractorDTO.Id);
            contractors.Update((mapper.Map<ContractorsDTO, Contractors>(contractorDTO, createContractor)));
        }



        public bool ContractorDelete(int id)
        {
            try
            {
                contractors.Delete(contractors.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region Bot's CRUD method's

        public int TelegramBotCreate(TelegramBotDTO telegramBotDTO)
        {
            var createTelegramBot = telegramBot.Create(mapper.Map<TelegramBot>(telegramBotDTO));
            return (int)createTelegramBot.Id;
        }


        public void TelegramBotUpdate(TelegramBotDTO telegramBotDTO)
        {
            var updatetelegramBot = telegramBot.GetAll().SingleOrDefault(c => c.Id == telegramBotDTO.Id);
            telegramBot.Update((mapper.Map<TelegramBotDTO, TelegramBot>(telegramBotDTO, updatetelegramBot)));
        }



        public bool TelegramBotDelete(int id)
        {
            try
            {
                telegramBot.Delete(telegramBot.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region Telegram Users CRUD method's

        public int TelegramUsersCreate(UsersTelegramDTO usersTelegramDTO)
        {
            var createUsersTelegram = usersTelegram.Create(mapper.Map<UsersTelegram>(usersTelegramDTO));
            return (int)createUsersTelegram.Id;
        }


        public void TelegramUsersUpdate(UsersTelegramDTO usersTelegramDTO)
        {
            var updateUsersTelegram = usersTelegram.GetAll().SingleOrDefault(c => c.Id == usersTelegramDTO.Id);
            usersTelegram.Update((mapper.Map<UsersTelegramDTO, UsersTelegram>(usersTelegramDTO, updateUsersTelegram)));
        }

        public void TelegramUsersUpdateRulesByTelegramUserId(long telegramUserId, int сurrentLevelMenu)
        {
            var updateRulesUser = mapper.Map<IEnumerable<UsersTelegram>, List<UsersTelegramDTO>>(usersTelegram.GetAll()).First(ust => ust.UserTelegramId == telegramUserId);
            updateRulesUser.CurrentLevelMenu = сurrentLevelMenu;
            TelegramUsersUpdate(updateRulesUser);
        }

        public void TelegramUsersUpdateCheckProductionIdByTelegramUserId(long telegramUserId, int productionId)
        {
            var updateRulesUser = mapper.Map<IEnumerable<UsersTelegram>, List<UsersTelegramDTO>>(usersTelegram.GetAll()).First(ust => ust.UserTelegramId == telegramUserId);
            updateRulesUser.CheckProductionId = productionId;
            TelegramUsersUpdate(updateRulesUser);
        }

        public void TelegramUsersUpdateCheckLoadAreaIdByTelegramUserId(long telegramUserId, int checkLoadAreaId)
        {
            var updateRulesUser = mapper.Map<IEnumerable<UsersTelegram>, List<UsersTelegramDTO>>(usersTelegram.GetAll()).First(ust => ust.UserTelegramId == telegramUserId);
            updateRulesUser.CheckLoadAreaId = checkLoadAreaId;
            TelegramUsersUpdate(updateRulesUser);
        }

        public void TelegramUsersUpdateCheckUnloadAreaIdByTelegramUserId(long telegramUserId, int checkUnloadAreaId)
        {
            var updateRulesUser = mapper.Map<IEnumerable<UsersTelegram>, List<UsersTelegramDTO>>(usersTelegram.GetAll()).First(ust => ust.UserTelegramId == telegramUserId);
            updateRulesUser.CheckUnloadAreaId = checkUnloadAreaId;
            TelegramUsersUpdate(updateRulesUser);
        }

        public void TelegramUsersUpdateCheckNumberOfMachineByTelegramUserId(long telegramUserId, short numberOfMachine)
        {
            var updateRulesUser = mapper.Map<IEnumerable<UsersTelegram>, List<UsersTelegramDTO>>(usersTelegram.GetAll()).First(ust => ust.UserTelegramId == telegramUserId);
            updateRulesUser.CheckNumberOfMachine = numberOfMachine;
            TelegramUsersUpdate(updateRulesUser);
        }

        public void TelegramUsersUpdateCheckOrderDateByTelegramUserId(long telegramUserId, DateTime orderDate)
        {
            var updateRulesUser = mapper.Map<IEnumerable<UsersTelegram>, List<UsersTelegramDTO>>(usersTelegram.GetAll()).First(ust => ust.UserTelegramId == telegramUserId);
            updateRulesUser.OrderDate = orderDate;
            TelegramUsersUpdate(updateRulesUser);
        }

        public void TelegramUsersClearDeiveryCost(long telegramUserId)
        {
            var updateRulesUser = mapper.Map<IEnumerable<UsersTelegram>, List<UsersTelegramDTO>>(usersTelegram.GetAll()).First(ust => ust.UserTelegramId == telegramUserId);
            updateRulesUser.CheckNumberOfMachine = null;
            updateRulesUser.CheckLoadAreaId = null;
            updateRulesUser.CheckProductionId = null;
            updateRulesUser.CheckUnloadAreaId = null;
            TelegramUsersUpdate(updateRulesUser);
        }


        public bool TelegramUsersDelete(int id)
        {
            try
            {
                usersTelegram.Delete(usersTelegram.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region Order's CRUD method's

        public int OrdersCreate(OrdersDTO ordersDTO)
        {
            var createOrders = orders.Create(mapper.Map<Orders>(ordersDTO));
            return (int)createOrders.Id;
        }

        public void OrdersUpdate(OrdersDTO ordersDTO)
        {
            var updateOrders = orders.GetAll().SingleOrDefault(c => c.Id == ordersDTO.Id);
            orders.Update((mapper.Map<OrdersDTO, Orders>(ordersDTO, updateOrders)));
        }

        public bool OrdersDelete(int id)
        {
            try
            {
                orders.Delete(orders.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region Route's CRUD method's

        public int RouteCreate(RoutesDTO routesDTO)
        {
            var createRoute = routes.Create(mapper.Map<Routes>(routesDTO));
            return (int)createRoute.Id;
        }

        public void RouteUpdate(RoutesDTO routesDTO)
        {
            var updateRoutes = routes.GetAll().SingleOrDefault(c => c.Id == routesDTO.Id);
            routes.Update((mapper.Map<RoutesDTO, Routes>(routesDTO, updateRoutes)));
        }

        public bool RouteDelete(int id)
        {
            try
            {
                routes.Delete(routes.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region Production's CRUD method's

        public int ProductionCreate(ProductionDTO productionDTO)
        {
            var createProductiont = production.Create(mapper.Map<Production>(productionDTO));
            return (int)createProductiont.Id;
        }

        public void ProductionUpdate(ProductionDTO productionDTO)
        {
            var updateProduction = production.GetAll().SingleOrDefault(c => c.Id == productionDTO.Id);
            production.Update((mapper.Map<ProductionDTO, Production>(productionDTO, updateProduction)));
        }

        public bool ProductionDelete(int id)
        {
            try
            {
                production.Delete(production.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region Messages CRUD method's

        public int MessagesCreate(MessagesDTO messagesDTO)
        {
            var createMessages = messages.Create(mapper.Map<Messages>(messagesDTO));
            return (int)createMessages.Id;
        }

        public void MessagesUpdate(MessagesDTO messagesDTO)
        {
            var updateMessages = messages.GetAll().SingleOrDefault(c => c.Id == messagesDTO.Id);
            messages.Update((mapper.Map<MessagesDTO, Messages>(messagesDTO, updateMessages)));
        }

        public bool MessagesDelete(int id)
        {
            try
            {
                messages.Delete(messages.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool MessagesUpdateRange(List<MessagesDTO> source)
        {
            try
            {
                foreach (var item in source)
                {
                    var updateMessages = messages.GetAll().SingleOrDefault(c => c.Id == item.Id);
                    messages.Update((mapper.Map<MessagesDTO, Messages>(item, updateMessages)));
                }


                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion




    }
}
