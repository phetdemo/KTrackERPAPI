﻿using KTrackERP.Entity;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class BoxRepository : IBoxRepository

    {
        private readonly ERPKTIDBContext context;
        public BoxRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Box> Get()
        {
            throw new NotImplementedException();
        }

        public object GetById(int id)
        {
            try
            {
                var boxs = (from m in context.Box
                            where m.BoxID == id
                            select new { m }
                               ).FirstOrDefault();
                return boxs;

            }
            catch (Exception ex)
            {
                var joke = ex.Message;
                return null;
            }
        }

        public bool Insert(Box model)
        {
            try
            {
                if (model != null)
                {
                    var update = context.Box.Where(x => x.BoxID == model.BoxID).FirstOrDefault();
                    if (update != null)
                    {
                        update.AmountCameraDVR = model.AmountCameraDVR;
                        update.APN = model.APN;
                        update.BatteryID = model.BatteryID;
                        update.CarID = model.CarID;
                        update.DeviceID = model.DeviceID;
                        update.ElectricVoltID = model.ElectricVoltID;
                        update.FirmWareID = model.FirmWareID;
                        update.IP = model.IP;
                        update.LimitSpeedID = model.LimitSpeedID;
                        update.Password = model.Password;
                        update.Port = model.Port;
                        update.SerialDVRNumber = model.SerialDVRNumber;
                        update.SerialNumber = model.SerialNumber;
                        update.SimTypeID = model.SimTypeID;
                        update.SoundAlertID = model.SoundAlertID;
                        update.TimeSendDataID = model.TimeSendDataID;
                        update.UpdBy = model.UpdBy;
                        update.UpdDateTime = DateTime.Now;
                        update.Username = model.Username;
                        update.VID = model.VID;
                        update.warrantydateEnd = model.warrantydateEnd;
                        update.warrantydateStart = model.warrantydateStart;

                    }
                    else
                    {
                        model.InsDateTime = DateTime.Now;
                        context.Box.Add(model);
                    }
                    context.SaveChanges();

                }

            }
            catch (Exception e)
            {
                var joke = e.Message.ToString();
                return false;
            }
            return true;
        }

        public object GetBoxByJobID(int JobID)
        {
            try
            {
                var box = (from boxs in context.Box
                           join cars in context.Car on boxs.CarID equals cars.CarID into ascars
                           join simtype in context.Master_D on boxs.SimTypeID equals simtype.prmid into assimtype
                           join device in context.Master_D on boxs.DeviceID equals device.prmid into asdevice
                           from cars in ascars.DefaultIfEmpty()
                           from simtype in assimtype.DefaultIfEmpty()
                           from device in asdevice.DefaultIfEmpty()
                           where boxs.JobRequestNoID == JobID
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

                return box;
            }
            catch(Exception e)
            {
                var joke = e.Message;
                return null;
                  
            }
        }

        public bool Update(int id, Box model)
        {
            throw new NotImplementedException();
        }
    }
}
