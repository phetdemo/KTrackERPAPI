using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTrackERP.Entity.KTrackERPDB
{
    [Table("M_Employee")]
    public class M_Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string FirstNameTH { get; set; }
        public string FirstNameEN { get; set; }
        public string LastNameTH { get; set; }
        public string LastNameEN { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public int? PositionID { get; set; }
        public int? DivisionID { get; set; }
        public string Active { get; set; }
        public DateTime? InsDateTime { get; set; }
        public string InsBy { get; set; }
        public DateTime? UpdDateTime { get; set; }
        public string UpdBy { get; set; }

    }
}
