using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Linq;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class HStockRepository : IHStockRepository

    {
        private readonly ERPKTIDBContext context;

        public HStockRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public object GetById(int id)
        {
            try
            {
                var hstock = context.HStock.Where(x => x.HstockID == id).FirstOrDefault();
                return hstock;

            }
            catch (Exception ex)
            {
                var joke = ex.Message;
                return null;
            }
        }

        public bool Insert(HStock model)
        {
            throw new NotImplementedException();
        }
    }
}
