using System.ComponentModel.DataAnnotations;

namespace TaskViewerApis.Models
{
    public class Pref
    {
        [Key]
        public string PlmId { get; set; }
        public bool Tokill { get; set; }
        public string LockFlag { get; set; }
        public DateTime LockDate { get; set; }
        public string LockUser { get; set; }
        public string RefPsa { get; set; }
        public string PdefPlmId { get; set; }
        public bool IsNeutral { get; set; }
        public bool IsColored { get; set; }
        public string ObjectId { get; set; }
        public string Description { get; set; }
        public string Designation { get; set; }
        public string PartnersRef { get; set; }
        public string NeutralPlmId { get; set; }
        public string ColorCode3 { get; set; }
        public string ColorCode2 { get; set; }
        public string ColorDesignation { get; set; }
        public string ColorReference { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime CancelledAt { get; set; }
        public string RefPsaRev { get; set; }
        public string DecPsaList { get; set; }
    }
}
