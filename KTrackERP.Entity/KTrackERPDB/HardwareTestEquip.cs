using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("HardwareTestEquip")]
    public class HardwareTestEquip
    {
        [Key]
        public int HardwareTestEquipID { get; set; }
        public int? BoxID { get; set; }
        public int? MELInternalID { get; set; }
        public bool? Tested { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }

    }
}
