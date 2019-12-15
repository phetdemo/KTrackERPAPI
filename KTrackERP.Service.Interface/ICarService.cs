using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface ICarService
    {
        IList<Car> Get();
        Car GetById(int id);
        bool Insert(Car model);
        bool Update(int id, Car model);
        bool Delete(int id);
    }
}
