using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("Car")]
    public class Car
    {
        [Key]
        public int CarID { get; set; }
        public int? JobRequestNoID { get; set; }
        public string LicensePlate { get; set; }
        public int? BrandID { get; set; }
        public int? CarTypeID { get; set; }
        public int? LicenceDriveTypeID { get; set; }
        public string Chassis { get; set; }
        public int? Wheel { get; set; }
        public int? Shaft { get; set; }
        public int? Tire { get; set; }
        public string NewLicensePlate { get; set; }
        public int? NewBrandID { get; set; }
        public int? NewCarTypeID { get; set; }
        public string NewChassis { get; set; }
        public string ServiceReportBookNo { get; set; }
        public string ServiceRportNo { get; set; }
        public string NewServiceReportBookNo { get; set; }
        public string NewServiceRportNo { get; set; }
        public string Remark { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }

    }
}
