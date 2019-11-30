using AutoMapper;
using TerminalMKTelegramBot.Interfaces;
using TerminalMKTelegramBot.Models;
using TerminalMKTelegramBot.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerminalMKTerminalBot.Models;
using TerminalMKTerminalBot.DTO;

namespace TerminalMKTelegramBot.Services
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
            });

            mapper = config.CreateMapper();
        }

        public IEnumerable<TelegramBotDTO> GetTelegramBots()
        {
            return mapper.Map<IEnumerable<TelegramBot>, List<TelegramBotDTO>>(telegramBot.GetAll());
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




    }
}
