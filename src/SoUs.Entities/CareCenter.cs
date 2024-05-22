using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoUs.Entities
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

        public CareCenter()
        {
            this.residents = new List<Resident>();
        }

        public CareCenter(int careCenterId, string name, Address address, List<Resident> residents)
        {
            this.careCenterId = careCenterId;
            this.name = name;
            this.address = address;
            this.residents = residents ?? new List<Resident>();
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

        public virtual Address Address
        {
            get { return address; }
            set { address = value; }
        }

        public virtual List<Resident> Residents
        {
            get { return residents; }
            set { residents = value; }
        }

        #endregion
    }
}
