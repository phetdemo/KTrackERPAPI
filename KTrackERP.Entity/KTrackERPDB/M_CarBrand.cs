using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("M_CarBrand")]
    public class M_CarBrand
    {
        [Key]
        public int BrandID { get; set; }
        public string BrandNameEN { get; set; }
        public string BrandNameTH { get; set; }
        public string Active { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }

    }
}
