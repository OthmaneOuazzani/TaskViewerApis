using System.ComponentModel.DataAnnotations;

namespace TaskViewerApis.Models
{
    public class Notification
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string TaskId { get; set; }
        public string Description { get; set; }
        public DateTime Time { get; set; }
        public bool IsSeen { get; set; }
        public string Status { get; set; }
        public string ChangedBy { get; set; }
    }

}
