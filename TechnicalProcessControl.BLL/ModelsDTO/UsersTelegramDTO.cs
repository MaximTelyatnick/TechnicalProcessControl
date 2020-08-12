using System;
using TechnicalProcessControl.BLL.Infrastructure;

namespace TechnicalProcessControl.BLL.ModelsDTO
{
    public class UsersTelegramDTO : ObjectBase
    {
        public int Id { get; set; }
        public long? UserTelegramId { get; set; }
        public int CurrentLevelMenu { get; set; }
        public int BotId { get; set; }
        public int ContractorId { get; set; }
        public string Name { get; set; }
        public int Rules { get; set; }
        public string UserName { get; set; }
        //public string ProductName { get; set; }
        //public string DeliveryArea { get; set; }

        //public string NumberOfmachine { get; set; }
        //public DateTime? OrderDate { get; set; }
        public int? OrderProductionId { get; set; }
        public int? OrderLoadAreaId { get; set; }
        public int? OrderUnloadAreaId { get; set; }
        public int? OrderNumberOfMachine { get; set; }
        public int? CheckProductionId { get; set; }
        public int? CheckLoadAreaId { get; set; }
        //public string CheckLoadAreaName { get; set; }
        public int? CheckUnloadAreaId { get; set; }
        //public string CheckUnloadAreaName { get; set; }
        public short? CheckNumberOfMachine { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string PhoneNumber { get; set; }
        public string NameContractors { get; set; }

        //public UsersTelegramDTO(UsersTelegramDTO model)
        //{
        //    this.Id = model.Id;
        //    this.BotId = model.BotId;
        //    this.CheckLoadAreaId = model.CheckLoadAreaId;
        //    this.CheckNumberOfMachine = model.CheckNumberOfMachine;
        //    this.CurrentLevelMenu = model.CurrentLevelMenu;
        //    this.CheckProductionId = model.CheckProductionId;
        //    this.CheckUnloadAreaId = model.CheckUnloadAreaId;
        //    this.ContractorId = model.ContractorId;
        //    this.Name = model.Name;
        //    this.NameContractors = model.NameContractors;
        //    this.OrderDate = model.OrderDate;
        //    this.OrderLoadAreaId = model.OrderLoadAreaId;
        //    this.OrderNumberOfMachine = model.OrderNumberOfMachine;
        //    this.OrderProductionId = model.OrderProductionId;
        //    this.OrderUnloadAreaId = model.OrderUnloadAreaId;
        //    this.PhoneNumber = model.PhoneNumber;
        //    this.RegistrationDate = model.RegistrationDate;
        //    this.Rules = model.Rules;
        //    this.UserName = model.UserName;
        //    this.UserTelegramId = model.UserTelegramId;
        //}
    }
}


