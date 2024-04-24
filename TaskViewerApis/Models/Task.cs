namespace TaskViewer.Models
{
    public class Task
    {
        public string ProjectName { get; set; }
        public int LocalIndex { get; set; }
        public string PlmId { get; set; }
        public string LockFlag { get; set; }
        public DateTime LockDate { get; set; }
        public string LockUser { get; set; }
        public string ProductLine { get; set; }
        public string Workshop { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ValidatedBy { get; set; }
        public DateTime ValidatedAt { get; set; }
        public string ObjectType { get; set; }
        public string TypeOfTask { get; set; }
        public string ValidationStatus { get; set; }
        public string Comments { get; set; }
        public string ListOfTasks { get; set; }
        public string History { get; set; }
        public string EcrPlmId { get; set; }
        public string ObjectPlmId { get; set; }
        public string PreviousPlmId { get; set; }
        public DateTime FeedbackDate { get; set; }
        public string RcdFeedback { get; set; }
        public string RcdName { get; set; }
        public string TaskJustification { get; set; }
        public string JustificationComment { get; set; }
        public bool ToKill { get; set; }
        public string DecPsa { get; set; }
        public string AffectedTo { get; set; }
        public string SelectedBusiness { get; set; }
        public string SelectedBomCommission { get; set; }
        public string DecPlmId { get; set; }
        public string LastTouch { get; set; }
        public DateTime CompletedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string ModifiedBy { get; set; }
        public string NewProductId { get; set; }
        public string MessageId { get; set; }
        public string CarriedDecPsa { get; set; }
        public string CarrierDecPsa { get; set; }
        public string CnxProjectName { get; set; }
        public string DReadEvent { get; set; }
        public string InterfaceId { get; set; }
        public bool IsArchived { get; set; }
        public bool IsEmbedded { get; set; }
        public string CompletedBy { get; set; }
        public bool ManagerCompletionApproved { get; set; }
        public bool RecentlyModifiedByRobot { get; set; }
        public string UserPlmId { get; set; }
        public string CicxSide { get; set; }
        public string EcoPlmId { get; set; }
        public DateTime RejectedAt { get; set; }
        public string RejectedBy { get; set; }
        public string RelatedCicx { get; set; }
        public bool SendMail { get; set; }
        public DateTime AlmostCompletedAt { get; set; }
        public string AlmostCompletedBy { get; set; }
        public string OddSituationReport { get; set; }
        public DateTime CancelledAt { get; set; }
        public bool IsFromFastenerWorkshop { get; set; }
    }
}
