using KTrackERP.Entity.KTrackERPDB;

namespace KTrackERP.Service.Interface
{
    public interface IHStockService
    {
        bool Insert(HStock model);
        object GetById(int id);
    }
}
