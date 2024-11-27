using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace SystemsProgrammingAssignment
{
    internal class Customer : vehicle
    {
            public int customerID { get; set; }
            public string name { get; set; }
            private string email { get; set; }
            private string mobileNumber { get; set; }
            public string rentedVehicles { get; set; }

        public override void WriteBinary(BinaryWriter bw)
        {
            bw.Write("Customer");
            bw.Write(customerId);
            bw.Write(name);
            bw.Write(email);
            bw.Write(mobileNumber);
            bw.Write(rentedVehicles);

            bw.Write("\n\nVehice");
            bw.Write(vehicleID);
            bw.Write(Name);
            bw.Write(year);
            bw.Write(mileage);
            bw.Write(availabilityStatus);
        }

        public override void ReadBinary(BinaryReader br)
        {
            

            this.customerId = br.ReadInt32();
            this.name = br.ReadString();
            this.email = br.ReadString();
            this.mobileNumber = br.ReadString();
            this.rentedVehicles = br.ReadString();

            this.vehicleID = br.ReadInt32();
            this.Name = br.ReadString();
            this.year = br.ReadInt32();
            this.mileage = br.ReadInt32();
            this.availabilityStatus = br.ReadBoolean();
        }

        public override string ToString()
        {
            return "\n\nCustomer: " + "\nID: " + CustomerID + "\nName: " + name + "\Email: " + email + "\nMobile Number: " + mobileNumber + "\nRented Vehicles: " + rentedVehicles + "\nVehicle ID: " + vehicleID + "\nName: " + Name + "\nYear: " + year + "\nMileage: " + mileage + "\nAvailability Status: " + availabilityStatus;
        }
    }
}
