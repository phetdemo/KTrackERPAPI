using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface ICarRepository
    {
        IList<Car> Get();
        object GetById(int id);
        bool Insert(Car model);
        bool Update(int id, Car model);
        bool Delete(int id);
    }
}
