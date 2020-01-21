using KTrackERP.Entity;
using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class JobRequestRepository : IJobRequestRepository
    {
        private readonly ERPKTIDBContext context;

        public JobRequestRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<JobRequest> Get()
        {
            throw new NotImplementedException();
        }

        public object GetById(int id)
        {
            try
            {
                var jobreq = (from m in context.JobRequest
                              where m.JobRequestNoID == id
                              select new
                              {
                                  m.JobRequestNoID,
                                  m.JobRequestNo,
                                  m.CompanyName,
                                  m.ContactName,
                                  m.ContactTel,
                                  m.ContactMobile,
                                  m.ContactFax,
                                  m.Location,
                                  m.Remark,
                                  m.ProcessDateTime,
                                  m.OtherDetail,
                                  m.JobRequestType,
                                  m.RentTypeID,
                                  m.StartContactDate,
                                  m.EndContactDate,
                                  m.AppointmentDateTime,
                                  m.AppointmentDetail,
                                  m.CustomerSupportFlag,
                                  m.HardWareFlag,
                                  m.SoftWareFlag,
                                  m.AccountFlag,
                                  m.SaleID,
                                  m.CostFlag,
                                  m.CostOtherFlag,
                                  m.CostOtherDetail,
                                  m.SaleCoordinatorID,
                                  m.Informer,
                                  m.JobStatus,
                                  m.ApproveBy,
                                  m.ApproveDateTime,
                                  m.JobRef,
                                  m.InsDateTime,
                                  m.InsBy,
                                  m.UpdDateTime,
                                  m.UpdBy
                              }
                               ).FirstOrDefault();
                return new { jobreq };

            }
            catch (Exception ex)
            {
                var joke = ex.Message;
                return null;
            }
        }

        public bool Insert(JobRequest model)
        {
            using (var dbTransaction = context.Database.BeginTransaction())
            {
                try
                {
                    if (model != null)
                    {

                        var update = context.JobRequest.Where(x => x.JobRequestNoID == model.JobRequestNoID).FirstOrDefault();

                        if (update != null)
                        {
                            update.AccountFlag = model.AccountFlag;
                            update.AppointmentDateTime = model.AppointmentDateTime;
                            update.AppointmentDetail = model.AppointmentDetail;
                            update.CompanyName = model.CompanyName;
                            update.ContactFax = model.ContactFax;
                            update.ContactMobile = model.ContactMobile;
                            update.ContactName = model.ContactName;
                            update.ContactTel = model.ContactTel;
                            update.CostFlag = model.CostFlag;
                            update.CostOtherDetail = model.CostOtherDetail;
                            update.CostOtherFlag = model.CostOtherFlag;
                            update.CustomerSupportFlag = model.CustomerSupportFlag;
                            update.EndContactDate = model.EndContactDate;
                            update.HardWareFlag = model.HardWareFlag;
                            update.JobRef = model.JobRef;
                            update.JobRequestNo = model.JobRequestNo;
                            update.JobRequestType = model.JobRequestType;
                            update.JobStatus = model.JobStatus;
                            update.Location = model.Location;
                            update.OtherDetail = model.OtherDetail;
                            update.ProcessDateTime = model.ProcessDateTime;
                            update.Remark = model.Remark;
                            update.RentTypeID = model.RentTypeID;
                            update.SaleCoordinatorID = model.SaleCoordinatorID;
                            update.Informer = model.Informer;
                            update.SaleID = model.SaleID;
                            update.SoftWareFlag = model.SoftWareFlag;
                            update.StartContactDate = model.StartContactDate;
                            update.UpdBy = model.UpdBy;
                            update.UpdDateTime = DateTime.Now;

                            foreach (Car item in model.Car)
                            {
                                var updatecar = context.Car.Where(x => x.CarID == item.CarID).FirstOrDefault();
                                if (update != null)
                                {
                                    updatecar.CarID = item.CarID;
                                    updatecar.CarTypeID = item.CarTypeID;
                                    updatecar.Chassis = item.Chassis;
                                    updatecar.JobRequestNoID = item.JobRequestNoID;
                                    updatecar.LicenceDriveTypeID = item.LicenceDriveTypeID;
                                    updatecar.LicensePlate = item.LicensePlate;
                                    updatecar.Remark = item.Remark;
                                    updatecar.Shaft = item.Shaft;
                                    updatecar.Tire = item.Tire;
                                    updatecar.UpdBy = item.UpdBy;
                                    updatecar.UpdDateTime = DateTime.Now;
                                    updatecar.Wheel = item.Wheel;
                                }
                            }
                            foreach (Box item in model.Box)
                            {
                                var updatebox = context.Box.Where(x => x.BoxID == item.BoxID).FirstOrDefault();
                                if (updatebox != null)
                                {
                                    updatebox.AmountCameraDVR = item.AmountCameraDVR;
                                    updatebox.APN = item.APN;
                                    updatebox.BatteryID = item.BatteryID;
                                    updatebox.CarID = item.CarID;
                                    updatebox.DeviceID = item.DeviceID;
                                    updatebox.ElectricVoltID = item.ElectricVoltID;
                                    updatebox.FirmWareID = item.FirmWareID;
                                    updatebox.IP = item.IP;
                                    updatebox.LimitSpeedID = item.LimitSpeedID;
                                    updatebox.Password = item.Password;
                                    updatebox.Port = item.Port;
                                    updatebox.SerialDVRNumber = item.SerialDVRNumber;
                                    updatebox.SerialNumber = item.SerialNumber;
                                    updatebox.SimTypeID = item.SimTypeID;
                                    updatebox.SoundAlertID = item.SoundAlertID;
                                    updatebox.TimeSendDataID = item.TimeSendDataID;
                                    updatebox.UpdBy = item.UpdBy;
                                    updatebox.UpdDateTime = DateTime.Now;
                                    updatebox.Username = item.Username;
                                    updatebox.VID = item.VID;
                                    updatebox.warrantydateEnd = item.warrantydateEnd;
                                    updatebox.warrantydateStart = item.warrantydateStart;
                                }
                            }
                        }
                        else
                        {
                            model.InsDateTime = DateTime.Now;
                            context.JobRequest.Add(model);

                            for (int i = 0; i < model.Car.Count; i++)
                            {
                                model.Car[i].InsDateTime = DateTime.Now;
                                context.Car.Add(model.Car[i]);
                            }
                            for (int i = 0; i < model.Box.Count; i++)
                            {
                                model.Box[i].InsDateTime = DateTime.Now;
                                context.Box.Add(model.Box[i]);
                            }
                        }
                        context.SaveChanges();
                        dbTransaction.Commit();
                    }
                }
                catch (Exception e)
                {
                    var joke = e.Message.ToString();
                    dbTransaction.Rollback();
                    return false;
                }
            }
            return true;
        }
        public object GetJobWorkList(int jobstatusID)
        {
            var jobreq = from job in context.JobRequest
                         join jobtype in context.Master_D on job.JobRequestType equals jobtype.prmid into asjobtype
                         join jobstatus in context.Master_D on job.JobStatus equals jobstatus.prmid into asjobstatus
                         from jobtype in asjobtype.DefaultIfEmpty()
                         from jobstatus in asjobstatus.DefaultIfEmpty()
                         where job.JobStatus == jobstatusID
                         select new
                         {
                             job.JobRequestNoID,
                             job.JobRequestNo,
                             job.CompanyName,
                             job.InsBy,
                             jobstatusth = jobstatus.thdesc,
                             jobtypeth = jobtype.thdesc
                         };


            return jobreq;
        }

        public bool Update(int id, JobRequest model)
        {
            throw new NotImplementedException();
        }
    }
}
