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

                return new { jobreqc, installments, car, service };
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
                                    //updatebox.warrantydateEnd = item.warrantydateEnd;
                                    //updatebox.warrantydateStart = item.warrantydateStart;
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

        public bool Update(int id, JobRequestClose model)
        {
            throw new NotImplementedException();
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
                    jobcode = string.Format("JC{0}{1}", datecode, "0001");
                }
                else
                {
                    int maxruning = Convert.ToInt32(codeMax.JobRequestCloseNo.ToString().Substring(codeMax.JobRequestCloseNo.ToString().Length - 4, 4)) + 1;
                    string resultcode = string.Format("0000{0}", maxruning);
                    jobcode = string.Format("JC{0}{1}", datecode, resultcode.Substring(resultcode.Length - 4, 4));
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
