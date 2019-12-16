using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class M_AccessoriesService : IM_AccessoriesService
    {
        private readonly IM_AccessoriesRepository m_AccessoriesRepository;

        public M_AccessoriesService(IM_AccessoriesRepository accessoriesRepository)
        {
            m_AccessoriesRepository = accessoriesRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_Accessories> Get()
        {
            throw new NotImplementedException();
        }

        public M_Accessories GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_Accessories model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_Accessories model)
        {
            throw new NotImplementedException();
        }
    }
}
