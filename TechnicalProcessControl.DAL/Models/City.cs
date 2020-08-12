using System.ComponentModel.DataAnnotations;

namespace TechnicalProcessControl.DAL.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
