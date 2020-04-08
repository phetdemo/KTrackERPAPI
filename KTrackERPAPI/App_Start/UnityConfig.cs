using KTrackERP.Repository.ERPKTIDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service;
using KTrackERP.Service.Interface;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace KTrackERPAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IBoxService, BoxService>();
            container.RegisterType<IBoxRepository, BoxRepository>();

            container.RegisterType<IBoxDetailService, BoxDetailService>();
            container.RegisterType<IBoxDetailRepository, BoxDetailRopository>();

            container.RegisterType<ICarService, CarService>();
            container.RegisterType<ICarRepository, CarRepository>();

            container.RegisterType<IFileService, FileService>();
            container.RegisterType<IFileRepository, FileRepository>();

            container.RegisterType<IInstallMentService, InstallMentService>();
            container.RegisterType<IInstallMentRepository, InstallMentRepository>();

            container.RegisterType<IJobRequestService, JobRequestService>();
            container.RegisterType<IJobRequestRepository, JobRequestRepository>();

            container.RegisterType<IJobRequestCloseService, JobRequestCloseService>();
            container.RegisterType<IJobRequestCloseRepository, JobRequestCloseRepository>();

            container.RegisterType<IM_AccessoriesService, M_AccessoriesService>();
            container.RegisterType<IM_AccessoriesRepository, M_AccessoriesRepository>();

            container.RegisterType<IM_AmountBatteryService, M_AmountBatteryService>();
            container.RegisterType<IM_AmountBatteryRepository, M_AmoutBatteryRepository>();

            container.RegisterType<IM_CameraTypeService, M_CameraTypeService>();
            container.RegisterType<IM_CameraTypeRepository, M_CameraTypeRepository>();

            container.RegisterType<IM_CarBrandService, M_CarBrandService>();
            container.RegisterType<IM_CarBrandRepository, M_CarBrandRepository>();

            container.RegisterType<IM_CarRegisterTypeService, M_CarRegisterTypeService>();
            container.RegisterType<IM_CarRegisterTypeRepository, M_CarRegisterTypeRepository>();

            container.RegisterType<IM_DeviceService, M_DeviceService>();
            container.RegisterType<IM_DeviceRepository, M_DeviceRepository>();

            container.RegisterType<IM_DeviceTypeService, M_DeviceTypeService>();
            container.RegisterType<IM_DeviceTypeRepository, M_DeviceTypeRepository>();

            container.RegisterType<IM_EmployeeService, M_EmployeeService>();
            container.RegisterType<IM_EmployeeRepository, M_EmployeeRepository>();

            container.RegisterType<IM_FirmWareService, M_FirmWareService>();
            container.RegisterType<IM_FirmWareRepository, M_FirmWareRepository>();

            container.RegisterType<IM_JobStatusService, M_JobStatusService>();
            container.RegisterType<IM_JobStatusRepository, M_JobStatusRepository>();

            container.RegisterType<IM_JobTypeService, M_JobTypeService>();
            container.RegisterType<IM_JobTypeRepository, M_JobTypeRepository>();

            container.RegisterType<IM_LicenceDriveTypeService, M_LicenceDriveTypeService>();
            container.RegisterType<IM_LicenceDriveTypeRepository, M_LicenceDriveTypeRepository>();

            container.RegisterType<IM_LimitSpeedService, M_LimitSpeedService>();
            container.RegisterType<IM_LimitSpeedRepository, M_LimitSpeedRepository>();

            container.RegisterType<IM_OptionService, M_OptionService>();
            container.RegisterType<IM_OptionRepository, M_OptionRepository>();

            container.RegisterType<IM_PayBillService, M_PayBillService>();
            container.RegisterType<IM_PayBillRepository, M_PayBillRepository>();

            container.RegisterType<IM_PayMonthSpacialService, M_PayMonthSpacialService>();
            container.RegisterType<IM_PayMonthSpacialRepository, M_PayMonthSpecialRepository>();

            container.RegisterType<IM_PeriodPayService, M_PeriodPayService>();
            container.RegisterType<IM_PeriodPayRepository, M_PeriodPayRepository>();

            container.RegisterType<IM_PositionService, M_PositionService>();
            container.RegisterType<IM_PositionRepository, M_PositionRepository>();

            container.RegisterType<IM_RentTypeService, M_RentTypeService>();
            container.RegisterType<IM_RentTypeRepository, M_RentTypeRepository>();

            container.RegisterType<IM_ServiceChargeService, M_ServiceChargeService>();
            container.RegisterType<IM_ServiceChargeRepository, M_ServiceChargeRepository>();

            container.RegisterType<IM_SimTypeService, M_SimTypeService>();
            container.RegisterType<IM_SimTypeRepository, M_SimTypeRepository>();

            container.RegisterType<IM_SoundAlertService, M_SoundAlertService>();
            container.RegisterType<IM_SoundAlertRepository, M_SoundAlertRepository>();

            container.RegisterType<IM_TimeSendDataService, M_TimeSendDataService>();
            container.RegisterType<IM_TimeSendDataRepository, M_TimeSendDataRepository>();

            container.RegisterType<IM_TypeStockService, M_TypeStockService>();
            container.RegisterType<IM_TypeStockRepository, M_TypeStockRepository>();

            container.RegisterType<IM_UnitService, M_UnitService>();
            container.RegisterType<IM_UnitRepository, M_UnitRepository>();

            container.RegisterType<IM_WareHouseService, M_WareHouseService>();
            container.RegisterType<IM_WareHouseRepository, M_WareHouseRepository>();

            container.RegisterType<IServiceChargeService, ServiceChargeService>();
            container.RegisterType<IServiceChargeRepository, ServiceChargeRepository>();

            container.RegisterType<IStockService, StockService>();
            container.RegisterType<IStockRepository, StockRepository>();

            container.RegisterType<IStockDetailService, StockDetailService>();
            container.RegisterType<IStockDetailRepository, Stock_DetailRepository>();

            container.RegisterType<IMaster_DService, Master_DService>();
            container.RegisterType<IMaster_DRepository, Master_D>();

            container.RegisterType<IMaster_HService, Master_HService>();
            container.RegisterType<IMaster_HRepository, Master_H>();

            container.RegisterType<IHStockService, HStockService>();
            container.RegisterType<IHStockRepository, HStockRepository>();

            container.RegisterType<IHStockDetailRepository, HStockDetailRepository>();
            container.RegisterType<IHStockDetailService, HStockDetailService>();



            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}