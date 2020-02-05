using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("JobRequestClose")]
    public class JobRequestClose

    {
        [Key]
        public int JobRequestCloseID { get; set; }
        public int? JobRequestNoID { get; set; }
        public string JobRequestCloseNo { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTel { get; set; }
        public string ContactMobile { get; set; }
        public string ContactFax { get; set; }
        public string Location { get; set; }
        public string Remark { get; set; }
        public string TaxID { get; set; }
        public string DocDeliverAddress { get; set; }
        public DateTime? serviceChargePMonthStartDate { get; set; }
        public DateTime? serviceChargePYearStartDate { get; set; }
        public DateTime? serviceChargeNextDate { get; set; }
        public DateTime? serviceChargeRentStartDate { get; set; }
        public int? AmountMounth { get; set; }
        public string ApproveBy { get; set; }
        public DateTime? ApproveDateTime { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }

        [NotMapped]
        public List<Box> Box { get; set; }
        [NotMapped]
        public List<Car> Car { get; set; }
        [NotMapped]
        public List<InstallMent> InstallMent { get; set; }
        [NotMapped]
        public List<ServiceCharge> ServiceCharge { get; set; }


    }
}
