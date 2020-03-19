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
                                     BoxDetailID = x?.BoxDetailID ?? 0,
                                     BoxID = x?.BoxID ?? null,
                                     JobRequestNoID = x?.JobRequestNoID ?? null,
                                     InsBy = x?.InsBy ?? null,
                                     InsDateTime = x?.InsDateTime ?? null,
                                     MCameraTypeID = x?.MCameraTypeID ?? null,
                                     MOptionID = x?.MOptionID ?? null,
                                     OptionValue = x?.OptionValue ?? null,
                                     Selected = x?.Selected ?? false,
                                     UpdBy = x?.UpdBy ?? null,
                                     UpdDateTime = x?.UpdDateTime ?? null,
                                     LicensePlate = ""
                                 }).ToList();
                return new { optionbox };

            }
            catch (Exception ex)
            {
                var joke = ex.Message;
                return null;
            }
        }
        public object GetElectricInternalEquip(int CarID)
        {
            try
            {
                var equip = context.TechnicELSysEquip.Where(x => x.CarID == CarID).ToList();
                var m = context.Master_D.Where(x => x.prmtyp == "ElectricSysInEquip").ToList();

                var internalequip = (from o in m
                                 join b in equip on o.prmid equals b.MELInternalID into asb
                                 from x in asb.DefaultIfEmpty()
                                 select new
                                 {
                                     EquipNameTH = o.thdesc,
                                     EquipNameEN = o.endesc,
                                     o.prmid,
                                     MELInternalID = x?.MELInternalID ?? 0,
                                     CarID = x?.CarID ?? null,                                     
                                     InsBy = x?.InsBy ?? null,
                                     InsDateTime = x?.InsDateTime ?? null,
                                     IsNormal = x?.IsNormal ?? null,
                                     UpdBy = x?.UpdBy ?? null,
                                     UpdDateTime = x?.UpdDateTime ?? null,
                                     Remark = x?.Remark ?? null
                                 }).ToList();
                return new { internalequip };

            }
            catch (Exception ex)
            {
                var joke = ex.Message;
                return null;
            }
        }
        public object GetTechnicCheckList(int CarID)
        {
            try
            {
                var checklist = context.TechnicCheckList.Where(x => x.CarID == CarID).ToList();
                var m = context.Master_D.Where(x => x.prmtyp == "Option").ToList();
                var technicchecklist = (from o in m
                                 join b in checklist on o.prmid equals b.MOption into asb
                                 from x in asb.DefaultIfEmpty()
                                 select new
                                 {
                                     optionNameTH = o.thdesc,
                                     optionNameEN = o.endesc,
                                     o.prmid,
                                     MOption = x?.MOption ?? 0,
                                     CarID = x?.CarID ?? null,
                                     InsBy = x?.InsBy ?? null,
                                     InsDateTime = x?.InsDateTime ?? null,
                                     Checked = x?.Checked ?? null,
                                     UpdBy = x?.UpdBy ?? null,
                                     UpdDateTime = x?.UpdDateTime ?? null,
                                     Remark = x?.Remark ?? null
                                 }).ToList();
                return new { technicchecklist };
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
