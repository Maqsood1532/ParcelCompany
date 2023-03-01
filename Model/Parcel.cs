using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ParcelCompany.Model
{

    [XmlRoot(ElementName = "Container")]
    public class Container
    {
        [XmlElement(ElementName = "Id")]
        public string Id { get; set; }

        [XmlElement(ElementName = "ShippingDate")]
        public string ShippingDate { get; set; }

        [XmlArray("parcels")]
        [XmlArrayItem("Parcel", typeof(Parcel))]
        public List<Parcel> Parcels { get; set; }

    }

    public class Parcel
    {
        [XmlElement(ElementName = "Receipient")]
        public Receipient Receipient { get; set; }

        [XmlElement(ElementName = "Weight")]
        public decimal Weight { get; set; }

        [XmlElement(ElementName = "Value")]
        public decimal Value { get; set; }
    }

    public class Receipient
    {
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "Address")]
        public Address Address { get; set; }
    }

    public class Address
    {
        [XmlElement(ElementName = "Street")]
        public string Street { get; set; }

        [XmlElement(ElementName = "HouseNumber")]
        public int HouseNumber { get; set; }

        [XmlElement(ElementName = "PostalCode")]
        public string PostalCode { get; set; }

        [XmlElement(ElementName = "City")]
        public string City { get; set; }
    }
}
