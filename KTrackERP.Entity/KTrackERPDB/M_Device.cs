using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("M_Device")]
    public class M_Device
    {
        [Key]
        public int DeviceID { get; set; }
        public int DeviceTypeID { get; set; }
        public string DeviceCode { get; set; }
        public string DeviceNameTH { get; set; }
        public string DeviceNameEN { get; set; }
        public string Model { get; set; }
        public string Active { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }

    }
}
