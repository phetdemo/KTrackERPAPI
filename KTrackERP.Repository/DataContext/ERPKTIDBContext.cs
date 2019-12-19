
using KTrackERP.Entity;
using KTrackERP.Entity.KTrackERPDB;
using System.Data.Entity;

namespace KTrackERP.Repository
{
    public class ERPKTIDBContext : DbContext
    {
        public ERPKTIDBContext() : base("name=ERPKTIDBContext")
        {
            Database.SetInitializer<ERPKTIDBContext>(null);
        }
        public DbSet<Box> Box { get; set; }
        public DbSet<BoxDetail> BoxDetail { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<File> File { get; set; }
        public DbSet<InstallMent> InstallMent { get; set; }
        public DbSet<JobRequest> JobRequest { get; set; }

        public DbSet<JobRequestClose> JobRequestClose { get; set; }
        public DbSet<M_Accessories> M_Accessories { get; set; }
        public DbSet<M_AmoutBattery> M_AmoutBattery { get; set; }
        public DbSet<M_CameraType> M_CameraType { get; set; }
        public DbSet<M_CarBrand> M_CarBrand { get; set; }
        public DbSet<M_CarRegisterType> M_CarRegisterType { get; set; }
        public DbSet<M_Device> M_Device { get; set; }
        public DbSet<M_DeviceType> M_DeviceType { get; set; }
        public DbSet<M_Employee> M_Employee { get; set; }
        public DbSet<M_FirmWare> M_FirmWare { get; set; }
        public DbSet<M_JobStatus> M_JobStatus { get; set; }
        public DbSet<M_JobType> M_JobType { get; set; }
        public DbSet<M_LicenceDriveType> M_LicenceDriveType { get; set; }
        public DbSet<M_LimitSpeed> M_LimitSpeed { get; set; }
        public DbSet<M_Option> M_Option { get; set; }
        public DbSet<M_PayBill> M_PayBill { get; set; }
        public DbSet<M_PayMonthSpacial> M_PayMonthSpacial { get; set; }
        public DbSet<M_PeriodPay> M_PeriodPay { get; set; }
        public DbSet<M_Position> M_Position { get; set; }
        public DbSet<M_RentType> M_RentType { get; set; }
        public DbSet<M_ServiceCharge> M_ServiceCharge { get; set; }
        public DbSet<M_SimType> M_SimType { get; set; }
        public DbSet<M_SoundAlert> M_SoundAlert { get; set; }
        public DbSet<M_TimeSendData> M_TimeSendData { get; set; }
        public DbSet<M_TypeStock> M_TypeStock { get; set; }
        public DbSet<M_Unit> M_Unit { get; set; }

        public DbSet<M_WareHouse> M_WareHouse { get; set; }
        public DbSet<ServiceCharge> ServiceCharge { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<Stock_Detail> Stock_Detail { get; set; }

        public DbSet<Master_D> Master_D { get; set; }
        public DbSet<Master_H> Master_H { get; set; }




    }
}
