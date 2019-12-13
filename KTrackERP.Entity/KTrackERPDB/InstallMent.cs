using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("InstallMent")]
    public class InstallMent
    {
        [Key]
        public int InstallMentID { get; set; }
        public int? JobRequestCloseID { get; set; }
        public int? Seq { get; set; }
        public decimal Price { get; set; }
        public DateTime? PayDate { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }

    }
}
