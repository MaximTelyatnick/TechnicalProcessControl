﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalProcessControl.BLL.Infrastructure;

namespace TechnicalProcessControl.BLL.ModelsDTO
{
    public class OperationNumberDTO : ObjectBase
    {
        public int Id { get; set; }
        public string TableId { get; set; }
        public string OperationNumberName { get; set; }
    }
}
