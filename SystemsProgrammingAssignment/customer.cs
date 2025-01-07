using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SystemsProgrammingAssignment
{
    // Customer will inherit the objects from the rental class because it will include all data from rental class and more. 
    internal class User : Rental
    {
        protected int userID;
        protected string firstname; 
        protected string lastname;
        protected string email;
        protected string mobileNumber;

        // constructor 
        public User(int userID, string name, string email, string mobileNumber)
        {
            this.userID = userID;
            string[] names = name.Split(" ");
            this.firstname = names[0];
            this.lastname = names[1];
            this.email = email;
            this.mobileNumber = mobileNumber;
        }
        public User()
        {

        }

        /*public string DisplayUserInfo()
        {
            return $"ID: {GetUserID()} \nName: {GetName()} \nEmail: {GetEmail()} \nMobile Number: {GetMobileNumber()}";
        }*/


        // Accessors / getters (include the data type of object)
        public int GetUserID() { return userID; }
        public string GetName() { return firstname + " " + lastname; }
        public string GetEmail() { return email; }
        public string GetMobileNumber() { return mobileNumber; }
        

        // Mutators / setters (void)
        public void SetUserID(int userID) {

            // validation
            if (userID < 0 || userID >= 650) // user cannot provide ID larger than 650 
            {
                this.userID = -1; // -1 is indication of the user ID not valid value 
            } else
            {
                this.userID = userID;
            }
        }
        public void SetName(string name) { 
            string[] names = name.Split(" "); 
            this.firstname = names[0]; 
            this.lastname= names[1]; }
        public void SetEmail(string email) {this.email = email; }
        public void SetMobileNumber (string mobileNumber) {this.mobileNumber = mobileNumber; }
        
    }


}

        /*public override void WriteBinary(BinaryWriter bw)
        {
            bw.Write("Customer");
            bw.Write(customerId);
            bw.Write(name);
            bw.Write(email);
            bw.Write(mobileNumber);
            bw.Write(rentedVehicles);

            bw.Write("\n\nVehice");
            bw.Write(vehicleID);
            bw.Write(availabilityStatus);
            bw.Write(make);
            bw.Write(model);
            bw.Write(year);
            bw.Write(mileage);
            bw.Write(fuelType);
            bw.Write(transmission);
            bw.Write(capacity);
        }

        public override void ReadBinary(BinaryReader br)
        {
            

            this.customerId = br.ReadInt32();
            this.name = br.ReadString();
            this.email = br.ReadString();
            this.mobileNumber = br.ReadString();
            this.rentedVehicles = br.ReadString();

            this.vehicleID = br.ReadInt32();
            this.availabilityStatus = br.ReadBoolean();
            this.make = br.ReadString();
            this.model = br.ReadString();
            this.year = br.ReadInt32();
            this.mileage = br.ReadInt32();
            this.fuelType = br.ReadString();
            this.transmission = br.ReadString();
            this.capacity = br.ReadInt32();
        }

        public override string ToString()
        {
            return "\n\nCustomer: " + "\nID: " + CustomerID + "\nName: " + name + "\Email: " + email + "\nMobile Number: " + mobileNumber + "\nRented Vehicles: " + rentedVehicles + "\nVehicle ID: " + vehicleID + "\nName: " + Name + "\nYear: " + year + "\nMileage: " + mileage + "\nAvailability Status: " + availabilityStatus;
        }*/