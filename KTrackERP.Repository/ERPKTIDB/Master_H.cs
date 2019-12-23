using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class Master_H : IMaster_HRepository
    {
        private readonly ERPKTIDBContext context;

        public Master_H(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Entity.KTrackERPDB.Master_H> Get()
        {
            return context.Master_H.ToList();
        }

        public Entity.KTrackERPDB.Master_H GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Entity.KTrackERPDB.Master_H model)
        {
            bool pass = false;
            try
            {
                if (model != null)
                {
                    var update = context.Master_H.Where(x => x.prmtyp == model.prmtyp).FirstOrDefault();
                    if (update != null)
                    {
                        context.Entry(model).State = EntityState.Modified;
                    }
                    else
                    {
                        context.Master_H.Add(model);
                    }

                    context.SaveChanges();
                    pass = true;
                }

            }
            catch (Exception)
            {
                return false;
            }
            return pass;
        }
    }
}
