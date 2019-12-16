using KTrackERP.Entity.KTrackERPDB;
using KTrackERP.Repository.Interface.KTrackERPDB;
using KTrackERP.Service.Interface;
using System;
using System.Collections.Generic;

namespace KTrackERP.Service
{
    public class M_EmployeeService : IM_EmployeeService
    {
        private readonly IM_EmployeeRepository m_EmployeeRepository;

        public M_EmployeeService(IM_EmployeeRepository employeeRepository)
        {
            m_EmployeeRepository = employeeRepository;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<M_Employee> Get()
        {
            throw new NotImplementedException();
        }

        public M_Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(M_Employee model)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, M_Employee model)
        {
            throw new NotImplementedException();
        }
    }
}
