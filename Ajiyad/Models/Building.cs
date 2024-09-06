using System.ComponentModel.DataAnnotations;

namespace Ajiyad.Models
{
    public class Building
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string name { get; set; }
        public string client { get; set; }
        public string consultant { get; set; }
        public int cost { get; set; }

        
    }
}
