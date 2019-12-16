using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class FileService : IFileService
    {
        private readonly IFileRepository fileRepository;

        public FileService(IFileRepository fileRepository)
        {
            this.fileRepository = fileRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<File> Get()
        {
            throw new NotImplementedException();
        }

        public File GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(File model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, File model)
        {
            throw new NotImplementedException();
        }
    }
}
