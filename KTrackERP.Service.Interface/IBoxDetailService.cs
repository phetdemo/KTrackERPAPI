﻿using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IBoxDetailService
    {
        IList<BoxDetail> Get();
        object GetbyId(int id);
        bool Insert(BoxDetail model);
        object GetBoxDetailByBoxID(int boxid);
        bool Update(int id, BoxDetail model);
        bool Delete(int id);
    }
}
