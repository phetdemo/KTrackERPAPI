using KTrackERP.Repository.Interface.KTrackERPDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTrackERP.Repository.ERPKTIDB
{
    public class OperationTestRepository : IOperationTestRepository
    { 
        private readonly ERPKTIDBContext context;
        public OperationTestRepository(ERPKTIDBContext context)
        {
            this.context = context;
        }

        public object Get()
        {
            try
            {
                var operationtest = context.OperationTest.ToList();
                return operationtest;
            }catch(Exception e)
            {
                var joke = e.Message;
                return null;
                    
            }
        }

        public object GetByID(int operid)
        {
            throw new NotImplementedException();
        }

        public bool Insert()
        {
            throw new NotImplementedException();
        }
    }
}
