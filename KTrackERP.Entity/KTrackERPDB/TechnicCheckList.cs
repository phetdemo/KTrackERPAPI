using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("TechnicCheckList")]
    public class TechnicCheckList
    {
        [Key]
        public int CheckListID { get; set; }
        public int CarID { get; set; }
        public int? MOption { get; set; }
        public bool? Checked { get; set; }
        public string Remark { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }

    }
}
