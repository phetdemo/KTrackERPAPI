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
            return master_HRepository.Get();
        }

        public Master_H GetbyId()
        {
            throw new NotImplementedException();
        }

        public bool Insert(Master_H model)
        {
            return master_HRepository.Insert(model);
        }

    }
}
