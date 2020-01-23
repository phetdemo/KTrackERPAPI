using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class CarRepository : ICarRepository
    {
        private readonly ERPKTIDBContext context;

        public CarRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Car> Get()
        {
            throw new NotImplementedException();
        }

        public object GetById(int id)
        {
            try
            {
                var car = (from m in context.Car
                           where m.CarID == id
                           select new { m }
                               ).FirstOrDefault();
                return car;

            }
            catch (Exception ex)
            {
                var joke = ex.Message;
                return null;
            }
        }

        public bool Insert(Car model)
        {
            try
            {
                if (model != null)
                {
                    var update = context.Car.Where(x => x.CarID == model.CarID).FirstOrDefault();
                    if (update != null)
                    {
                        update.JobRequestNoID = model.JobRequestNoID;
                        update.BrandID = model.BrandID;
                        update.CarTypeID = model.CarTypeID;
                        update.Chassis = model.Chassis;
                        update.LicenceDriveTypeID = model.LicenceDriveTypeID;
                        update.LicensePlate = model.LicensePlate;
                        update.Shaft = model.Shaft;
                        update.Tire = model.Tire;
                        update.Wheel = model.Wheel;
                        update.UpdBy = model.UpdBy;
                        update.UpdDateTime = DateTime.Now;
                    }
                    else
                    {
                        model.InsDateTime = DateTime.Now;
                        context.Car.Add(model);
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

        public bool Update(int id, Car model)
        {
            throw new NotImplementedException();
        }
    }
}
