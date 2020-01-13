using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class BoxDetailRopository : IBoxDetailRepository
    {
        private readonly ERPKTIDBContext context;

        public BoxDetailRopository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<BoxDetail> Get()
        {
            throw new NotImplementedException();
        }

        public object GetById(int id)
        {
            try
            {
                var boxdetials = (from m in context.BoxDetail
                                  where m.BoxDetailID == id
                                  select new { m }
                               ).FirstOrDefault();
                return boxdetials;

            }
            catch (Exception ex)
            {
                var joke = ex.Message;
                return null;
            }
        }

        public bool Insert(BoxDetail model)
        {
            try
            {
                if (model != null)
                {
                    var update = context.BoxDetail.Where(x => x.BoxDetailID == model.BoxDetailID).FirstOrDefault();
                    if (update != null)
                    {
                        update.MCameraTypeID = model.MCameraTypeID;
                        update.MOptionID = model.MOptionID;
                        update.OptionValue = model.OptionValue;
                        update.UpdBy = model.UpdBy;
                        update.UpdDateTime = DateTime.Now;
                    }
                    else
                    {
                        model.InsDateTime = DateTime.Now;
                        context.BoxDetail.Add(model);
                    }
                    context.SaveChanges();

                }

            }
            catch (Exception e)
            {
                var joke = e.Message.ToString();
                return false;
            }
            return true;
        }

        public bool Update(int id, BoxDetail model)
        {
            throw new NotImplementedException();
        }
    }
}
