using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using ParcelCompany.Departments;
using ParcelCompany.Model;
using ParcelCompany.Processor;

namespace ParcelCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Parcel delivery company");

            //parcel counter
            int count = 0;

            try
            {
                var departments = new List<IDepartment>();

                // Create instances of the Mail, Regular, and Heavy classes based on the current business rules.
                departments.Add(new Insurance());
                departments.Add(new Mail());
                departments.Add(new Regular());
                departments.Add(new Heavy());


                //Serialize
                XmlSerializer serializer = new XmlSerializer(typeof(Container));

                Container container;

                using (FileStream fileStream = new FileStream("../../.././Container_68465468.xml", FileMode.Open))
                {
                    container = (Container)serializer.Deserialize(fileStream);
                }

                ParcelHandler handler = new ParcelHandler(departments);


                //pass individual parcel to factory for processing
                foreach (var parcel in container.Parcels)
                {
                    try
                    {
                        Console.WriteLine(string.Format("Processing parcel {0}", count++));

                        handler.HandleParcel(parcel);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(string.Format("Error processing parcel {0}, Message - {1}", count, ex.Message));
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception();
            }
        }
    }
}
