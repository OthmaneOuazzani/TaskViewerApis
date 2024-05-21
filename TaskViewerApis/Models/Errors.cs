using System.ComponentModel.DataAnnotations;

namespace TaskViewerApis.Models
{
    public class Errors
    {
        [Key]
        public string PlmId { get; set; }
        public string? Tokill { get; set; }
        public string? Category { get; set; }
        public string? ShortDescription { get; set; }
        public string? Explanation { get; set; }
        public string? Actors { get; set; }
        public string? Workshop { get; set; }
        public string? Url { get; set; }
        public string? Contributors { get; set; }
        public string? UseAsKpiFor { get; set; }
        public string? LastTouch { get; set; }
        public string? CorrectiveAction { get; set; }
        public string? RelatedObject { get; set; }
    }
}
