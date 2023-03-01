using System;
using System.Collections.Generic;
using ParcelCompany.Departments;

namespace ParcelCompany.Factory
{
    public class DepartmentFactory
    {
        public static IDepartment Create<T>() where T : IDepartment, new()
        {
            return new T();
        }
    }
}
