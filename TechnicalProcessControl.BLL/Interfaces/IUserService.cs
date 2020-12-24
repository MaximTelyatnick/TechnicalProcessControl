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
        IEnumerable<UsersDTO> GetAllUsersWithRole();

       UsersDTO CheckUser(string login, string password);

        int UserCreate(UsersDTO userDTO);
        void UserUpdate(UsersDTO userDTO);
        bool UserDelete(int id);

    }
}
