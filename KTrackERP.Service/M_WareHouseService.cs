using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class M_WareHouseService : IM_WareHouseService
    {
        private readonly IM_WareHouseRepository m_WareHouseRepository;

        public M_WareHouseService(IM_WareHouseRepository wareHouseRepository)
        {
            m_WareHouseRepository = wareHouseRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_WareHouse> Get()
        {
            throw new NotImplementedException();
        }

        public M_WareHouse GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_WareHouse model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_WareHouse model)
        {
            throw new NotImplementedException();
        }
    }
}
