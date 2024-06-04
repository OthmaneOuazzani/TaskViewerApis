using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskViewerApis.Models
{
    public class Rating
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string userId { get; set; }
        public int rating { get; set; }
        public string description { get; set; }
        public DateTime date { get; set; }
    }
}
