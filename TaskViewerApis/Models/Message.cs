using System.ComponentModel.DataAnnotations;

namespace TaskViewerApis.Models
{
    public class Message
    {
        [Key]
        public string PlmId { get; set; }
        public string? LastTouch { get; set; }
        public bool? ToKill { get; set; }
        public string? ObjectPlmid { get; set; }
        public string? ObjectType { get; set; }
        public string? MessageTxt { get; set; }
        public string? MessageColor { get; set; }
        public string? MessageType { get; set; }
        public string? MessageType2 { get; set; }
        public string? WrittenBy { get; set; }
        public string? MessageDestination { get; set; }
        public string? Title { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public int? PictureCount { get; set; }
        public string? ReadBy { get; set; }
        public string? ProjectName { get; set; }
        public int? TweetLenMax { get; set; }
        public string? LastMessage { get; set; }
        public DateTime? LockDate { get; set; }
        public string? LockFlag { get; set; }
        public string? LockUser { get; set; }
        public DateTime? CancelledAt { get; set; }
    }
}
