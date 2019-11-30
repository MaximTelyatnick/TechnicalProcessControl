﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalMKTelegramBot.DTO
{
    public class UsersTelegramDTO
    {
        public int Id { get; set; }
        public long UserTelegramId { get; set; }
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


    }
}


