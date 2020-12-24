using System;
using System.ComponentModel.DataAnnotations;

namespace TechnicalProcessControl.DAL.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public string Name { get; set; }
        public int RoleId { get; set;  }
    }
}
