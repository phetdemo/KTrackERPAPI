using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class M_SimTypeService : IM_SimTypeService
    {
        private readonly IM_SimTypeRepository m_SimTypeRepository;

        public M_SimTypeService(IM_SimTypeRepository simTypeRepository)
        {
            m_SimTypeRepository = simTypeRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_SimType> Get()
        {
            throw new NotImplementedException();
        }

        public M_SimType GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_SimType model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_SimType model)
        {
            throw new NotImplementedException();
        }
    }
}
