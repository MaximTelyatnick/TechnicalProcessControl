using TerminalMKTelegramBot.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerminalMKTerminalBot.DTO;

namespace TerminalMKTelegramBot.Interfaces
{
    public interface IBotService
    {

        IEnumerable<TelegramBotDTO> GetTelegramBots();
        IEnumerable<UsersTelegramDTO> GetTelegramBotUsers(int telegramBotId);

        IEnumerable<ProductionDTO> GetProductionByContractorId(long userTelegramId);
        IEnumerable<CityDTO> GetLoadAreaByContractorId(long userTelegramId, int productionId);

        IEnumerable<CityDTO> GetUnloadAreaByContractorId(long userTelegramId, int productionId);
        int? GetProductionId(string productionName);
        CityDTO GetCityByid(int cityId);
        ProductionDTO GetProductionByid(int productionId);

        int? GetCityId(string cityName);
        RoutesDTO GetRouteByProductionLoadAreaUnloadArea(int productionId, int loadAreaId, int unloadAreaId);
        
        //IEnumerable<PostTelegramDTO> GetPostsByUserTelegramId(long userTelegramId);
        //IEnumerable<PostTelegramDTO> GetTelegramPostContent(long telegramUserId);

        //PictureTelegramDTO GetPictureByPostId(int postId);

        //IEnumerable<PostTelegramDTO> GetAllPost();

        //IEnumerable<PictureTelegramStaticDTO> GetPictureByStock();
        //IEnumerable<PictureTelegramStaticDTO> GetPictureByСommerce();
        //TextTelegramDTO GetTextByPostId(int postId);

        //IEnumerable<PostTelegramDTO> GetTelegramPostByNumber(short numberPost);
        //IEnumerable<PostTelegramDTO> GetTelegramAutopostingPost();

        //short[] GetTelegramAutopostingPostNumbers();

        UsersTelegramDTO GetTelegramUserByUserTelegramId(long userTelegramId);

        int TelegramBotCreate(TelegramBotDTO telegramBotDTO);
        void TelegramBotUpdate(TelegramBotDTO telegramBotDTO);
        bool TelegramBotDelete(int id);


        int TelegramUsersCreate(UsersTelegramDTO usersTelegramDTO);
        void TelegramUsersUpdate(UsersTelegramDTO usersTelegramDTO);
        void TelegramUsersUpdateRulesByTelegramUserId(long telegramUserId, int сurrentLevelMenu);
        //void TelegramUsersUpdateProductNameByTelegramUserId(long telegramUserId, string productName);
        //void TelegramUsersUpdateDeliveryAreaByTelegramUserId(long telegramUserId, string deliveryArea);
        //void TelegramUsersUpdateNumberOfMachineByTelegramUserId(long telegramUserId, string numberOfMachine);
        void TelegramUsersUpdateCheckProductionIdByTelegramUserId(long telegramUserId, int productionId);
        void TelegramUsersUpdateCheckLoadAreaIdByTelegramUserId(long telegramUserId, int checkLoadAreaId);
        void TelegramUsersUpdateCheckUnloadAreaIdByTelegramUserId(long telegramUserId, int checkUnloadAreaId);
        void TelegramUsersUpdateCheckNumberOfMachineByTelegramUserId(long telegramUserId, short numberOfMachine);
        void TelegramUsersUpdateCheckOrderDateByTelegramUserId(long telegramUserId, DateTime orderDate);
        void TelegramUsersClearDeiveryCost(long telegramUserId);
        //void TelegramUsersUpdateOrderDateByTelegramUserId(long telegramUserId, DateTime orderDate);
        bool TelegramUsersDelete(int id);

        int OrdersCreate(OrdersDTO ordersDTO);
        void OrdersUpdate(OrdersDTO ordersDTO);
        bool OrdersDelete(int id);



        //int TelegramPictureCreate(PictureTelegramDTO pictureTelegramDTO);
        //void TelegramPictureUpdate(PictureTelegramDTO pictureTelegramDTO);
        //bool TelegramPictureDelete(int id);


        //int TelegramPostCreate(PostTelegramDTO postTelegramDTO);
        //void TelegramPostUpdate(PostTelegramDTO postTelegramDTO);
        //void (long telegramUserId, DateTime postPublishTime);
        //bool TelegramPostDelete(int id);
        //bool TelegramAllPostDeleteByNumberPost(short numberPost);
        //bool TelegramAllPostDeleteByTelegramUserId(long telegramUserId);

        //int TelegramTextCreate(TextTelegramDTO textTelegramDTO);
        //void TelegramTextUpdate(TextTelegramDTO textTelegramDTO);
        //bool TelegramTextDelete(int id);

        //int TelegramComplaintCreate(ComplaintUsersDTO complaintUsersDTO);

        //void TelegramComplaintUpdate(ComplaintUsersDTO complaintUsersDTO);
        //bool TelegramComplaintDelete(int id);

        //int TelegramPictureStaticCreate(PictureTelegramStaticDTO pictureTelegramStaticDTO);
        //void TelegramPictureStaticUpdate(PictureTelegramStaticDTO pictureTelegramStaticDTO);
        //bool TelegramPictureStaticDelete(int id);



    }
}
