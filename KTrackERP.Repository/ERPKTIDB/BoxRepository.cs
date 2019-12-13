using KTrackERP.Entity;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class BoxRepository : IBoxRepository

    {
        private readonly ERPKTIDBContext context;
        public BoxRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        bool IBoxRepository.Delete(int id)
        {
            throw new NotImplementedException();
        }

        IList<Box> IBoxRepository.Get()
        {
            return context.Box.ToList();
        }

        Box IBoxRepository.GetById(int id)
        {
            throw new NotImplementedException();
        }

        bool IBoxRepository.Insert(Box model)
        {
            throw new NotImplementedException();
        }

        bool IBoxRepository.Update(int id, Box model)
        {
            throw new NotImplementedException();
        }
    }
}
