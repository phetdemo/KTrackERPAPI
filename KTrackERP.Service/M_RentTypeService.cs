using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class M_RentTypeService : IM_RentTypeService
    {
        private readonly IM_RentTypeRepository m_RentTypeRepository;

        public M_RentTypeService(IM_RentTypeRepository rentTypeRepository)
        {
            m_RentTypeRepository = rentTypeRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_RentType> Get()
        {
            throw new NotImplementedException();
        }

        public M_RentType GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_RentType model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_RentType model)
        {
            throw new NotImplementedException();
        }
    }
}
