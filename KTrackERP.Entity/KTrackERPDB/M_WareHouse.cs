using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("M_WareHouse")]
    public class M_WareHouse
    {
        [Key]
        public int WareHouseID { get; set; }
        public string WareHouseCode { get; set; }
        public string WareHouseNameTH { get; set; }
        public string WareHouseNameEN { get; set; }
        public string Active { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }

    }
}
