﻿using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IM_DeviceService
    {
        IList<M_Device> Get();
        M_Device GetById(int id);
        bool Insert(M_Device model);
        bool Update(int id, M_Device model);
        bool Delete(int id);
    }
}
