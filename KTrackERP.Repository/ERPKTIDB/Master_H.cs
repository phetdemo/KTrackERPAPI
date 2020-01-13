using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;
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

        public object GetById(string id)
        {
            try
            {
                var masterh = (from m in context.Master_H
                               where m.prmtyp == id
                               select new { m }
                               ).FirstOrDefault();
                return masterh;

            }
            catch (Exception ex)
            {
                var joke = ex.Message;
                return null;
            }


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
                        update.thdesc = model.thdesc;
                        update.endesc = model.endesc;
                        update.recsts = model.recsts;
                        update.remark = model.remark;
                        update.upddte = DateTime.Now;
                        update.updby = model.updby;
                    }
                    else
                    {
                        model.instdte = DateTime.Now;
                        context.Master_H.Add(model);
                    }

                    context.SaveChanges();
                    pass = true;
                }

            }
            catch (Exception e)
            {
                var joke = e.Message.ToString();
                return pass;
            }
            return pass;
        }
    }
}
