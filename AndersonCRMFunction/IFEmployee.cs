﻿using AndersonCRMModel;
using System.Collections.Generic;

namespace AndersonCRMFunction
{
    public interface IFEmployee
    {
        #region CREATE
        Employee Create(int createdBy, Employee employee);
        #endregion

        #region READ
        Employee Read(int employeeId);
        Employee Read(string employeeNumber, string pin);
        List<Employee> Read();
        List<Employee> Read(int companyId, string sortBy);
        List<Employee> ReadAndersonPhEmployees();
        List<Employee> ReadAssetHistory(int assetId, string sortBy);
        #endregion

        #region UPDATE
        Employee Update(int updatedBy, Employee employee);
        #endregion

        #region DELETE
        void Delete(int employeeId);
        #endregion
    }
}
