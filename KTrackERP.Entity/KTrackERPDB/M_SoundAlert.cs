using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("M_SoundAlert")]
    public class M_SoundAlert
    {
        [Key]
        public int SoundAlertID { get; set; }
        public string SoundNameTH { get; set; }
        public string SoundNameEN { get; set; }
        public string Active { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }

    }
}
