using KTrackERP.Entity;
using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class JobRequestCloseRepository : IJobRequestCloseRepository
    {
        private readonly ERPKTIDBContext context;

        public JobRequestCloseRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<JobRequestClose> Get()
        {
            throw new NotImplementedException();
        }

        public object GetById(int id)
        {
            try
            {
                var jobreqc = (from m in context.JobRequestClose
                               where m.JobRequestCloseID == id
                               select new
                               {
                                   m.JobRequestCloseID,
                                   m.JobRequestNoID,
                                   m.CompanyName,
                                   m.ContactName,
                                   m.ContactTel,
                                   m.ContactMobile,
                                   m.ContactFax,
                                   m.Location,
                                   m.Remark,
                                   m.TaxID,
                                   m.DocDeliverAddress,
                                   m.serviceChargePMonthStartDate,
                                   m.serviceChargePYearStartDate,
                                   m.serviceChargeNextDate,
                                   m.serviceChargeRentStartDate,
                                   m.AmountMounth,
                                   m.ApproveBy,
                                   m.ApproveDateTime,
                                   m.InsDateTime,
                                   m.InsBy,
                                   m.UpdDateTime,
                                   m.UpdBy
                               }
                               ).FirstOrDefault();
                var box = (from boxs in context.Box
                           join cars in context.Car on boxs.CarID equals cars.CarID into ascars
                           join simtype in context.Master_D on boxs.SimTypeID equals simtype.prmid into assimtype
                           join device in context.Master_D on boxs.DeviceID equals device.prmid into asdevice
                           from cars in ascars.DefaultIfEmpty()
                           from simtype in assimtype.DefaultIfEmpty()
                           from device in asdevice.DefaultIfEmpty()
                           where boxs.JobRequestNoID == id
                           select new
                           {
                               boxs.BoxID,
                               boxs.JobRequestNoID,
                               boxs.CarID,
                               boxs.DeviceID,
                               boxs.SimTypeID,
                               boxs.FirmWareID,
                               boxs.TimeSendDataID,
                               boxs.ElectricVoltID,
                               boxs.BatteryID,
                               boxs.LimitSpeedID,
                               boxs.SoundAlertID,
                               boxs.SerialNumber,
                               boxs.SerialDVRNumber,
                               boxs.AmountCameraDVR,
                               boxs.Username,
                               boxs.Password,
                               boxs.VID,
                               boxs.Port,
                               boxs.IP,
                               boxs.APN,
                               boxs.warrantydateStart,
                               boxs.warrantydateEnd,
                               boxs.InsDateTime,
                               boxs.InsBy,
                               boxs.UpdDateTime,
                               boxs.UpdBy,
                               LicensePlateName = cars.LicensePlate,
                               DeviceName = device.thdesc,
                               SimTypeName = simtype.thdesc
                           }).ToList();
                var installments = (from i in context.InstallMent
                                    where i.JobRequestCloseID == id
                                    select new
                                    {
                                        i.InstallMentID,
                                        i.JobRequestCloseID,
                                        i.Seq,
                                        i.Price,
                                        i.PayDate,
                                        i.InsDateTime,
                                        i.InsBy,
                                        i.UpdDateTime,
                                        i.UpdBy
                                    }).ToList();
                var car = (from c in context.Car
                           where c.JobRequestNoID == jobreqc.JobRequestNoID
                           select new
                           {
                               c.CarID,
                               c.JobRequestNoID,
                               c.LicensePlate,
                               c.BrandID,
                               c.CarTypeID,
                               c.LicenceDriveTypeID,
                               c.Chassis,
                               c.Wheel,
                               c.Shaft,
                               c.Tire,
                               c.NewLicensePlate,
                               c.NewBrandID,
                               c.NewCarTypeID,
                               c.NewChassis,
                               c.ServiceReportBookNo,
                               c.ServiceRportNo,
                               c.NewServiceReportBookNo,
                               c.NewServiceRportNo,
                               c.Remark,
                               c.InsDateTime,
                               c.InsBy,
                               c.UpdDateTime,
                               c.UpdBy,
                           })
                           .ToList();
                var service = (from s in context.ServiceCharge
                               join m in context.Master_D on s.ServiceChargeID equals m.prmid into asm
                               from m in asm.DefaultIfEmpty()
                               where s.JobRequestCloseID == jobreqc.JobRequestCloseID
                               select new
                               {
                                   s.ServiceID,
                                   s.JobRequestCloseID,
                                   s.ServiceChargeID,
                                   s.Seq,
                                   s.OptionID,
                                   s.Price,
                                   s.VatPrice,
                                   s.TotalPricee,
                                   s.InsDateTime,
                                   s.InsBy,
                                   s.UpdDateTime,
                                   s.UpdBy,
                                   ServiceChargeName = m.thdesc

                               }
                               ).ToList();

                return new { jobreqc, installments, car, service, box };
            }
            catch (Exception ex)
            {
                var joke = ex.Message;
                return null;
            }
        }
        public object GetJobRequestInformationByJobReqID(int id)
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
        public object GetCarAndBoxByJobReqByID(int id)
        {
            try
            {
                var car = (from c in context.Car
                           where c.JobRequestNoID == id
                           select new
                           {
                               c.CarID,
                               c.JobRequestNoID,
                               c.LicensePlate,
                               c.BrandID,
                               c.CarTypeID,
                               c.LicenceDriveTypeID,
                               c.Chassis,
                               c.Wheel,
                               c.Shaft,
                               c.Tire,
                               c.NewLicensePlate,
                               c.NewBrandID,
                               c.NewCarTypeID,
                               c.NewChassis,
                               c.ServiceReportBookNo,
                               c.ServiceRportNo,
                               c.NewServiceReportBookNo,
                               c.NewServiceRportNo,
                               c.Remark,
                               c.InsDateTime,
                               c.InsBy,
                               c.UpdDateTime,
                               c.UpdBy,
                           })
                           .ToList();
                var box = (from b in context.Box
                           join c in context.Car on b.CarID equals c.CarID into ascar
                           from c in ascar.DefaultIfEmpty()
                           where b.JobRequestNoID == id
                           select new
                           {
                               b.BoxID,
                               b.JobRequestNoID,
                               b.CarID,
                               b.DeviceID,
                               b.SimTypeID,
                               b.FirmWareID,
                               b.TimeSendDataID,
                               b.ElectricVoltID,
                               b.BatteryID,
                               b.LimitSpeedID,
                               b.SoundAlertID,
                               b.SerialNumber,
                               b.SerialDVRNumber,
                               b.AmountCameraDVR,
                               b.Username,
                               b.Password,
                               b.VID,
                               b.Port,
                               b.IP,
                               b.APN,
                               b.warrantydateStart,
                               b.warrantydateEnd,
                               b.InsDateTime,
                               b.InsBy,
                               b.UpdDateTime,
                               b.UpdBy,
                               LicensePlateName = c.LicensePlate
                           }
                           ).ToList();


                return new { car, box };
            }
            catch (Exception ex)
            {
                var joke = ex.Message;
                return null;
            }
        }

        public bool Insert(JobRequestClose model)
        {
            using (var dbTransaction = context.Database.BeginTransaction())
            {
                try
                {
                    if (model != null)
                    {

                        var update = context.JobRequestClose.Where(x => x.JobRequestCloseID == model.JobRequestCloseID).FirstOrDefault();

                        if (update != null)
                        {
                            update.AmountMounth = model.AmountMounth;
                            update.CompanyName = model.CompanyName;
                            update.ContactFax = model.ContactFax;
                            update.ContactFax = model.ContactFax;
                            update.ContactMobile = model.ContactMobile;
                            update.ContactName = model.ContactName;
                            update.ContactTel = model.ContactTel;
                            update.DocDeliverAddress = model.DocDeliverAddress;
                            update.ConditionBill = model.ConditionBill;
                            update.ConditionPayBill = model.ConditionPayBill;
                            update.PeriodPay = model.PeriodPay;
                            update.Location = model.Location;
                            update.Remark = model.Remark;
                            update.serviceChargeNextDate = model.serviceChargeNextDate;
                            update.serviceChargePMonthStartDate = model.serviceChargePMonthStartDate;
                            update.serviceChargePYearStartDate = model.serviceChargePYearStartDate;
                            update.serviceChargeRentStartDate = model.serviceChargeRentStartDate;
                            update.TaxID = model.TaxID;
                            update.UpdBy = model.UpdBy;
                            update.UpdDateTime = DateTime.Now;

                            foreach (Car item in model.Car)
                            {
                                var updatecar = context.Car.Where(x => x.CarID == item.CarID).FirstOrDefault();
                                if (update != null)
                                {
                                    updatecar.ServiceReportBookNo = item.ServiceReportBookNo;
                                    updatecar.ServiceRportNo = item.ServiceRportNo;
                                    updatecar.NewServiceReportBookNo = item.NewServiceReportBookNo;
                                    updatecar.NewServiceRportNo = item.NewServiceRportNo;
                                    updatecar.UpdBy = model.UpdBy;
                                    updatecar.UpdDateTime = DateTime.Now;

                                }
                            }
                            foreach (Box item in model.Box)
                            {
                                var updatebox = context.Box.Where(x => x.BoxID == item.BoxID).FirstOrDefault();
                                if (updatebox != null)
                                {
                                    //updatebox.AmountCameraDVR = item.AmountCameraDVR;
                                    //updatebox.APN = item.APN;
                                    //updatebox.BatteryID = item.BatteryID;
                                    //updatebox.CarID = item.CarID;
                                    //updatebox.DeviceID = item.DeviceID;
                                    //updatebox.ElectricVoltID = item.ElectricVoltID;
                                    //updatebox.FirmWareID = item.FirmWareID;
                                    //updatebox.IP = item.IP;
                                    //updatebox.LimitSpeedID = item.LimitSpeedID;
                                    //updatebox.Password = item.Password;
                                    //updatebox.Port = item.Port;
                                    //updatebox.SerialDVRNumber = item.SerialDVRNumber;
                                    updatebox.SerialNumber = item.SerialNumber;
                                    //updatebox.SimTypeID = item.SimTypeID;
                                    //updatebox.SoundAlertID = item.SoundAlertID;
                                    //updatebox.TimeSendDataID = item.TimeSendDataID;
                                    updatebox.UpdBy = model.UpdBy;
                                    updatebox.UpdDateTime = DateTime.Now;
                                    //updatebox.Username = item.Username;
                                    updatebox.VID = item.VID;
                                    updatebox.InstallDate = item.InstallDate;
                                    updatebox.UnstallDate = item.UnstallDate;
                                    //updatebox.warrantydateEnd = item.warrantydateEnd;
                                    //updatebox.warrantydateStart = item.warrantydateStart;
                                }
                            }
                            foreach(ServiceCharge item in model.ServiceCharge)
                            {
                                var updateservice = context.ServiceCharge.Where(x => x.ServiceID == item.ServiceID).FirstOrDefault();
                                if(updateservice != null)
                                {
                                    updateservice.Amount = item.Amount;
                                    updateservice.OptionID = item.OptionID;
                                    updateservice.Price = item.Price;
                                    updateservice.ServiceChargeID = item.ServiceChargeID;
                                    updateservice.TotalPricee = item.TotalPricee;
                                    updateservice.UpdBy = item.UpdBy;
                                    updateservice.UpdDateTime = DateTime.Now;
                                }
                            }
                            //foreach (string carid in model.CarIDs.Split(',').Where(x => x != "" || x != null))
                            //{
                            //    Car c = context.Car.Find(Convert.ToInt32(carid));
                            //    if (c != null)
                            //    {
                            //        context.Car.Remove(c);
                            //    }
                            //}
                            //foreach (string boxid in model.BoxIDs.Split(',').Where(x => x != "" || x != null))
                            //{
                            //    Box c = context.Box.Find(Convert.ToInt32(boxid));
                            //    if (c != null)
                            //    {
                            //        context.Box.Remove(c);
                            //    }
                            //}
                        }
                        else
                        {
                            model.InsDateTime = DateTime.Now;
                            //var jobtype = context.Master_D.Where(x => x.prmid == model.JobRequestType).Select(x => x.endesc).FirstOrDefault();
                            model.JobRequestCloseNo = GenerateJobCodeDB();
                            context.JobRequestClose.Add(model);
                            context.SaveChanges();

                            for (int i = 0; i < model.Car.Count; i++)
                            {
                                context.Car.Add(model.Car[i]);
                                context.SaveChanges();
                                for (int k = i; k < model.Box.Count;)
                                {
                                    context.Box.Add(model.Box[k]);
                                    context.SaveChanges();
                                    break;
                                }
                            }
                            for (int i = 0; i < model.InstallMent.Count; i++)
                            {
                                model.InstallMent[i].InsDateTime = DateTime.Now;
                                model.InstallMent[i].JobRequestCloseID = model.JobRequestCloseID;
                                context.InstallMent.Add(model.InstallMent[i]);
                            }
                            for(int i = 0; i < model.ServiceCharge.Count; i++)
                            {
                                context.ServiceCharge.Add(model.ServiceCharge[i]);
                                context.SaveChanges();
                            }

                        }
                        //context.SaveChanges();
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

        public bool Update(int id, JobRequestClose model)
        {
            throw new NotImplementedException();
        }
        public object GenerateJobCode()
        {
            string jobcode = "";
            string datecode = DateTime.Now.ToString("yyyyMMdd");
            try
            {

                jobcode = string.Format("JRC{0}{1}", datecode, "####");
            }
            catch (Exception e)
            {
                var joke = e.Message.ToString();
                return null;
            }
            return jobcode;
        }
        private string GenerateJobCodeDB()
        {
            string jobcode = "";
            string datecode = DateTime.Now.ToString("yyyyMMdd");
            try
            {
                var codeMax = (from j in context.JobRequestClose
                               where j.JobRequestCloseNo.Contains(datecode)
                               orderby j.JobRequestCloseID descending
                               select new
                               {
                                   j.JobRequestCloseNo
                               }).FirstOrDefault();

                if (codeMax == null)
                {
                    jobcode = string.Format("JRC{0}{1}", datecode, "0001");
                }
                else
                {
                    int maxruning = Convert.ToInt32(codeMax.JobRequestCloseNo.ToString().Substring(codeMax.JobRequestCloseNo.ToString().Length - 4, 4)) + 1;
                    string resultcode = string.Format("0000{0}", maxruning);
                    jobcode = string.Format("JRC{0}{1}", datecode, resultcode.Substring(resultcode.Length - 4, 4));
                }

            }
            catch (Exception e)
            {
                var joke = e.Message.ToString();
                return null;
            }
            return jobcode;
        }
    }
}
