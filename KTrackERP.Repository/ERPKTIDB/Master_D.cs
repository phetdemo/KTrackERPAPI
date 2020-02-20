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
        public object GetOptionBox(int boxid)
        {
            try
            {
                var boxde = context.BoxDetail.Where(x => x.BoxID == boxid).ToList();
                var option = context.Master_D.Where(x => x.prmtyp == "Option").ToList();


                var optionbox = (from o in option
                                 join b in boxde on o.prmid equals b.MOptionID into asb
                                 from x in asb.DefaultIfEmpty()
                                 select new
                                 {
                                     optionNameTH = o.thdesc,
                                     optionNameEN = o.endesc,
                                     o.prmflag,
                                     o.prmid,
                                     BoxDetailID = x?.BoxDetailID ?? null,
                                     BoxID = x?.BoxID ?? null,
                                     InsBy = x?.InsBy ?? null,
                                     InsDateTime = x?.InsDateTime ?? null,
                                     MCameraTypeID = x?.MCameraTypeID ?? null,
                                     MOptionID = x?.MOptionID ?? null,
                                     OptionValue = x?.OptionValue ?? null,
                                     UpdBy = x?.UpdBy ?? null,
                                     UpdDateTime = x?.UpdDateTime ?? null
                                 }).ToList();
                return new { optionbox };

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

        public IList<Entity.KTrackERPDB.Master_D> GetMasterType(string prmtyp)
        {
            try
            {

                var data = context.Master_D.Where(x => x.prmtyp == prmtyp && x.prmref == "KT" && x.recsts == true).OrderBy(a => a.thdesc).ToList();
                return data;
            }
            catch (Exception ex)
            {
                var joke = ex.Message;
                return null;
            }
        }


    }
}
