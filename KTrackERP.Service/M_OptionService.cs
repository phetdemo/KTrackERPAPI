using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class M_OptionService : IM_OptionService
    {
        private readonly IM_OptionRepository m_OptionRepository;

        public M_OptionService(IM_OptionRepository optionRepository)
        {
            m_OptionRepository = optionRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_Option> Get()
        {
            throw new NotImplementedException();
        }

        public M_Option GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_Option model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_Option model)
        {
            throw new NotImplementedException();
        }
    }
}
