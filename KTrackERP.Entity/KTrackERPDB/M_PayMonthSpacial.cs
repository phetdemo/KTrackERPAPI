using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("M_PayMonthSpacial")]
    public class M_PayMonthSpacial
    {
        [Key]
        public int PayMonthSpacialID { get; set; }
        public string PayMonthSpacialNameTH { get; set; }
        public string PayMonthSpacialNameEN { get; set; }
        public int AmountMounth { get; set; }
        public string Active { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }

    }
}
