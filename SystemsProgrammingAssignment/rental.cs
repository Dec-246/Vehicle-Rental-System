using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SystemsProgrammingAssignment
{
    // Rental class will inherit from the vehicle class as it will include all data from the vehicle class and more
    internal class rental
    {

        private int rentalID;
        private DateTime rentalStartDate;
        private DateTime rentalEndDate;
        private int rentCost;
        private int deposit;

        //Constructor 
        public rental(int rentalID, DateTime rentalStartDate, DateTime rentalEndDate, int rentCost, int deposit)
        {
            this.rentalID = rentalID;
            this.rentalStartDate = rentalStartDate;
            this.rentalEndDate = rentalEndDate;
            this.rentCost = rentCost;
            this.deposit = deposit;
        }

        // Accessors / getters (include the data type of object)
        public int GetRentalID() { return rentalID; }
        public DateTime GetStartDate() { return rentalStartDate; }
        public DateTime GetEndDate() { return rentalEndDate; }
        public int GetCost() { return rentCost; }
        public int GetDeposit() { return deposit; }

        // Mutators / setters (void)
        public void SetRentalID(int rentalID) { this.rentalID = rentalID; }
        public void SetStartDate(DateTime rentalStartDate) {this.rentalStartDate = rentalStartDate; }
        public void SetEndDate(DateTime rentalEndDate) {this.rentalEndDate = rentalEndDate; }
        public void SetCost(int rentCost) {this.rentCost = rentCost; }
        public void SetDeposit (int deposit) { this.deposit = deposit; }
    }
}

/*public string OwnedProjectsNames { get; set; }*/ //names of owned projects
       /* int Start = Convert.ToInt32(rentalStartDate);
        int End = Convert.ToInt32(rentalEndDate);

        public override void WriteBinary(BinaryWriter bw)
        {
            bw.Write("Rental");
            bw.Write(rentalID);
            bw.Write(Start);
            bw.Write(End);
            bw.Write(rentCost);

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
            this.rentalID = br.ReadInt32();
            this.Start = br.ReadInt32();
            this.End = br.ReadInt32();
            this.rentCost = br.ReadInt32();

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
            return "\n\nCustomer: " + "\nID: " + rentalID + "\nRental Start Date: " + Start + "\nRental End Date: " + End + "\nRental Cost: " + rentCost + "\nVehicle ID: " + vehicleID + "\nName: " + Name + "\nYear: " + year + "\nMileage: " + mileage + "\nAvailability Status: " + availabilityStatus;
        }*/



//example
/*public override void WriteBinary(BinaryWriter bw)
{
    bw.Write("SeniorEngineer");
    bw.Write(Id);
    bw.Write(Name);
    bw.Write(Salary);
    bw.Write(OwnedProjectsNames);
    bw.Write(ProjectsOwnedNum);
    bw.Write(Contacts);
    bw.Write(BonusSalary);
}*/