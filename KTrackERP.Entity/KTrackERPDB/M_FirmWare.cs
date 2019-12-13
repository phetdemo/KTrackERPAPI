using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("M_FirmWare")]
    public class M_FirmWare
    {
        [Key]
        public int FirmWareID { get; set; }
        public string FirmWareCode { get; set; }
        public string FirmWareVersion { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }

    }
}
