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
            return boxRepository.Get();
        }

        public Box GetbyId()
        {
            throw new NotImplementedException();
        }

        public bool Insert(Box model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, Box model)
        {
            throw new NotImplementedException();
        }
    }
}
