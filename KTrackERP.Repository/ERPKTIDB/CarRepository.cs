using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class CarRepository : ICar
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

        public Car GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Car model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, Car model)
        {
            throw new NotImplementedException();
        }
    }
}
