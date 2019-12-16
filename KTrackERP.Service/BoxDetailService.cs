using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class BoxDetailService : IBoxDetailService
    {
        private readonly IBoxDetailRepository boxDetailRepository;

        public BoxDetailService(IBoxDetailRepository boxDetailRepository)
        {
            this.boxDetailRepository = boxDetailRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<BoxDetail> Get()
        {
            throw new NotImplementedException();
        }

        public BoxDetail GetbyId()
        {
            throw new NotImplementedException();
        }

        public bool Insert(BoxDetail model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, BoxDetail model)
        {
            throw new NotImplementedException();
        }
    }
}
