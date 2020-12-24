using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalProcessControl.BLL.Interfaces;
using TechnicalProcessControl.BLL.ModelsDTO;
using TechnicalProcessControl.DAL.Interfaces;
using TechnicalProcessControl.DAL.Models;

namespace TechnicalProcessControl.BLL.Services
{
    public class UserService : IUserService
    {
        private IUnitOfWork Database { get; set; }

        private IRepository<Users> users;
        private IRepository<UserRole> userRole;

        private IMapper mapper;

        public UserService(IUnitOfWork uow)
        {
            Database = uow;

            users = Database.GetRepository<Users>();
            userRole = Database.GetRepository<UserRole>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Users, UsersDTO>();
                cfg.CreateMap<UsersDTO, Users>();
                cfg.CreateMap<UserRole, UserRoleDTO>();
                cfg.CreateMap<UserRoleDTO, UserRole>();
            });

            mapper = config.CreateMapper();
        }


        public IEnumerable<UsersDTO> GetAllUsers()
        {
            return mapper.Map<IEnumerable<Users>, List<UsersDTO>>(users.GetAll());
        }

        public IEnumerable<UsersDTO> GetAllUsersWithRole()
        {
            var result = (from ur in users.GetAll()
                          join rl in userRole.GetAll() on ur.RoleId equals rl.Id 
                          select new UsersDTO
                          {
                              Id = ur.Id,
                              Login = ur.Login,
                              Name = ur.Name,
                              Pass = ur.Pass,
                              RoleId = ur.Id,
                              RoleName = rl.RoleName

                          }
                          ).ToList();

            return result;
        }


        public UsersDTO CheckUser(string login, string password)
        {
            var user = mapper.Map<Users, UsersDTO>(users.GetAll().FirstOrDefault(bdsm => bdsm.Login == login && bdsm.Pass == password));

            return user;
        }

        public int UserCreate(UsersDTO userDTO)
        {
            var createUser = users.Create(mapper.Map<Users>(userDTO));
            return (int)createUser.Id;
        }

        public void UserUpdate(UsersDTO userDTO)
        {
            var updateUser = users.GetAll().SingleOrDefault(c => c.Id == userDTO.Id);
            users.Update((mapper.Map<UsersDTO, Users>(userDTO, updateUser)));
        }

        public bool UserDelete(int id)
        {
            try
            {
                users.Delete(users.GetAll().FirstOrDefault(c => c.Id == id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


    }
}
