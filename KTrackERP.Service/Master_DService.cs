using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class Master_DService : IMaster_DService
    {
        private readonly IMaster_DRepository master_DRepository;

        public Master_DService(IMaster_DRepository master_DRepository)
        {
            this.master_DRepository = master_DRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Master_D> Get()
        {
            throw new NotImplementedException();
        }

        public Master_D GetbyId()
        {
            throw new NotImplementedException();
        }

        public bool Insert(Master_D model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, Master_D model)
        {
            throw new NotImplementedException();
        }
    }
}
