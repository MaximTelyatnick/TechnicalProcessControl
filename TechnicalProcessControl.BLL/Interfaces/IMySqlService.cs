using System;
using System.Collections.Generic;
using TechnicalProcessControl.BLL.ModelsDTO;

namespace TechnicalProcessControl.BLL.Interfaces
{
    public interface IMySqlService
    {
        //IEnumerable<CityDTO> GetCity();
        IEnumerable<TelegramBotDTO> GetTelegramBots();
        IEnumerable<UsersTelegramDTO> GetTelegramBotUsers(int telegramBotId);

        IEnumerable<RoutesDTO> GetAllRoutes();

        IEnumerable<CityDTO> GetAllCity();
        IEnumerable<UsersTelegramDTO> GetAllUsers();
        IEnumerable<ContractorsDTO> GetAllContractors();
        IEnumerable<RulesDTO> GetAllRules();
        IEnumerable<ProductionDTO> GetProductionByContractorId(long userTelegramId);
        IEnumerable<CityDTO> GetLoadAreaByContractorId(long userTelegramId, int productionId);

        IEnumerable<CityDTO> GetUnloadAreaByContractorId(long userTelegramId, int productionId);
        int? GetProductionId(string productionName);
        CityDTO GetCityByid(int cityId);
        ProductionDTO GetProductionByid(int productionId);

        int? GetCityId(string cityName);
        RoutesDTO GetRouteByProductionLoadAreaUnloadArea(int productionId, int loadAreaId, int unloadAreaId);

        UsersTelegramDTO GetTelegramUserByUserTelegramId(long userTelegramId);

        IEnumerable<ProductionDTO> GetProduction();

        IEnumerable<MessagesDTO> GetMessages();

        bool CheckMessages();
        bool ContainMessages(long telegramId);

        #region Contractor CRUD
        int ContractorCreate(ContractorsDTO contractorDTO);
        void ContractorUpdate(ContractorsDTO contractorDTO);
        bool ContractorDelete(int id);
        #endregion

        #region TelegramBot CRUD
        int TelegramBotCreate(TelegramBotDTO telegramBotDTO);
        void TelegramBotUpdate(TelegramBotDTO telegramBotDTO);
        bool TelegramBotDelete(int id);
        #endregion

        #region TelegramUsers CRUD
        int TelegramUsersCreate(UsersTelegramDTO usersTelegramDTO);
        void TelegramUsersUpdate(UsersTelegramDTO usersTelegramDTO);
        void TelegramUsersUpdateRulesByTelegramUserId(long telegramUserId, int сurrentLevelMenu);
        void TelegramUsersUpdateCheckProductionIdByTelegramUserId(long telegramUserId, int productionId);
        void TelegramUsersUpdateCheckLoadAreaIdByTelegramUserId(long telegramUserId, int checkLoadAreaId);
        void TelegramUsersUpdateCheckUnloadAreaIdByTelegramUserId(long telegramUserId, int checkUnloadAreaId);
        void TelegramUsersUpdateCheckNumberOfMachineByTelegramUserId(long telegramUserId, short numberOfMachine);
        void TelegramUsersUpdateCheckOrderDateByTelegramUserId(long telegramUserId, DateTime orderDate);
        void TelegramUsersClearDeiveryCost(long telegramUserId);
        bool TelegramUsersDelete(int id);
        #endregion

        #region Orders CRUD
        int OrdersCreate(OrdersDTO ordersDTO);
        void OrdersUpdate(OrdersDTO ordersDTO);
        bool OrdersDelete(int id);

        #endregion

        #region Route CRUD

        int RouteCreate(RoutesDTO routesDTO);
        void RouteUpdate(RoutesDTO routesDTO);
        bool RouteDelete(int id);

        #endregion

        #region Production CRUD
        int ProductionCreate(ProductionDTO productionDTO);
        bool ProductionUpdate(ProductionDTO productionDTO);
        bool ProductionDelete(int id);

        #endregion

        #region Messages CRUD

        int MessagesCreate(MessagesDTO messagesDTO);
        void MessagesUpdate(MessagesDTO messagesDTO);
        bool MessagesDelete(int id);
        bool MessagesUpdateRange(List<MessagesDTO> source);

        #endregion
    }
}
