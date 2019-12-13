using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity
{
    [Table("Box")]
    public class Box
    {
        [Key]
        public int BoxID { get; set; }
        public int? CarID { get; set; }
        public int? DeviceID { get; set; }
        public int? SimTypeID { get; set; }
        public int? FirmWstringareID { get; set; }
        public int? TimeSendDataID { get; set; }
        public int? ElectricVoltID { get; set; }
        public int? BatteryID { get; set; }
        public int? LimitSpeedID { get; set; }
        public int? SoundAlertID { get; set; }
        public string SerialNumber { get; set; }
        public string SerialDVRNumber { get; set; }
        public int? AmountCameraDVR { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? VID { get; set; }
        public int? Port { get; set; }
        public int? IP { get; set; }
        public int? APN { get; set; }
        public DateTime? warrantydateStart { get; set; }
        public DateTime? warrantydateEnd { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }


























    }
}
