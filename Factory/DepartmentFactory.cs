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

        //public List<IDepartment> CreateDepartments()
        //{
        //    var departments = new List<IDepartment>();

        //    // Create instances of the Mail, Regular, and Heavy classes based on the current business rules.
        //    departments.Add(new Mail());
        //    departments.Add(new Regular());
        //    departments.Add(new Heavy());

        //    // Add Insurance class if parcels with a value of over €1000,- need to be signed off.
        //    //if (parcels.Value > 1000)
        //    //{
        //    //    departments.Add(new Insurance());
        //    //}

        //    return departments;
        //}
    }
}
