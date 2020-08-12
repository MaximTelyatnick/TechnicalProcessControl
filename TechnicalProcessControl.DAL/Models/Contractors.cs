using System.ComponentModel.DataAnnotations;

namespace TechnicalProcessControl.DAL.Models
{
    public class Contractors
    {
        [Key]

        public int Id { get; set; }
        public string NameContractors { get; set; }
    }
}
