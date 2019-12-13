using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("M_CameraType")]
    public class M_CameraType
    {
        [Key]
        public int CameraTypeID { get; set; }
        public string CameraTypeCode { get; set; }
        public string CameraNameTH { get; set; }
        public string CameraNameEN { get; set; }
        public string Active { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }

    }
}
