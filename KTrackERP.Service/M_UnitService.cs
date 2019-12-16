using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class M_UnitService : IM_UnitService
    {
        private readonly IM_UnitRepository m_UnitRepository;

        public M_UnitService(IM_UnitRepository unitRepository)
        {
            m_UnitRepository = unitRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_Unit> Get()
        {
            throw new NotImplementedException();
        }

        public M_Unit GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_Unit model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_Unit model)
        {
            throw new NotImplementedException();
        }
    }
}
