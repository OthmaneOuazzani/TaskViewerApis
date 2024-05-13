using System.ComponentModel.DataAnnotations;

namespace TaskViewerApis.Models
{
    public class Message
    {
        [Key]
        public string PLMID { get; set; }
        public string LASTTOUCH { get; set; }
        public bool TOKILL { get; set; }
        public string OBJECTPLMID { get; set; }
        public string OBJECTTYPE { get; set; }
        public string MESSAGETXT { get; set; }
        public string MESSAGECOLOR { get; set; }
        public string MESSAGETYPE { get; set; }
        public string MESSAGETYPE2 { get; set; }
        public string WRITTENBY { get; set; }
        public string MESSAGEDESTINATION { get; set; }
        public string TITLE { get; set; }
        public DateTime CREATEDAT { get; set; }
        public DateTime MODIFIEDAT { get; set; }
        public int PICTURECOUNT { get; set; }
        public string READBY { get; set; }
        public string PROJECTNAME { get; set; }
        public int TWEETLENMAX { get; set; }
        public string LASTMESSAGE { get; set; }
        public DateTime LOCKDATE { get; set; }
        public string LOCKFLAG { get; set; }
        public string LOCKUSER { get; set; }
        public DateTime CANCELLEDAT { get; set; }
    }
}
