using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IOperationTestRepository
    {
        object Get();
        object GetByID(int operid);
        bool Insert();
    }
}
