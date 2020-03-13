using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("OperationTest")]
    public class OperationTest
    {
        [Key]
        public int OperationID { get; set; }
        public long BoxDetailID { get; set; }        
        public bool? Tested { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }
        
    }
}
