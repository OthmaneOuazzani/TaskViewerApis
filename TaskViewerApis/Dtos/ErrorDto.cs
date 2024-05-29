using System.ComponentModel.DataAnnotations;

namespace TaskViewerApis.Dtos
{
    public class ErrorDto
    {
        public string PlmId { get; set; }
        public string? Category { get; set; }
        public string? ShortDescription { get; set; }
        public string? Explanation { get; set; }
        public string? Actors { get; set; }
        public string? Workshop { get; set; }
        public string? Contributors { get; set; }
        public string? CorrectiveAction { get; set; }
    }
}
