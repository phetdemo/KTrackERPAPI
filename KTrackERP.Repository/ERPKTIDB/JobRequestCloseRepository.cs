using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class JobRequestCloseRepository : IJobRequestCloseRepository
    {
        private readonly ERPKTIDBContext context;

        public JobRequestCloseRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<JobRequestClose> Get()
        {
            throw new NotImplementedException();
        }

        public object GetById(int id)
        {
            try
            {
                var jobreqc = (from m in context.JobRequestClose
                               where m.JobRequestCloseID == id
                               select new
                               {
                                   m.JobRequestCloseID,
                                   m.JobRequestNoID,
                                   m.CompanyName,
                                   m.ContactName,
                                   m.ContactTel,
                                   m.ContactMobile,
                                   m.ContactFax,
                                   m.Location,
                                   m.Remark,
                                   m.TaxID,
                                   m.DocDeliverAddress,
                                   m.serviceChargePMonthStartDate,
                                   m.serviceChargePYearStartDate,
                                   m.serviceChargeNextDate,
                                   m.serviceChargeRentStartDate,
                                   m.AmountMounth,
                                   m.ApproveBy,
                                   m.ApproveDateTime,
                                   m.InsDateTime,
                                   m.InsBy,
                                   m.UpdDateTime,
                                   m.UpdBy
                               }
                               ).FirstOrDefault();
                var installments = (from i in context.InstallMent
                                    where i.JobRequestCloseID == id
                                    select new
                                    {
                                        i.InstallMentID,
                                        i.JobRequestCloseID,
                                        i.Seq,
                                        i.Price,
                                        i.PayDate,
                                        i.InsDateTime,
                                        i.InsBy,
                                        i.UpdDateTime,
                                        i.UpdBy
                                    }).ToList();


                return new { jobreqc, installments };
            }
            catch (Exception ex)
            {
                var joke = ex.Message;
                return null;
            }

        }

        public bool Insert(JobRequestClose model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, JobRequestClose model)
        {
            throw new NotImplementedException();
        }
    }
}
