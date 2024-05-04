using System.ComponentModel.DataAnnotations;

namespace TaskViewer.Models
{
    public class TaskDetail
    {
        [Key]
        public string PlmId { get; set; }
        public string? ProjectName { get; set; }
        public int? LocalIndex { get; set; }
        public string? LockFlag { get; set; }
        public DateTime? LockDate { get; set; }
        public string? LockUser { get; set; }
        public string? FatherTaskName { get; set; }
        public string? TypeOfTask { get; set; }
        public int? TypeOfData { get; set; }
        public string? FieldToModify { get; set; }
        public string? XxMdsOrv { get; set; }
        public string? XxMdsUserv { get; set; }
        public string? XxMdsH { get; set; }
        public int? ModificationDetailRealOrValue { get; set; }
        public int? XxMdrUserv { get; set; }
        public string? ModificationDetailRealHistory { get; set; }
        public int? XxMdiOrv { get; set; }
        public int? XxMdiUserv { get; set; }
        public bool? XxMdiH { get; set; }
        public bool? ModificationDetailBoolOrValue { get; set; }
        public bool? XxMdbUserv { get; set; }
        public string? ModificationDetailBoolHistory { get; set; }
        public string? ModificationDetailDateSonOf { get; set; }
        public DateTime? ModificationDetailDateOrValue { get; set; }
        public DateTime? XxMddUserv { get; set; }
        public string? ModificationDetailDateHistory { get; set; }
        public string? RequestedBy { get; set; }
        public DateTime? RequestedAt { get; set; }
        public bool? Validated { get; set; }
        public bool? Completed { get; set; }
        public string? OriginalValueString { get; set; }
        public bool? ToKill { get; set; }
        public string? ObjectIdToUse { get; set; }
        public string? LastTouch { get; set; }
        public string? KValueOrValue { get; set; }
        public string? KValueUserValue { get; set; }
        public string? Comments { get; set; }
        public DateTime? CompletedAt { get; set; }
        public string? CompletedBy { get; set; }
        public string? Par1 { get; set; }
        public string? Par2 { get; set; }
        public string? Par3 { get; set; }
        public string? Par4 { get; set; }
        public string? Par5 { get; set; }
        public bool? Cancelled { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? CancelledAt { get; set; }
    }
}
