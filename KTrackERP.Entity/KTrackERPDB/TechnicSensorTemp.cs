using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("TechnicSensorTemp")]
    public class TechnicSensorTemp
    {
        [Key]
        public int SensorTempID { get; set; }
        public int CarID { get; set; }
        public string SenSor1 { get; set; }
        public string Sensor2 { get; set; }
        public string Sensor3 { get; set; }
        public string Sensor4 { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }
    }
}
