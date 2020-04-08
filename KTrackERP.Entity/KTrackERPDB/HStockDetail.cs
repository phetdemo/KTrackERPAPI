using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("HStockDetail")]
    public class HStockDetail
    {
        [Key]
        public int ManageDetailID { get; set; }
        public int HstockID { get; set; }
        public int? MOptionID { get; set; }
        public string OptionValue { get; set; }
        public Boolean? Selected { get; set; }
        public int? Qtystock { get; set; }
        public string Remark { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }

    }
}
