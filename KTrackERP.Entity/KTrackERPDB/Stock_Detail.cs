using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("Stock_Detail")]
    public class Stock_Detail
    {
        [Key]
        public int StockDetailID { get; set; }
        public int StockID { get; set; }
        public int DeviceID { get; set; }
        public int AccessoriesID { get; set; }
        public int UnitID { get; set; }
        public decimal? Quantity { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }

    }
}
