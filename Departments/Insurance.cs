using System;
using ParcelCompany.Model;

namespace ParcelCompany.Departments
{
    public class Insurance : IDepartment
    {
        public Parcel HandleParcel(Parcel parcel)
        {
            if (parcel.Value > 1000)
            {
                Console.WriteLine("Parcel is Signed off by Insurance department");
            }

            return parcel;
        }
    }
}
