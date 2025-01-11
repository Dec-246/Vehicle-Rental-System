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
        public void SetStartDate(DateTime rentalStartDate) {this.rentalStartDate = rentalStartDate; }
        public void SetEndDate(DateTime rentalEndDate) {this.rentalEndDate = rentalEndDate; }
        public void SetDailyRate(int dailyRate) {this.dailyRate = dailyRate; }
        public void SetDeposit (int deposit) { this.deposit = deposit; }
        public void SetActivityStatus (bool activityStatus) { this.activityStatus = activityStatus; }
    }
}