using System.ComponentModel.DataAnnotations;

namespace TP33.Models
{
    public class Miniature
    {

        [Key]
        public int Id { get; set; }
        
        [Required]
        public string name { get; set; }

      
        public bool TableReady { get; set; }=false;
        public string description { get; set; }

    }
}
