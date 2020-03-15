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
                var boxde = context.BoxDetail.Where(x => x.BoxID == id).ToList();
                var option = context.Master_D.Where(x => x.prmtyp == "Option").ToList();
                var optionbox = (from o in option
                                 join b in boxde on o.prmid equals b.MOptionID 
                                 select new
                                 {
                                     optionNameTH = o.thdesc,
                                     optionNameEN = o.endesc,
                                     o.prmflag,
                                     o.prmid,
                                     BoxDetailID = b?.BoxDetailID ?? 0,
                                     BoxID = b?.BoxID ?? null,
                                     JobRequestNoID = b?.JobRequestNoID ?? null,
                                     InsBy = b?.InsBy ?? null,
                                     InsDateTime = b?.InsDateTime ?? null,
                                     MCameraTypeID = b?.MCameraTypeID ?? null,
                                     MOptionID = b?.MOptionID ?? null,
                                     OptionValue = b?.OptionValue ?? null,
                                     Selected = b?.Selected ?? false,
                                     UpdBy = b?.UpdBy ?? null,
                                     UpdDateTime = b?.UpdDateTime ?? null,
                                     LicensePlate = ""
                                 }).ToList();
                return  optionbox;
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
        public object GetBoxDetailByBoxID(int boxid)
        {
            try
            {
                var boxde = (from bd in context.BoxDetail
                             join op in context.OperationTest on bd.BoxDetailID equals op.BoxDetailID into asop
                             from x in asop.DefaultIfEmpty()
                             where bd.BoxID == boxid
                             select new
                             {
                                 bd.BoxDetailID,
                                 bd.BoxID,
                                 bd.JobRequestNoID,
                                 bd.MCameraTypeID,
                                 bd.MOptionID,
                                 bd.Selected,
                                 OperationID = x != null ? x.OperationID : (int?)null,
                                 Tested = x != null ? x.Tested : null,
                                 InsBy = x != null ? x.InsBy : null,
                                 UpdBy = x!= null ? x.UpdBy : null
                             }
                             ).ToList();
                             
                var option = context.Master_D.Where(x => x.prmtyp == "Option").ToList();
                var optionbox = (from o in option
                                 join b in boxde on o.prmid equals b.MOptionID
                                 select new
                                 {
                                     b.OperationID,
                                     optionNameTH = o.thdesc,
                                     optionNameEN = o.endesc,
                                     BoxDetailID = b?.BoxDetailID ?? 0,
                                     BoxID = b?.BoxID ?? null,
                                     JobRequestNoID = b?.JobRequestNoID ?? null,
                                     MCameraTypeID = b?.MCameraTypeID ?? null,
                                     MOptionID = b?.MOptionID ?? null,
                                     Selected = b?.Selected ?? false,
                                     Tested = b?.Tested ?? null,
                                     b.InsBy,
                                     b.UpdBy
                                 }).ToList();
                
                return optionbox;
            }
            catch (Exception ex)
            {
                var joke = ex.Message;
                return null;
            }
        }

        public bool Update(int id, BoxDetail model)
        {
            throw new NotImplementedException();
        }
    }
}
