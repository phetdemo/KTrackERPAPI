using KTrackERP.Entity;
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

        public bool Update(int id, Box model)
        {
            throw new NotImplementedException();
        }
    }
}
