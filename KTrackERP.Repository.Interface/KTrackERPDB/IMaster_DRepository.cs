﻿using KTrackERP.Entity.KTrackERPDB;
using System.Collections.Generic;

namespace KTrackERP.Repository.Interface.KTrackERPDB
{
    public interface IMaster_DRepository
    {
        IList<Master_D> Get();
        Master_D GetById(string id);
        bool Insert(Master_D model);

        bool Delete(int id);
        IList<Master_D> GetMasterType(string prmtyp);
        object GetOptionBox(int boxid);
        object GetElectricInternalEquip(int CarID);
        object GetTechnicCheckList(int CarID);
        object GetTechicELSys(int CarID);
        object GetTechnicDVR(int CarID);
        object GetTechnicSensorTemp(int CarID);
        object GetHardwareTest(int BoxID);
        object GetHardwareTestEquip(int BoxID);
        object GetHardwareTestDVR(int BoxID);
        object GetHardwareTestSensor(int BoxID);


    }
}
