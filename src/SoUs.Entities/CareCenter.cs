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
            this.residents = new List<Resident>(); // Initialize the list to avoid null reference errors
        }

        public CareCenter(int careCenterId, string name, Address address, List<Resident> residents)
        {
            this.careCenterId = careCenterId;
            this.name = name;
            this.address = address;
            this.residents = residents ?? new List<Resident>(); // Ensure the list is never null
        }

        #endregion

        #region Properties

        [Key]  // Entity Framework requires a Key attribute for the primary key
        public int CareCenterId
        {
            get { return careCenterId; }
            set { careCenterId = value; }
        }

        [Required]  // Assumes that every care center must have a name
        [MaxLength(100)]  // Max length for the name field
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Foreign key property for Address
        public int AddressId { get; set; }  // This property holds the actual foreign key value

        [Required]
        [ForeignKey("AddressId")]  // This attribute links the Address navigation property with its foreign key
        public virtual Address Address
        {
            get { return address; }
            set { address = value; }
        }

        // Navigation property for residents
        public virtual List<Resident> Residents
        {
            get { return residents; }
            set { residents = value; }
        }

        #endregion
    }
}
