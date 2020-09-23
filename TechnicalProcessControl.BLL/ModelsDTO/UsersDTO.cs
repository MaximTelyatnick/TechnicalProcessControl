using System;
using TechnicalProcessControl.BLL.Infrastructure;

namespace TechnicalProcessControl.BLL.ModelsDTO
{
    public class UsersDTO : ObjectBase
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public string Name { get; set; }
        public short? RoleId { get; set; }
    }
}


