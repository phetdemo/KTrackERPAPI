using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("HStock")]
    public class HStock
    {
        [Key]
        public int HstockID { get; set; }
        public int EmployeeID { get; set; }
        public string Hcustomer { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }

        [NotMapped]
        public List<HStockDetail> HStockDetail { get; set; }
    }
}
