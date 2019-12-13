using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface ICar
    {
        IList<Car> Get();
        Car GetById(int id);
        bool Insert(Car model);
        bool Update(int id, Car model);
        bool Delete(int id);
    }
}
