using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class Master_DService : IMaster_DService
    {
        private readonly IMaster_DRepository master_DRepository;

        public Master_DService(IMaster_DRepository master_DRepository)
        {
            this.master_DRepository = master_DRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Master_D> Get()
        {
            return master_DRepository.Get();
        }

        public Master_D GetbyId(string id)
        {
            return master_DRepository.GetById(id);
        }

        public bool Insert(Master_D model)
        {
            return master_DRepository.Insert(model);
        }
        public IList<Master_D> GetMasterType(string prmtyp)
        {
            return master_DRepository.GetMasterType(prmtyp);
        }
        public object GetOptionBox(int boxid)
        {
            return master_DRepository.GetOptionBox(boxid);
        }
        public object GetElectricInternalEquip(int CarID)
        {
            return master_DRepository.GetElectricInternalEquip(CarID);
        }
        public object GetTechnicCheckList(int CarID)
        {
            return master_DRepository.GetTechnicCheckList(CarID);
        }
        public object GetTechicELSys(int CarID)
        {
            return master_DRepository.GetTechicELSys(CarID);
        }
        public object GetTechnicDVR(int CarID)
        {
            return master_DRepository.GetTechnicDVR(CarID);
        }
        public object GetTechnicSensorTemp(int CarID)
        {
            return master_DRepository.GetTechnicSensorTemp(CarID);
        }


    }
}
