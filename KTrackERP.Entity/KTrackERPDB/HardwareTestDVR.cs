using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("HardwareTestDVR")]
    public class HardwareTestDVR
    {
        [Key]
        public int HardwareDVRID { get; set; }
        public int CameraID { get; set; }
        public bool? Tested { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }
    }
}
