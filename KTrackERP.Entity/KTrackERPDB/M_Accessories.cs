using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("M_Accessories")]
    public class M_Accessories
    {
        [Key]
        public int AccessoriesID { get; set; }
        public string AccessoriesNameTH { get; set; }
        public string AccessoriesNameEN { get; set; }
        public string Active { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }


    }
}
