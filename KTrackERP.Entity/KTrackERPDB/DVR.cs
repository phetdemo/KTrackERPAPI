using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("DVR")]
    public class DVR
    {
        [Key]
        public int DVRID { get; set; }
        public int? JobRequestNoID { get; set; }
        public int? CarID { get; set; }
        public int? DVRType { get; set; }
        public int? DVRModel { get; set; }
        public string ID { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }

    }
}
