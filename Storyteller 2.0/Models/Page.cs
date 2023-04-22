using System.ComponentModel.DataAnnotations;

namespace Storyteller_2._0.Models
{
    public class Page
    {
        [Key]
        public int ID { get; set; }
        public string Description { get; set; }
        public int panels { get; set; }

    }
}
