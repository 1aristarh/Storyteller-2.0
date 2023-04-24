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
        [Required]
        public string Description { get; set; }
        [Required]
        public int PageCount { get; set; }
        [Required]
        [MaxLength(50)]
        public string Genre { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public ComicCategory Type { get; set; }
        [Required]

        //Relationships
        public int PageId { get; set; }
        [ForeignKey("PageId")]
        public List<Page> Pages { get; set; }
        public Comic()
        {

        }
    }
}
