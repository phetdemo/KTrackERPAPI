using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class M_PositionService : IM_PositionService
    {
        private readonly IM_PositionRepository m_PositionRepository;

        public M_PositionService(IM_PositionRepository positionRepository)
        {
            m_PositionRepository = positionRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_Position> Get()
        {
            throw new NotImplementedException();
        }

        public M_Position GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_Position model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_Position model)
        {
            throw new NotImplementedException();
        }
    }
}
