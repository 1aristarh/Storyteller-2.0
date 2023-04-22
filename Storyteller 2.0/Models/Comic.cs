using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Storyteller_2._0.Data.Enum;

namespace Storyteller_2._0.Models
{
    public class Comic
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public int PageCount { get; set; }
        public string Genre { get; set; }
        public string Size { get; set; }
        public ComicCategory Type { get; set; }

        //Relationships
        public int PageId { get; set; }
        [ForeignKey("PageId")]
        public List<Page> Pages { get; set; }
    }
}
