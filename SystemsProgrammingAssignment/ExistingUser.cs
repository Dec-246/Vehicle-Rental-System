using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace SystemsProgrammingAssignment
{
    // existing (returning) user inherits from customer because they have all the same values that a normal customer would have 
    // existing user would contain all the values from rental because they will likely have past rental history.
    internal class ExistingUser : User
	{
        private List<Rental> rentals;

        public ExistingUser(int userID, string name, string email, string mobileNumber, List<Rental> Rentals )
        {
            this.userID = userID;
            string[] names = name.Split(" ");
            this.firstname = names[0];
            this.lastname = names[1];
            this.email = email;
            this.mobileNumber = mobileNumber;

            // ?? represents possible null values 
            rentals = Rentals ?? new List<Rental>();
        }

        // copy constructor 
        public ExistingUser(ExistingUser user)
        {
            this.userID = user.userID;
            this.firstname = user.firstname;
            this.lastname = user.lastname;
            this.email = user.email;
            this.mobileNumber = user.mobileNumber;
            this.rentals = new List<Rental>();

            foreach (Rental userID in user.GetRentals())
            {
                this.rentals.Add(userID);
            }
        }

        // Accessors / getters (include the data type of object)
        public List<Rental> GetRentals() {return rentals; }


        // Mutators / setters (void)
        public void SetRentals(List<Rental> rentals) { this.rentals = rentals ?? new List<Rental> ();  }


        public void AddRental(Rental rental)
        {
            rentals.Add(rental);
        }

        public override string ToString()
        {
            return "\n\nExisting user: " + "\nID: " + GetUserID() + "\nName: " + GetName() + "\nEmail: " + GetEmail() + "\nMobile: " + GetMobileNumber() + "\nRentals: " + GetRentals(); }
        }
}





            // override indicates that this functionality is some sort of virtual function. you need to decide which kind of object is stored when you use this function.
/*        public override void WriteBinary(BinaryWriter bw)
        {
            bw.Write("Customer");
            bw.Write(customerId);
            bw.Write(name);
            bw.Write(email);
            bw.Write(mobileNumber);
            bw.Write(rentedVehicles);
        }

        public override void ReadBinary(BinaryReader br)
        {
            this.customerId = br.ReadInt32();
            this.name = br.ReadString();
            this.email = br.ReadString();
            this.mobileNumber = br.ReadString();
            this.rentedVehicles = br.ReadString();
        }

        public override string ToString()
        {
            return "\n\nCustomer: " + "\nID: " + CustomerID + "\nName: " + name + "\Email: " + email + "\nMobile Number: " + mobileNumber + "\nRented Vehicles: " + rentedVehicles ;
        }*/