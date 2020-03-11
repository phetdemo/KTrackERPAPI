using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class M_EmployeeRepository : IM_EmployeeRepository
    {
        private readonly ERPKTIDBContext context;

        public M_EmployeeRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public object Get()
        {
            try
            {
                var emp = (from e in context.M_Employee
                           join p in context.Master_D on e.PositionID equals p.prmid into asp
                           join d in context.Master_D on e.DivisionID equals d.prmid into asd
                           from p in asp.DefaultIfEmpty()
                           from d in asd.DefaultIfEmpty()
                           select new
                           {
                               e.Active,
                               e.DivisionID,
                               e.Email,
                               e.EmployeeID,
                               e.FirstNameEN,
                               e.FirstNameTH,
                               e.InsBy,
                               e.InsDateTime,
                               e.LastNameEN,
                               e.LastNameTH,
                               e.Mobile,
                               e.PositionID,
                               e.UpdBy,
                               e.UpdDateTime,
                               PositionNameTH = p.thdesc,
                               PositionNameEN = p.endesc,
                               DivisionNameTH = d.thdesc,
                               DivisionNameEN = d.endesc
                           }).ToList();
                return emp;
            }
            catch(Exception e)
            {
                var joker = e.Message;
                return null;                  
            }            
        }

        public object GetById(int id)
        {
            try
            {
                var emp = (from m in context.M_Employee
                           where m.EmployeeID == id
                           select new { m }
                               ).FirstOrDefault();
                return emp;

            }
            catch (Exception ex)
            {
                var joke = ex.Message;
                return null;
            }
        }

        public bool Insert(M_Employee model)
        {
            try
            {
                if (model != null)
                {
                    var update = context.M_Employee.Where(x => x.EmployeeID == model.EmployeeID).FirstOrDefault();
                    if (update != null)
                    {
                        update.Active = model.Active;
                        update.DivisionID = model.DivisionID;
                        update.Email = model.Email;
                        update.FirstNameEN = model.FirstNameEN;
                        update.FirstNameTH = model.FirstNameTH;
                        update.LastNameEN = model.LastNameEN;
                        update.LastNameTH = model.LastNameTH;
                        update.Mobile = model.Mobile;
                        update.PositionID = model.PositionID;
                        update.UpdBy = model.UpdBy;
                        update.UpdDateTime = DateTime.Now;
                    }
                    else
                    {
                        model.InsDateTime = DateTime.Now;
                        context.M_Employee.Add(model);
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

        public bool Update(int id, M_Employee model)
        {
            throw new NotImplementedException();
        }
    }
}
