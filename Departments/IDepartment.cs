using ParcelCompany.Model;

namespace ParcelCompany.Departments
{
    public interface IDepartment
    {

        public Parcel HandleParcel(Parcel parcel);

    }
}
