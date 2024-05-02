namespace TaskViewerApis.Models
{
    public class Prea
    {
        public string ProjectName { get; set; }
        public decimal LocalIndex { get; set; }
        public string PlmId { get; set; }
        public string LoadedCurrValue { get; set; }
        public string LoadedIntmValue { get; set; }
        public string LoadedRefValue { get; set; }
        public string LoadedHistory { get; set; }
        public string LockFlag { get; set; }
        public DateTime LockDate { get; set; }
        public string LockUser { get; set; }
        public string Owner { get; set; }
        public string Psadeadline { get; set; }
        public decimal Quantity { get; set; }
        public decimal MassCurrValue { get; set; }
        public decimal MassIntmValue { get; set; }
        public decimal MassRefValue { get; set; }
        public string MassHistory { get; set; }
        public string DesignerPrefered { get; set; }
        public string Avancement { get; set; }
        public string Pdef { get; set; }
        public string Tasks { get; set; }
        public decimal Flag { get; set; }
        public string ErrorsCurrValue { get; set; }
        public string ErrorsIntmValue { get; set; }
        public string ErrorsRefValue { get; set; }
        public string ErrorsHistory { get; set; }
        public string History { get; set; }
        public string Applicability { get; set; }
        public decimal CountOfUses { get; set; }
        public string DecPsa { get; set; }
        public string DesignationEn { get; set; }
        public string DesignationFr { get; set; }
        public string RefPsa { get; set; }
        public string State { get; set; }
        public bool Tokill { get; set; }
        public bool BelongsToContextR { get; set; }
        public string ConfigurationContextes { get; set; }
        public string HighestRevision { get; set; }
        public string Pas { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastModifAt { get; set; }
        public bool BelongsToPConfCurrValue { get; set; }
        public bool BelongsToPConfIntmValue { get; set; }
        public bool BelongsToPConfRefValue { get; set; }
        public bool KpiCalled { get; set; }
        public string LastTouch { get; set; }
        public string ErrorDesc { get; set; }
        public string ErrorDescCurrValue { get; set; }
        public string ErrorDescIntmValue { get; set; }
        public string ErrorDescRefValue { get; set; }
        public string FatherPdef { get; set; }
        public DateTime LatestEvent { get; set; }
        public string EventType { get; set; }
        public string PreviousApplicability { get; set; }
        public DateTime CancelledAt { get; set; }
    }
}
