using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoUs.Entities
{
    public class Address
    {
        #region Fields
        private int addressId;
        private string street;
        private string city;
        private string state;
        private string zipCode;

        public Address()
        {
        }
        #endregion

        #region Constructors

        public Address(int addressId, string street, string city, string state, string zipCode)
        {
            AddressId = addressId;
            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        #endregion

        #region Properties
        public int AddressId
        {
            get { return addressId; }
            set { addressId = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }
        #endregion
    }
}
