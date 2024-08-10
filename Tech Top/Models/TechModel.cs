using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tech_Top.Models
{
    public class TechModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
        public required string TechName { get; set; }
        public required string Description { get; set; }
        public required DateOnly ReleaseDate { get; set; }
        public required string Image { get; set; }
    }
}
