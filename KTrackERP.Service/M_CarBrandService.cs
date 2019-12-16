using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class M_CarBrandService : IM_CarBrandService
    {
        private readonly IM_CarBrandRepository m_CarBrandRepository;

        public M_CarBrandService(IM_CarBrandRepository carBrandRepository)
        {
            m_CarBrandRepository = carBrandRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_CarBrand> Get()
        {
            throw new NotImplementedException();
        }

        public M_CarBrand GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_CarBrand model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_CarBrand model)
        {
            throw new NotImplementedException();
        }
    }
}
