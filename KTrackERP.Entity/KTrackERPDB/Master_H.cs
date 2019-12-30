using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("Master_H")]
    public class Master_H
    {
        [Key]
        public string prmtyp { get; set; }
        public string thdesc { get; set; }
        public string endesc { get; set; }
        public string remark { get; set; }
        public bool recsts { get; set; }
        public DateTime? upddte { get; set; }
        public string updby { get; set; }
        public DateTime? instdte { get; set; }
        public string instby { get; set; }

    }
}
