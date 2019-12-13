using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("M_DeviceType")]
    public class M_DeviceType
    {
        [Key]
        public int DeviceTypeID { get; set; }
        public string DeviceTypeCode { get; set; }
        public string DeviceTypeNameTH { get; set; }
        public string DeviceTypeNameEN { get; set; }
        public string Active { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }

    }
}
