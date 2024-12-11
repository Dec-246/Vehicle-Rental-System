using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SystemsProgrammingAssignment
{
    // Customer will inherit the objects from the rental class because it will include all data from rental class and more. 
    internal class Customer
    {
        private int customerID;
        private string firstname; 
        private string lastname;
        private string email;
        private string mobileNumber;
        private string rentedVehicles;

        // constructor 
        public Customer (int customerID, string name, string email, string mobileNumber, string rentedVehicles)
        {
            this.customerID = customerID;
            string[] names = name.Split(" ");
            this.firstname = names[0];
            this.lastname = names[1];
            this.email = email;
            this.mobileNumber = mobileNumber;
            this.rentedVehicles = rentedVehicles;
        }

        

        // Accessors / getters (include the data type of object)
        public int GetCustomerID () { return customerID; }
        public string GetName() { return firstname + " " + lastname; }
        public string GetEmail() { return email; }
        public string GetMobileNumber() { return mobileNumber; }
        public string GetRentedVehicles() { return rentedVehicles; }

        // Mutators / setters (void)
        public void SetCustomerID (int customerID) {this.customerID = customerID; }
        public void SetName(string name) { 
            string[] names = name.Split(" "); 
            this.firstname = names[0]; 
            this.lastname= names[1]; }
        public void SetEmail(string email) {this.email = email; }
        public void SetMobileNumber (string mobileNumber) {this.mobileNumber = mobileNumber; }
        public void SetRentedVehicles (string rentedVehicles) { this.rentedVehicles = rentedVehicles; }
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