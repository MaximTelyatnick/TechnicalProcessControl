using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerminalMK.BLL.Infrastructure;

namespace TerminalMK.BLL.ModelsDTO
{
    public class ContractorsDTO : ObjectBase
    {
        public int Id { get; set; }
        public string NameContractors { get; set; }
    }
}
