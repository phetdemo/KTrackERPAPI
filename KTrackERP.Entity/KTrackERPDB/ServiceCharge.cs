using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("ServiceCharge")]
    public class ServiceCharge
    {
        [Key]
        public int ServiceID { get; set; }
        public int JobRequestCloseID { get; set; }
        public int ServiceChargeID { get; set; }
        public int Seq { get; set; }
        public int OptionID { get; set; }
        public decimal? Price { get; set; }
        public decimal? VatPrice { get; set; }
        public decimal? TotalPricee { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }

    }
}
