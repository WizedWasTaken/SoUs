﻿namespace SoUs.Entities
{
    public class CareCenter
    {
        #region Fields

        private int careCenterId;
        private string name;
        private Address address;
        private List<Resident> residents;

        #endregion

        #region Constructors

        public CareCenter(int careCenterId, string name, Address address, List<Resident> residents)
        {
            CareCenterId = careCenterId;
            Name = name;
            Address = address;
            Residents = residents;
        }

        #endregion

        #region Properties

        public int CareCenterId
        {
            get { return careCenterId; }
            set { careCenterId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        public List<Resident> Residents
        {
            get { return residents; }
            set { residents = value; }
        }

        #endregion
    }
}