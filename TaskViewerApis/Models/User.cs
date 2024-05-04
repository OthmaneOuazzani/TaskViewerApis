using System.ComponentModel.DataAnnotations;

namespace TaskViewer.Models
{
    public class User
    {
        [Key]
        public string PlmId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Occupation { get; set; }
        public bool? PrfConfidential { get; set; }
        public bool? StyleConfidential { get; set; }
        public string? Proj1 { get; set; }
        public string? Proj2 { get; set; }
        public string? Proj3 { get; set; }
        public string? Proj4 { get; set; }
        public string? Proj5 { get; set; }
        public string? Proj6 { get; set; }
        public string? Proj7 { get; set; }
        public string? Proj8 { get; set; }
        public string? Proj9 { get; set; }
        public string? Proj10 { get; set; }
        public int? NumberOfConnexions { get; set; }
        public DateTime? SubscribedSince { get; set; }
        public DateTime? LastConnection { get; set; }
        public string? Picture { get; set; }
        public string? Sex { get; set; }
        public string? Homepage { get; set; }
        public bool? SoundOption { get; set; }
        public string? PreferredLanguage { get; set; }
        public bool? ToKill { get; set; }
        public string? VisitedProjects { get; set; }
        public string? LastTouch { get; set; }
        public string? AddedBy { get; set; }
        public string? MainActivity { get; set; }
        public bool? PwtSqlLoader { get; set; }
        public int? PreloadingDelayDays { get; set; }
        public bool? DisablePopupMess { get; set; }
        public string? Service { get; set; }
        public string? PrefBomComByProject { get; set; }
        public int? OldLaFilter { get; set; }
        public string? SelectedVoice { get; set; }
        public string? SkipDbChoice { get; set; }
        public string? Company { get; set; }
        public int? MyHighCardinal { get; set; }
        public int? MyLowCardinal { get; set; }
        public bool? AutoSaveActivated { get; set; }
        public DateTime? LockDate { get; set; }
        public bool? LockFlag { get; set; }
        public string? LockUser { get; set; }
        public bool? IsKeyUser { get; set; }
        public bool? DisableProjectInfoPopup { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? CancelledAt { get; set; }
    }

}
