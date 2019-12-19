using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class Master_HService : IMaster_HService
    {
        private readonly IMaster_HRepository master_HRepository;

        public Master_HService(IMaster_HRepository master_HRepository)
        {
            this.master_HRepository = master_HRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Master_H> Get()
        {
            throw new NotImplementedException();
        }

        public Master_H GetbyId()
        {
            throw new NotImplementedException();
        }

        public bool Insert(Master_H model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, Master_H model)
        {
            throw new NotImplementedException();
        }
    }
}
