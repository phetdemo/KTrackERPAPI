using KTrackERP.Entity.KTrackERPDB;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IHStockRepository
    {
        bool Insert(HStock model);
        object GetById(int id);
    }
}
