using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class Master_D : IMaster_DRepository
    {
        private readonly ERPKTIDBContext context;

        public Master_D(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Entity.KTrackERPDB.Master_D> Get()
        {
            try
            {
                return context.Master_D.ToList();
            }
            catch (Exception ex)
            {
                var joke = ex.Message;
                return null;
            }
        }

        public Entity.KTrackERPDB.Master_D GetById(string id)
        {
            try
            {
                return context.Master_D.OrderByDescending(x => x.prmcde).First();

            }
            catch (Exception ex)
            {
                var joke = ex.Message;
                return null;
            }
        }


        public bool Insert(Entity.KTrackERPDB.Master_D model)
        {
            try
            {
                var update = context.Master_D.Where(x => x.prmid == model.prmid).FirstOrDefault();
                if (update != null)
                {
                    update.prmtyp = model.prmtyp;
                    update.thdesc = model.thdesc;
                    update.endesc = model.endesc;
                    update.prmflag = model.prmflag;
                    update.remark = model.remark;
                    update.recsts = model.recsts;
                    update.updby = model.updby;
                    update.upddte = DateTime.Now;
                }
                else
                {
                    model.instdte = DateTime.Now;
                    context.Master_D.Add(model);
                }
                context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                var joke = ex.Message;
                return false;
            }
        }


    }
}
