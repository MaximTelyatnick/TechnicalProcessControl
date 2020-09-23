using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalProcessControl.BLL.ModelsDTO;

namespace TechnicalProcessControl.BLL.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UsersDTO> GetAllUsers();

       UsersDTO CheckUser(string login, string password);
    }
}
