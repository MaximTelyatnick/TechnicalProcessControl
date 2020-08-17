﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalProcessControl.BLL.ModelsDTO;

namespace TechnicalProcessControl.BLL.Interfaces
{
    public interface IReportService
    {
        bool CreateTemplateTechProcess001(DrawingsDTO drawingsDTO);
        bool UpdateTemplateTechProcess001(DrawingsDTO drawingsDTO);

        bool CreateTemplateTechProcess002(DrawingsDTO drawingsDTO);
        bool UpdateTemplateTechProcess002(DrawingsDTO drawingsDTO);

        string TechProcesNameToStr(long? techProcessName);

    }
}
