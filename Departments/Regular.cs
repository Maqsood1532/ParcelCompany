using System;
using ParcelCompany.Model;

namespace ParcelCompany.Departments
{
    public class Regular : IDepartment
    {

        public Parcel HandleParcel(Parcel parcel)
        {
            if (parcel.Weight > 1 && parcel.Weight <= 10)
            {
                Console.WriteLine("Parcel is processed by Regular department");
            }

            return parcel;
        }

    }
}
