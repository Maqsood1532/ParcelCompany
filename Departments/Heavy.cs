using System;
using ParcelCompany.Model;

namespace ParcelCompany.Departments
{
    public class Heavy : IDepartment
    {
        public Parcel HandleParcel(Parcel parcel)
        {
            if (parcel.Weight > 10)
            {
                Console.WriteLine("Parcel is processed by Heavy department");
            }

            return parcel;
        }
    }
}
