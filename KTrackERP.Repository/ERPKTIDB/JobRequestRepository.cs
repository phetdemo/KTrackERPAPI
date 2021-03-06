﻿using KTrackERP.Entity;
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

                var car = (from c in context.Car
                           join brand in context.Master_D on c.BrandID equals brand.prmid into asbrand
                           join cartype in context.Master_D on c.CarTypeID equals cartype.prmid into ascartype
                           join licencedrive in context.Master_D on c.LicenceDriveTypeID equals licencedrive.prmid into aslicencedrive
                           from brand in asbrand.DefaultIfEmpty()
                           from cartype in ascartype.DefaultIfEmpty()
                           from licencedrive in aslicencedrive.DefaultIfEmpty()
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
                               BrandName = brand.thdesc,
                               CarTypeName = cartype.thdesc,
                               LicenceDriveTypeName = licencedrive.thdesc
                           }).ToList();

                //var jobID = car.Select(x => x.JobRequestNoID).FirstOrDefault();

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
                               boxs.InstallDate,
                               boxs.UnstallDate,
                               boxs.InsDateTime,
                               boxs.InsBy,
                               boxs.UpdDateTime,
                               boxs.UpdBy,
                               LicensePlateName = cars.LicensePlate,
                               DeviceName = device.thdesc,
                               SimTypeName = simtype.thdesc
                           }).ToList();


                //// boxdetailoption
                //var boxdes = context.BoxDetail.Where(x => x.JobRequestNoID == jobreq.JobRequestNoID).ToList();
                //var options = context.Master_D.Where(x => x.prmtyp == "Option").ToList();
                //var optionbox = (from o in options
                //                 join b in boxdes on o.prmid equals b.MOptionID
                //                 select new
                //                 {
                //                     optionNameTH = o.thdesc,
                //                     optionNameEN = o.endesc,
                //                     o.prmflag,
                //                     o.prmid,
                //                     b.BoxDetailID,
                //                     b.BoxID,
                //                     b.JobRequestNoID,
                //                     b.InsBy,
                //                     b.InsDateTime,
                //                     b.MCameraTypeID,
                //                     b.MOptionID,
                //                     b.OptionValue,
                //                     b.Selected,
                //                     b.UpdBy,
                //                     b.UpdDateTime,
                //                     LicensePlate = ""
                //                 }).ToList();
                //// operation
                //var boxde = (from bd in context.BoxDetail
                //             join op in context.OperationTest on bd.BoxDetailID equals op.BoxDetailID 
                //             where bd.JobRequestNoID == jobreq.JobRequestNoID
                //             select new
                //             {
                //                 bd.BoxDetailID,
                //                 bd.BoxID,
                //                 bd.JobRequestNoID,
                //                 bd.MCameraTypeID,
                //                 bd.MOptionID,
                //                 bd.Selected,
                //                 op.OperationID,
                //                 op.Tested,
                //                 op.InsBy,
                //                 op.UpdBy                             }
                //             ).ToList();
                //var option = context.Master_D.Where(x => x.prmtyp == "Option").ToList();
                //var operation = (from o in option
                //                 join b in boxde on o.prmid equals b.MOptionID
                //                 select new
                //                 {
                //                     optionNameTH = o.thdesc,
                //                     optionNameEN = o.endesc,
                //                     BoxDetailID = b?.BoxDetailID ?? 0,
                //                     BoxID = b?.BoxID ?? null,
                //                     JobRequestNoID = b?.JobRequestNoID ?? null,
                //                     MCameraTypeID = b?.MCameraTypeID ?? null,
                //                     MOptionID = b?.MOptionID ?? null,
                //                     Selected = b?.Selected ?? false,
                //                     Tested = b?.Tested ?? false,
                //                     b.InsBy,
                //                     b.UpdBy
                //                 }).ToList();

                return new { jobreq, car, box };

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

                            if (model.Car != null)
                            {
                                foreach (Car item in model.Car)
                                {
                                    var updatecar = context.Car.Where(x => x.CarID == item.CarID).FirstOrDefault();
                                    if (updatecar != null)
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
                                        updatecar.UpdBy = model.UpdBy;
                                        updatecar.UpdDateTime = DateTime.Now;
                                        updatecar.Wheel = item.Wheel;
                                    }
                                }
                            }
                            if (model.Box != null)
                            {
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
                                        updatebox.UpdBy = model.UpdBy;
                                        updatebox.UpdDateTime = DateTime.Now;
                                        updatebox.Username = item.Username;
                                        updatebox.VID = item.VID;
                                        updatebox.warrantydateEnd = item.warrantydateEnd;
                                        updatebox.warrantydateStart = item.warrantydateStart;
                                    }
                                }
                            }
                            if (model.BoxDetail != null)
                            {
                                foreach (BoxDetail item in model.BoxDetail)
                                {
                                    var updateboxd = context.BoxDetail.Where(x => x.BoxDetailID == item.BoxDetailID).FirstOrDefault();
                                    if (updateboxd != null)
                                    {
                                        if (item.Selected == false || string.IsNullOrEmpty(item.OptionValue))
                                        {
                                            var updateoperation = context.OperationTest.Where(x => x.BoxDetailID == item.BoxDetailID).FirstOrDefault();
                                            if (updateoperation != null)
                                            {
                                                context.OperationTest.Remove(updateoperation);
                                            }
                                            context.BoxDetail.Remove(updateboxd);
                                            context.SaveChanges();
                                        }
                                        //else
                                        //{
                                        //    var oper = model.OperationTest.Where(x => x.BoxDetailID == item.BoxDetailID).FirstOrDefault();
                                        //    if (oper != null)
                                        //    {
                                        //        var operup = context.OperationTest.Where(x => x.OperationID == oper.OperationID).FirstOrDefault();
                                        //        if (operup != null)
                                        //        {
                                        //            operup.UpdDateTime = DateTime.Now;
                                        //        }
                                        //        else
                                        //        {
                                        //            oper.InsDateTime = DateTime.Now;
                                        //            context.OperationTest.Add(oper);
                                        //            context.SaveChanges();
                                        //        }
                                        //    }
                                        //}
                                    }
                                    else
                                    {
                                        if (item.BoxDetailID == 0)
                                        {
                                            item.UpdBy = model.UpdBy;
                                            item.UpdDateTime = DateTime.Now;
                                            context.BoxDetail.Add(item);
                                            context.SaveChanges();
                                        }
                                    }
                                }
                            }
                            if (model.OperationTest != null)
                            {
                                foreach (OperationTest itemoper in model.OperationTest)
                                {
                                    var operup = context.OperationTest.Where(x => x.OperationID == itemoper.OperationID).FirstOrDefault();
                                    if (operup != null)
                                    {
                                        operup.Tested = itemoper.Tested;
                                        operup.UpdDateTime = DateTime.Now;
                                    }
                                    else
                                    {
                                        itemoper.InsDateTime = DateTime.Now;
                                        context.OperationTest.Add(itemoper);
                                        context.SaveChanges();
                                    }
                                }
                            }
                            if (model.TechnicCheckList != null)
                            {
                                foreach (TechnicCheckList technicCheck in model.TechnicCheckList)
                                {
                                    var dataCheck = context.TechnicCheckList.Where(x => x.CheckListID == technicCheck.CheckListID).FirstOrDefault();
                                    if (dataCheck != null)
                                    {

                                        dataCheck.Remark = technicCheck.Remark;
                                        dataCheck.Checked = technicCheck.Checked;
                                        dataCheck.UpdDateTime = DateTime.Now;
                                    }
                                    else
                                    {
                                        technicCheck.InsDateTime = DateTime.Now;
                                        context.TechnicCheckList.Add(technicCheck);
                                        context.SaveChanges();
                                    }
                                }
                            }
                            if (model.TechnicDVR != null)
                            {
                                foreach (TechnicDVR technicDVR in model.TechnicDVR)
                                {
                                    var dataDVR = context.TechnicDVR.Where(x => x.TechDVRID == technicDVR.TechDVRID).FirstOrDefault();
                                    if (dataDVR != null)
                                    {
                                        dataDVR.UpdDateTime = DateTime.Now;
                                        dataDVR.MDVRDirectionID = technicDVR.MDVRDirectionID;
                                        dataDVR.Remark = technicDVR.Remark;
                                    }
                                    else
                                    {
                                        technicDVR.InsDateTime = DateTime.Now;
                                        context.TechnicDVR.Add(technicDVR);
                                        context.SaveChanges();
                                    }
                                }
                            }
                            if (model.TechnicELSys != null)
                            {
                                foreach (TechnicELSys technicEL in model.TechnicELSys)
                                {
                                    var dataEL = context.TechnicELSys.Where(x => x.ELSysID == technicEL.ELSysID).FirstOrDefault();
                                    if (dataEL != null)
                                    {
                                        dataEL.UpdDateTime = DateTime.Now;
                                        dataEL.DCPowerAfterStart = technicEL.DCPowerAfterStart;
                                        dataEL.DCPowerBeforStart = technicEL.DCPowerBeforStart;
                                        dataEL.DCPowerWhileStart = technicEL.DCPowerWhileStart;
                                        dataEL.GroudAfterStart = technicEL.GroudAfterStart;
                                        dataEL.GroudBeforStart = technicEL.GroudBeforStart;
                                        dataEL.GroudWhileStart = technicEL.GroudWhileStart;
                                        dataEL.MELCut = technicEL.MELCut;
                                        dataEL.OnEngineOnAfterStart = technicEL.OnEngineOnAfterStart;
                                        dataEL.OnEngineOnBeforStart = technicEL.OnEngineOnBeforStart;
                                    }
                                    else
                                    {
                                        technicEL.InsDateTime = DateTime.Now;
                                        context.TechnicELSys.Add(technicEL);
                                        context.SaveChanges();
                                    }
                                }
                            }
                            if (model.TechnicELSysEquip != null)
                            {
                                foreach (TechnicELSysEquip eLSysEquip in model.TechnicELSysEquip)
                                {
                                    var dataEquip = context.TechnicELSysEquip.Where(x => x.ELSysEquipID == eLSysEquip.ELSysEquipID).FirstOrDefault();
                                    if (dataEquip != null)
                                    {
                                        dataEquip.UpdDateTime = DateTime.Now;
                                        dataEquip.IsNormal = eLSysEquip.IsNormal;
                                        dataEquip.Remark = eLSysEquip.Remark;
                                    }
                                    else
                                    {
                                        eLSysEquip.InsDateTime = DateTime.Now;
                                        context.TechnicELSysEquip.Add(eLSysEquip);
                                        context.SaveChanges();
                                    }
                                }
                            }
                            if (model.TechnicSensorTemp != null)
                            {
                                foreach (TechnicSensorTemp technicSensor in model.TechnicSensorTemp)
                                {
                                    var dataTemp = context.TechnicSensorTemp.Where(x => x.SensorTempID == technicSensor.SensorTempID).FirstOrDefault();
                                    if (dataTemp != null)
                                    {
                                        dataTemp.UpdDateTime = DateTime.Now;
                                        dataTemp.Sensor1 = technicSensor.Sensor1;
                                        dataTemp.Sensor2 = technicSensor.Sensor2;
                                        dataTemp.Sensor3 = technicSensor.Sensor3;
                                        dataTemp.Sensor4 = technicSensor.Sensor4;
                                    }
                                    else
                                    {
                                        technicSensor.InsDateTime = DateTime.Now;
                                        context.TechnicSensorTemp.Add(technicSensor);
                                        context.SaveChanges();
                                    }

                                }
                            }
                            if (model.HardwareTest != null)
                            {
                                foreach (HardwareTest hardwareTest in model.HardwareTest)
                                {
                                    var dataht = context.HardwareTest.Where(x => x.HardwareTestID == hardwareTest.HardwareTestID).FirstOrDefault();
                                    if (dataht != null)
                                    {
                                        dataht.UpdDateTime = DateTime.Now;
                                        dataht.Tested = hardwareTest.Tested;
                                    }
                                    else
                                    {
                                        hardwareTest.InsDateTime = DateTime.Now;
                                        context.HardwareTest.Add(hardwareTest);
                                        context.SaveChanges();
                                    }
                                }
                            }
                            if (model.HardwareTestDVR != null)
                            {
                                foreach (HardwareTestDVR testDVR in model.HardwareTestDVR)
                                {
                                    var datahdvr = context.HardwareTestDVR.Where(x => x.HardwareDVRID == testDVR.HardwareDVRID).FirstOrDefault();
                                    if (datahdvr != null)
                                    {
                                        datahdvr.UpdDateTime = DateTime.Now;
                                        datahdvr.Tested = testDVR.Tested;
                                    }
                                    else
                                    {
                                        testDVR.InsDateTime = DateTime.Now;
                                        context.HardwareTestDVR.Add(testDVR);
                                        context.SaveChanges();
                                    }
                                }
                            }
                            if (model.HardwareTestEquip != null)
                            {
                                foreach (HardwareTestEquip equip in model.HardwareTestEquip)
                                {
                                    var dataequip = context.HardwareTestEquip.Where(x => x.HardwareTestEquipID == equip.HardwareTestEquipID).FirstOrDefault();
                                    if (dataequip != null)
                                    {
                                        dataequip.UpdDateTime = DateTime.Now;
                                        dataequip.Tested = equip.Tested;
                                    }
                                    else
                                    {
                                        equip.InsDateTime = DateTime.Now;
                                        context.HardwareTestEquip.Add(equip);
                                        context.SaveChanges();
                                    }
                                }
                            }
                            if (model.HardwareTestSensorTemp != null)
                            {
                                foreach (HardwareTestSensorTemp sensorTemp in model.HardwareTestSensorTemp)
                                {
                                    var datasensor = context.HardwareTestSensorTemp.Where(x => x.HardwareTestSensorTempID == sensorTemp.HardwareTestSensorTempID).FirstOrDefault();
                                    if (datasensor != null)
                                    {
                                        datasensor.UpdDateTime = DateTime.Now;
                                        datasensor.Sensor1 = sensorTemp.Sensor1;
                                        datasensor.Sensor2 = sensorTemp.Sensor2;
                                        datasensor.Sensor3 = sensorTemp.Sensor3;
                                        datasensor.Sensor4 = sensorTemp.Sensor4;
                                    }
                                    else
                                    {
                                        sensorTemp.InsDateTime = DateTime.Now;
                                        context.HardwareTestSensorTemp.Add(sensorTemp);
                                        context.SaveChanges();
                                    }
                                }
                            }



                            if (model.CarIDs != null)
                            {
                                foreach (string carid in model.CarIDs.Split(',').Where(x => x != "" || x != null))
                                {
                                    Car c = context.Car.Find(Convert.ToInt32(carid));
                                    if (c != null)
                                    {
                                        context.Car.Remove(c);
                                    }
                                }
                            }
                            if (model.BoxIDs != null)
                            {
                                foreach (string boxid in model.BoxIDs.Split(',').Where(x => x != "" || x != null))
                                {
                                    Box b = context.Box.Find(Convert.ToInt32(boxid));
                                    if (b != null)
                                    {
                                        context.Box.Remove(b);
                                        var boxd = context.BoxDetail.Where(x => x.BoxID == b.BoxID).ToList();
                                        if (boxd != null)
                                        {
                                            context.BoxDetail.RemoveRange(boxd);
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            model.InsDateTime = DateTime.Now;
                            var jobtype = context.Master_D.Where(x => x.prmid == model.JobRequestType).Select(x => x.endesc).FirstOrDefault();
                            model.JobRequestNo = GenerateJobCodeDB(jobtype);
                            context.JobRequest.Add(model);
                            context.SaveChanges();

                            for (int i = 0; i < model.Car.Count; i++)
                            {
                                model.Car[i].JobRequestNoID = model.JobRequestNoID;
                                model.Car[i].InsBy = model.InsBy;
                                model.Car[i].InsDateTime = DateTime.Now;
                                context.Car.Add(model.Car[i]);
                                context.SaveChanges();
                                for (int k = i; k < model.Box.Count;)
                                {
                                    model.Box[k].JobRequestNoID = model.JobRequestNoID;
                                    //model.Box[k].CarID = model.Car[i].CarID;
                                    model.Box[k].InsDateTime = DateTime.Now;
                                    model.Box[k].InsBy = model.InsBy;
                                    context.Box.Add(model.Box[k]);
                                    context.SaveChanges();

                                    var boxdetails = model.BoxDetail.Where(x => (x.LicensePlate == model.Car[i].LicensePlate)).ToList();
                                    for (int j = 0; j < boxdetails.Count; j++)
                                    {
                                        boxdetails[j].InsBy = model.InsBy;
                                        boxdetails[j].InsDateTime = DateTime.Now;
                                        boxdetails[j].BoxID = model.Box[k].BoxID;
                                        boxdetails[j].JobRequestNoID = model.JobRequestNoID;
                                        context.BoxDetail.Add(boxdetails[j]);
                                        context.SaveChanges();
                                    }
                                    break;
                                }
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
        public object GetJobRef()
        {
            try
            {
                var job = context.JobRequest.ToList();
                return new { job };
            }
            catch (Exception e)
            {
                var joker = e.Message;
                return null;
            }
        }
        public object GetHistoryJob(int jobtype, int jobstatus)
        {
            IQueryable jobdata = null;
            try
            {
                if (jobtype == 0 && jobstatus == 0)
                {
                    jobdata = from job in context.JobRequest
                              join jt in context.Master_D on job.JobRequestType equals jt.prmid into asjobtype
                              join js in context.Master_D on job.JobStatus equals js.prmid into asjobstatus
                              from jt in asjobtype.DefaultIfEmpty()
                              from js in asjobstatus.DefaultIfEmpty()
                              select new
                              {
                                  job.JobRequestNoID,
                                  job.JobRequestNo,
                                  job.CompanyName,
                                  job.InsBy,
                                  jobstatusth = js.thdesc,
                                  jobtypeth = jt.thdesc
                              };
                }
                else if (jobstatus > 0 && jobtype > 0)
                {
                    jobdata = from job in context.JobRequest
                              join jt in context.Master_D on job.JobRequestType equals jt.prmid into asjobtype
                              join js in context.Master_D on job.JobStatus equals js.prmid into asjobstatus
                              from jt in asjobtype.DefaultIfEmpty()
                              from js in asjobstatus.DefaultIfEmpty()
                              where job.JobRequestType == jobtype && job.JobStatus == jobstatus
                              select new
                              {
                                  job.JobRequestNoID,
                                  job.JobRequestNo,
                                  job.CompanyName,
                                  job.InsBy,
                                  jobstatusth = js.thdesc,
                                  jobtypeth = jt.thdesc
                              };
                }
                else if (jobtype > 0 && jobstatus == 0)
                {
                    jobdata = from job in context.JobRequest
                              join jt in context.Master_D on job.JobRequestType equals jt.prmid into asjobtype
                              join js in context.Master_D on job.JobStatus equals js.prmid into asjobstatus
                              from jt in asjobtype.DefaultIfEmpty()
                              from js in asjobstatus.DefaultIfEmpty()
                              where job.JobRequestType == jobtype
                              select new
                              {
                                  job.JobRequestNoID,
                                  job.JobRequestNo,
                                  job.CompanyName,
                                  job.InsBy,
                                  jobstatusth = js.thdesc,
                                  jobtypeth = jt.thdesc
                              };
                }
                else
                {
                    jobdata = from job in context.JobRequest
                              join jt in context.Master_D on job.JobRequestType equals jt.prmid into asjobtype
                              join js in context.Master_D on job.JobStatus equals js.prmid into asjobstatus
                              from jt in asjobtype.DefaultIfEmpty()
                              from js in asjobstatus.DefaultIfEmpty()
                              where job.JobStatus == jobstatus
                              select new
                              {
                                  job.JobRequestNoID,
                                  job.JobRequestNo,
                                  job.CompanyName,
                                  job.InsBy,
                                  jobstatusth = js.thdesc,
                                  jobtypeth = jt.thdesc
                              };
                }

                return new { jobdata };
            }
            catch (Exception e)
            {
                var joker = e.Message;
                return null;
            }
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
        public object GetWorkListAll()
        {
            var jobreq = from job in context.JobRequest
                         join jobtype in context.Master_D on job.JobRequestType equals jobtype.prmid into asjobtype
                         join jobstatus in context.Master_D on job.JobStatus equals jobstatus.prmid into asjobstatus
                         from jobtype in asjobtype.DefaultIfEmpty()
                         from jobstatus in asjobstatus.DefaultIfEmpty()
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

        public object GenerateJobCode(string jobtype)
        {
            string jobcode = "";
            string datecode = DateTime.Now.ToString("yyyyMMdd");
            try
            {

                switch (jobtype)
                {
                    case "Install":
                        jobcode = string.Format("JI{0}{1}", datecode, "####");
                        break;
                    case "Remove":
                        jobcode = string.Format("JR{0}{1}", datecode, "####");
                        break;
                    case "Swapping":
                        jobcode = string.Format("JS{0}{1}", datecode, "####");
                        break;

                }
            }
            catch (Exception e)
            {
                var joke = e.Message.ToString();
                return null;
            }
            return jobcode;
        }
        private string GenerateJobCodeDB(string jobtype)
        {
            string jobcode = "";
            string datecode = DateTime.Now.ToString("yyyyMMdd");
            try
            {
                var codeMax = (from j in context.JobRequest
                               where j.JobRequestNo.Contains(datecode)
                               orderby j.JobRequestNoID descending
                               select new
                               {
                                   j.JobRequestNo
                               }).FirstOrDefault();
                switch (jobtype)
                {
                    case "Install":

                        if (codeMax == null)
                        {
                            jobcode = string.Format("JI{0}{1}", datecode, "0001");
                        }
                        else
                        {
                            int maxruning = Convert.ToInt32(codeMax.JobRequestNo.ToString().Substring(codeMax.JobRequestNo.ToString().Length - 4, 4)) + 1;
                            string resultcode = string.Format("0000{0}", maxruning);
                            jobcode = string.Format("JI{0}{1}", datecode, resultcode.Substring(resultcode.Length - 4, 4));
                        }
                        break;
                    case "Remove":
                        if (codeMax == null)
                        {
                            jobcode = string.Format("JR{0}{1}", datecode, "0001");
                        }
                        else
                        {
                            int maxruning = Convert.ToInt32(codeMax.JobRequestNo.ToString().Substring(codeMax.JobRequestNo.ToString().Length - 4, 4)) + 1;
                            string resultcode = string.Format("0000{0}", maxruning);
                            jobcode = string.Format("JR{0}{1}", datecode, resultcode.Substring(resultcode.Length - 4, 4));
                        }
                        break;
                    case "Swapping":
                        if (codeMax == null)
                        {
                            jobcode = string.Format("JS{0}{1}", datecode, "0001");
                        }
                        else
                        {
                            int maxruning = Convert.ToInt32(codeMax.JobRequestNo.ToString().Substring(codeMax.JobRequestNo.ToString().Length - 4, 4)) + 1;
                            string resultcode = string.Format("0000{0}", maxruning);
                            jobcode = string.Format("Js{0}{1}", datecode, resultcode.Substring(resultcode.Length - 4, 4));
                        }
                        break;

                }
            }
            catch (Exception e)
            {
                var joke = e.Message.ToString();
                return null;
            }
            return jobcode;
        }

        public bool Update(int id, JobRequest model)
        {
            throw new NotImplementedException();
        }
    }
}
