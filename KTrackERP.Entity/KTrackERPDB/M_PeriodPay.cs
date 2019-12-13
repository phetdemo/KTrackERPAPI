using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("M_PeriodPay")]
    public class M_PeriodPay
    {
        [Key]
        public int PeriodPayID { get; set; }
        public string PeriodNameTH { get; set; }
        public string PeriodNameEN { get; set; }
        public string Active { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }

    }
}
