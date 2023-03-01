using System;
using ParcelCompany.Model;

namespace ParcelCompany.Departments
{
    public class Mail : IDepartment
    {
        public Parcel HandleParcel(Parcel parcel)
        {
            if (parcel.Weight <= 1)
            {
                Console.WriteLine("Parcel is processed by Mail department");
            }

            return parcel;
        }
    }
}
