using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTrackERP.Service
{
    public class OperationTestService : IOperationTestService
    {
        private readonly IOperationTestRepository operationTestRepository;
        public OperationTestService(IOperationTestRepository operationTestRepository)
        {
            this.operationTestRepository = operationTestRepository;
        }

        public object Get()
        {
            throw new NotImplementedException();
        }

        public object GetByID(int operid)
        {
            return operationTestRepository.GetByID(operid);
        }

        public bool Insert()
        {
            throw new NotImplementedException();
        }
    }
}
