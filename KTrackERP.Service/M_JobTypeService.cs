using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class M_JobTypeService : IM_JobTypeService
    {
        private readonly IM_JobTypeRepository m_JobTypeRepository;

        public M_JobTypeService(IM_JobTypeRepository jobTypeRepository)
        {
            m_JobTypeRepository = jobTypeRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_JobType> Get()
        {
            throw new NotImplementedException();
        }

        public M_JobType GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_JobType model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_JobType model)
        {
            throw new NotImplementedException();
        }
    }
}
