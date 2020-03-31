using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("HardwareTestSensorTemp")]
    public class HardwareTestSensorTemp
    {
        [Key]
        public int HardwareTestSensorTempID { get; set; }
        public int? BoxID { get; set; }
        public bool? Sensor1 { get; set; }
        public bool? Sensor2 { get; set; }
        public bool? Sensor3 { get; set; }
        public bool? Sensor4 { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }

    }
}
