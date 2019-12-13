using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("M_CarRegisterType")]
    public class M_CarRegisterType
    {
        [Key]
        public int CarTypeID { get; set; }
        public string CarTypeNameTH { get; set; }
        public string CarTypeNameEN { get; set; }
        public string Active { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }

    }
}
