using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("TechnicELSys")]
    public class TechnicELSys
    {
        [Key]
        public int ELSysID { get; set; }
        public int CarID { get; set; }
        public int? MELCut { get; set; }
        public int? DCPowerBeforStart { get; set; }
        public int? DCPowerWhileStart { get; set; }
        public int? DCPowerAfterStart { get; set; }
        public int? OnEngineOnBeforStart { get; set; }
        public int? OnEngineOnWhileStart { get; set; }
        public int? OnEngineOnAfterStart { get; set; }
        public int? GroudBeforStart { get; set; }
        public int? GroudWhileStart { get; set; }
        public int? GroudAfterStart { get; set; }
        public int? TankFuleStand { get; set; }
        public int? TankFuleModify { get; set; }
        public int? TankStandAnalog { get; set; }
        public int? TankMofifyAnalog { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }
    }
}
