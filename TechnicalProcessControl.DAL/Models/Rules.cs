using System.ComponentModel.DataAnnotations;

namespace TechnicalProcessControl.DAL.Models
{
    public class Rules
    {
        [Key]
        public int Id { get; set; }
        public string NameRules { get; set; }
    }
}
