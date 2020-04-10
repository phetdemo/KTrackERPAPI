using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("Stock")]
    public class Stock
    {
        [Key]
        public int StockID { get; set; }
        public int SupplierID { get; set; }
        public int TypeStockID { get; set; }
        public string StockBy { get; set; }
        public DateTime? StockDate { get; set; }
        public string Remark { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }

    }
}
