using KTrackERP.Repository.Interface.KTrackERPDB;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class HStockDetailRepository : IHStockDetailRepository
    {
        private readonly ERPKTIDBContext context;
        public HStockDetailRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public object GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
