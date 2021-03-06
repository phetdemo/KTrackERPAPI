﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("JobRequest")]
    public class JobRequest
    {
        [Key]
        public int JobRequestNoID { get; set; }
        public string JobRequestNo { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTel { get; set; }
        public string ContactMobile { get; set; }
        public string ContactFax { get; set; }
        public string Location { get; set; }
        public string Remark { get; set; }
        public DateTime? ProcessDateTime { get; set; }
        public string OtherDetail { get; set; }
        public int? JobRequestType { get; set; }
        public int? RentTypeID { get; set; }
        public DateTime? StartContactDate { get; set; }
        public DateTime? EndContactDate { get; set; }
        public DateTime? AppointmentDateTime { get; set; }
        public string AppointmentDetail { get; set; }
        public bool CustomerSupportFlag { get; set; }
        public bool HardWareFlag { get; set; }
        public bool SoftWareFlag { get; set; }
        public bool AccountFlag { get; set; }
        public int? SaleID { get; set; }
        public bool CostFlag { get; set; }
        public bool CostOtherFlag { get; set; }
        public decimal? CostOtherDetail { get; set; }
        public int? SaleCoordinatorID { get; set; }
        public string Informer { get; set; }
        public int? JobStatus { get; set; }
        public string ApproveBy { get; set; }
        public DateTime? ApproveDateTime { get; set; }
        public string JobRef { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }


        [NotMapped]
        public List<Car> Car { get; set; }
        [NotMapped]
        public List<Box> Box { get; set; }
        [NotMapped]
        public List<BoxDetail> BoxDetail { get; set; }
        [NotMapped]
        public List<OperationTest> OperationTest { get; set; }
        [NotMapped]
        public List<TechnicCheckList> TechnicCheckList { get; set; }
        [NotMapped]
        public List<TechnicDVR> TechnicDVR { get; set; }
        [NotMapped]
        public List<TechnicELSys> TechnicELSys { get; set; }
        [NotMapped]
        public List<TechnicELSysEquip> TechnicELSysEquip { get; set; }

        [NotMapped]
        public List<TechnicSensorTemp> TechnicSensorTemp { get; set; }
        [NotMapped]
        public List<HardwareTest> HardwareTest { get; set; }
        [NotMapped]
        public List<HardwareTestDVR> HardwareTestDVR { get; set; }
        [NotMapped]
        public List<HardwareTestEquip> HardwareTestEquip { get; set; }
        [NotMapped]
        public List<HardwareTestSensorTemp> HardwareTestSensorTemp { get; set; }

        [NotMapped]
        public string BoxIDs { get; set; }
        [NotMapped]
        public string CarIDs { get; set; }

    }
}
