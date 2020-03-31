using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("DVRCamera")]
    public class DVRCamera
    {
        [Key]
        public int DVRCameraID { get; set; }
        public int? DVRID { get; set; }
        public int? MDVRDirectionID { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }

    }
}
