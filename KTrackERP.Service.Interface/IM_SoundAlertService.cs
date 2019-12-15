﻿using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Service.Interface
{
    public interface IM_SoundAlertService
    {
        IList<M_SoundAlert> Get();
        M_SoundAlert GetById(int id);
        bool Insert(M_SoundAlert model);
        bool Update(int id, M_SoundAlert model);
        bool Delete(int id);
    }
}
