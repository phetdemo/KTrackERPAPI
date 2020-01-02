using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("Master_D")]
    public class Master_D
    {
        [Key]
        public int prmid { get; set; }
        public string prmtyp { get; set; }
        public string prmcde { get; set; }
        public string thdesc { get; set; }
        public string endesc { get; set; }
        public string prmflag { get; set; }
        public string prmref { get; set; }
        public string remark { get; set; }
        public bool recsts { get; set; }
        public DateTime? upddte { get; set; }
        public string updby { get; set; }
        public DateTime? instdte { get; set; }
        public string instby { get; set; }

    }
}
