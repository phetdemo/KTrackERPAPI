using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class FileRepository : IFile
    {
        private readonly ERPKTIDBContext context;

        public FileRepository(ERPKTIDBContext context)
        {
            this.context = context;
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
