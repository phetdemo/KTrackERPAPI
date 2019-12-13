using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("M_JobType")]
    public class M_JobType
    {
        [Key]
        public int JobTypeID { get; set; }
        public string JobNameTH { get; set; }
        public string JobNameEN { get; set; }
        public string JobPreFix { get; set; }
        public string Active { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }

    }
}
