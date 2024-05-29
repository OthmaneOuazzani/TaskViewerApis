using System.ComponentModel.DataAnnotations;

namespace TaskViewerApis.Models
{
    public class Np
    {
        [Key]
        public string? ProjectName { get; set; }
        [Key]
        public string PlmId { get; set; }
        public string? LockFlag { get; set; }
        public string? LockDate { get; set; }
        public string? LockUser { get; set; }
        public string? Decpsa { get; set; }
        public string? BaseVeh { get; set; }
        public string? ImplementationArea { get; set; }
        public string? ConfigurationContext { get; set; }
        public string? Tasks { get; set; }
        public string? Comments { get; set; }
        public int? Flag { get; set; }
        public string? XxErCv { get; set; }
        public string? XxErIv { get; set; }
        public string? XxErRv { get; set; }
        public string? CreationDate { get; set; }
        public string? ValidationDate { get; set; }
        public string? RequestedBy { get; set; }
        public string? CreationValidation { get; set; }
        public string? Tokill { get; set; }
        public string? CreatedAt { get; set; }
        public string? LastModifAt { get; set; }
        public string? KpiCalled { get; set; }
        public string? LastTouch { get; set; }
        public string? Kb01Pconfs { get; set; }
        public string? BaseVehicleInNp { get; set; }
        public string? ModuleInNp { get; set; }
        public string? ModuleTypeInNp { get; set; }
        public string? PowertrainInNp { get; set; }
        public string? ErrorDesc { get; set; }
        public string? ChildpaCurrvalue { get; set; }
        public string? ChildpaIntmvalue { get; set; }
        public string? ChildpaRefvalue { get; set; }
        public string? ErrordescCurrvalue { get; set; }
        public string? ErrordescIntmvalue { get; set; }
        public string? ErrordescRefvalue { get; set; }
        public int? PresentinCurrvalue { get; set; }
        public int? PresentinIntmvalue { get; set; }
        public int? PresentinRefvalue { get; set; }
        public string? TaskLink { get; set; }
        public string? CreatedBy { get; set; }
        public string? Domain { get; set; }
        public string? PortraitRobot { get; set; }
        public string? PrfMetierSpec { get; set; }
        public string? EffRestriction { get; set; }
        public string? WinAttachement { get; set; }
        public string? DnaErrors { get; set; }
        public int? DnaCombinationsCount { get; set; }
        public int? DnaHolesCount { get; set; }
        public int? DnaBumpsCount { get; set; }
        public int? DnaOtherErrorsCount { get; set; }
        public int? DnaMaxCombines { get; set; }
        public string? IsDnaCombinationsFull { get; set; }
        public string? DnaIsUptodate { get; set; }
        public string? DnaTaskAction { get; set; }
        public string? DnaTaskRcd { get; set; }
        public string? DnaTaskRcdFeedback { get; set; }
        public string? DnaTaskDate { get; set; }
        public string? EffRestrictionIsUpdated { get; set; }
        public string? LatestEvent { get; set; }
        public string? EventType { get; set; }
        public string? PreviousRestriction { get; set; }
        public string? CancelledAt { get; set; }
    }
}
