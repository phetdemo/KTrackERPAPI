using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class M_CameraTypeService : IM_CameraTypeService
    {
        private readonly IM_CameraTypeRepository m_CameraTypeRepository;

        public M_CameraTypeService(IM_CameraTypeRepository cameraTypeRepository)
        {
            m_CameraTypeRepository = cameraTypeRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_CameraType> Get()
        {
            throw new NotImplementedException();
        }

        public M_CameraType GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_CameraType model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_CameraType model)
        {
            throw new NotImplementedException();
        }
    }
}
