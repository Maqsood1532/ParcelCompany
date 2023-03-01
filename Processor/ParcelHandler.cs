using System;
using System.Collections.Generic;
using ParcelCompany.Departments;
using ParcelCompany.Model;

namespace ParcelCompany.Processor
{
    public class ParcelHandler
    {
        private readonly List<IDepartment> _departments;

        public ParcelHandler(List<IDepartment> departments)
        {
            _departments = departments;
        }

        public Parcel HandleParcel(Parcel parcel)
        {
            foreach (var department in _departments)
            {
                department.HandleParcel(parcel);
            }
            return parcel;
        }
    }
}
