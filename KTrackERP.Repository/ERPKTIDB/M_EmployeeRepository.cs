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

        public IList<M_Employee> Get()
        {
            var emp = context.M_Employee.ToList();
            return emp;
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
