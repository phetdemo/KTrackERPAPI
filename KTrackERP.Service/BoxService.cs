using KTrackERP.Entity;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class BoxService : IBoxService
    {
        private readonly IBoxRepository boxRepository;

        public BoxService(IBoxRepository boxRepository)
        {
            this.boxRepository = boxRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Box> Get()
        {
            throw new NotImplementedException();
        }

        public object GetbyId(int id)
        {
            return boxRepository.GetById(id);
        }

        public bool Insert(Box model)
        {
            return boxRepository.Insert(model);
        }
        public object GetBoxByJobID(int JobID)
        {
            return boxRepository.GetBoxByJobID(JobID);
        }

        public bool Update(int id, Box model)
        {
            throw new NotImplementedException();
        }
    }
}
