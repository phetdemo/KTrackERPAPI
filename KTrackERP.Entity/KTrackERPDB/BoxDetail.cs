using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("BoxDetail")]
    public class BoxDetail
    {
        [Key]
        public long BoxDetailID { get; set; }
        public int? JobRequestNoID { get; set; }
        public int? BoxID { get; set; }
        public int? MOptionID { get; set; }
        public int? MCameraTypeID { get; set; }
        public string OptionValue { get; set; }
        public bool Selected { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }
        [NotMapped]
        public string LicensePlate { get; set; }

    }
}
