using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("HardwareTest")]
    public class HardwareTest
    {
        [Key]
        public int HardwareTestID { get; set; }
        public int BoxID { get; set; }
        public int? MOptionID { get; set; }
        public bool? Tested { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }
    }
}
