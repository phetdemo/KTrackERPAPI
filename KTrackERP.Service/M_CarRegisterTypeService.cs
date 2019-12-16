using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class M_CarRegisterTypeService : IM_CarRegisterTypeService
    {
        private readonly IM_CarRegisterTypeRepository m_CarRegisterTypeRepository;

        public M_CarRegisterTypeService(IM_CarRegisterTypeRepository carRegisterTypeRepository)
        {
            m_CarRegisterTypeRepository = carRegisterTypeRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_CarRegisterType> Get()
        {
            throw new NotImplementedException();
        }

        public M_CarRegisterType GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_CarRegisterType model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_CarRegisterType model)
        {
            throw new NotImplementedException();
        }
    }
}
