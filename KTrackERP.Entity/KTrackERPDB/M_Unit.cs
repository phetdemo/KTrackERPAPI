using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("M_Unit")]
    public class M_Unit
    {
        [Key]
        public int UnitID { get; set; }
        public string UnitCode { get; set; }
        public string UnitNameTH { get; set; }
        public string UnitNameEN { get; set; }
        public string Active { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }

    }
}
