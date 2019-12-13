using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("M_ServiceCharge")]
    public class M_ServiceCharge
    {
        [Key]
        public int ServiceChargeID { get; set; }
        public string ServiceChargeNameTH { get; set; }
        public string ServiceChargeNameEN { get; set; }
        public string Active { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }

    }
}
