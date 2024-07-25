
using System.ComponentModel.DataAnnotations;

namespace TaskViewerApis.Models
{
    public class La
    {
        [Key]
        public string PlmId { get; set; }
        public string? ToKill { get; set; }
        public string? ExpectedConf { get; set; }
        public string? ExpectedConfTitle { get; set; }
        public string? Title { get; set; }
        public string? DeliverableType { get; set; }
        public string? State { get; set; }
        public string? Avancement { get; set; }
        public string? AssignedPerson { get; set; }
        public DateTime? AgreedDate { get; set; }
        public DateTime? ReleasedDate { get; set; }
        public string? EcoId { get; set; }
        public string? EcoState { get; set; }
        public string? Context { get; set; }
        public string? SatisfiedByType { get; set; }
        public string? SatisfiedBy { get; set; }
        public string? SatisfiedByRevision { get; set; }
        public string? SatisfiedByState { get; set; }
        public string? SatisfiedByEco { get; set; }
        public string? SatisfiedByEcoState { get; set; }
        public string? Cotert { get; set; }
        public string? CoterAl { get; set; }
        public string? DecPsa { get; set; }
        public string? ProjectPackage { get; set; }
        public string? Errors { get; set; }
        public string? Metier { get; set; }
        public string? Timing { get; set; }
        public string? ProjectNameList { get; set; }
        public string? ProjectNames { get; set; }
        public string? LastTouch { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
        public string? ContextObjectId { get; set; }
        public string? ContextType { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? CustomerDate { get; set; }
        public string? Leader { get; set; }
        public string? ManagementState { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public string? ObjectId { get; set; }
        public string? ProjectOwnership { get; set; }
        public string? ProjectSpaceName { get; set; }
        public string? ProjectSpaceObjectId { get; set; }
        public string? SatisfiedByObjectId { get; set; }
        public DateTime? SupplierDate { get; set; }
        public DateTime? ValidatedAt { get; set; }
        public string? TaskLink { get; set; }
        public string? ProjectSpace { get; set; }
        public string? LinkedDocument { get; set; }
        public string? ToDoBy { get; set; }
        public DateTime? LockDate { get; set; }
        public string? LockFlag { get; set; }
        public string? LockUser { get; set; }
        public DateTime? ReviewedAt { get; set; }
        public string? Cnx { get; set; }
        public string? Comments { get; set; }
        public string? FunctionalPackage { get; set; }
        public string? Supervisor { get; set; }
        public string? Service { get; set; }
        public DateTime? CancelledAt { get; set; }
    }
}