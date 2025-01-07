using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;
using Microsoft.VisualBasic;


namespace SystemsProgrammingAssignment
{
    // Rental class will inherit from the vehicle class as it will include all data from the vehicle class and more
    internal class Rental : Vehicle
    {
        protected DateTime rentalStartDate;
        protected DateTime rentalEndDate;
        protected int dailyRate;
        protected int deposit;
        protected bool activityStatus;

        //Constructor 
        public Rental(DateTime rentalStartDate, DateTime rentalEndDate, int dailyRate, int deposit, bool activityStatus, int vehicleID, bool availabilityStatus, string make, string model, string colour, string registrationPlate)
        {
            this.rentalStartDate = rentalStartDate;
            this.rentalEndDate = rentalEndDate;
            this.dailyRate = dailyRate;
            this.deposit = deposit;
            this.activityStatus = activityStatus;


            this.vehicleID = vehicleID;
            this.availabilityStatus = availabilityStatus;
            this.make = make;
            this.model = model;
            this.colour = colour;
            this.registrationPlate = registrationPlate;
        }

        public Rental()
        {

        }

        public int RentCharge()
        {
            // getting the difference between the days of the two dates
            int rentalLength = (rentalEndDate - rentalStartDate).Days;

            return (rentalLength * dailyRate) + deposit;
        }

        // Accessors / getters (include the data type of object)
        public DateTime GetStartDate() { return rentalStartDate; }
        public DateTime GetEndDate() { return rentalEndDate; }
        public int GetDailyRate() { return dailyRate; }
        public int GetDeposit() { return deposit; }
        public bool GetActivityStatus(bool v) {return activityStatus; }

        // Mutators / setters (void)
        //public void SetRentCharge(int RentCharge) { this.RentCharge =  RentCharge; }
        public void SetStartDate(DateTime rentalStartDate) {this.rentalStartDate = rentalStartDate; }
        public void SetEndDate(DateTime rentalEndDate) {this.rentalEndDate = rentalEndDate; }
        public void SetDailyRate(int dailyRate) {this.dailyRate = dailyRate; }
        public void SetDeposit (int deposit) { this.deposit = deposit; }
        public void SetActivityStatus (bool activityStatus) { this.activityStatus = activityStatus; }
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