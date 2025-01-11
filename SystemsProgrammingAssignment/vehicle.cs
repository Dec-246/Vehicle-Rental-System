using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using SystemsProgrammingAssignment;


namespace SystemsProgrammingAssignment
{
	public class Vehicle : Statistics
    {
        //protected allows deriving class to access objects in base class | this is used to inherit class objects into another class
        protected int vehicleID;
        protected bool availabilityStatus;
        protected string make;
        protected string model;
        protected string colour;
        protected string registrationPlate;

        // constructor
        public Vehicle(int vehicleID, bool availabilityStatus, string make, string model, string colour, string registrationPlate, float acceleration, int power, int mileage, int fuelEconomy, int topSpeed, int doors, float weight, string driveTrain, string fuelType, float engineSize, string transmission, int seatCapacity, int fuelCapacity, int weightCapacity, int loadCapacity, int year, string vehicleType, string features)
        {
            // Objects from vehicle class
            this.vehicleID = vehicleID;
			this.availabilityStatus = availabilityStatus;
			this.make = make;
			this.model = model;
			this.colour = colour;
			this.registrationPlate = registrationPlate;

            // Objects from statistics class
            this.acceleration = acceleration;
            this.power = power;
            this.mileage = mileage;
            this.fuelEconomy = fuelEconomy;
            this.topSpeed = topSpeed;
            this.doors = doors;
            this.weight = weight;
            this.driveTrain = driveTrain;
            this.fuelType = fuelType;
            this.engineSize = engineSize;
            this.transmission = transmission;
            this.seatCapacity = seatCapacity;
            this.fuelCapacity = fuelCapacity;
            this.weightCapacity = weightCapacity;
            this.loadCapacity = loadCapacity;
            this.year = year;
            this.vehicleType = vehicleType;
            this.features = features;
        }

		public Vehicle()
		{

		}

        // Accessors / getters (include the data type of object)
        public int GetVehicleID() { return vehicleID; }
		public bool GetAvailabilityStatus(bool v) { return availabilityStatus; }
		public string GetMake() { return make; }
		public string GetModel() { return model; }
		public string GetColour() { return colour; }
		public string GetRegistrationPlate() { return registrationPlate; }

		// Mutators / setters (void)
		public void SetVehicleID (int vehicleID) {this.vehicleID = vehicleID;}
		public void SetAvailabilityStatus (bool availabilityStatus) 
        {
            this.availabilityStatus = availabilityStatus;
            if (this.availabilityStatus == true)
            {
                string available = Convert.ToString(this.availabilityStatus);
            }
            if (this.availabilityStatus == false)
            {
                string NotAvailable = Convert.ToString(this.availabilityStatus);
            }
        }
		public void SetMake (string make) {this.make = make;}
		public void SetModel (string model) {this.model = model;}
		public void SetColour (string colour) {this.colour = colour;}
		public void SetRegistrationPlate (string registrationPlate) { this.registrationPlate = registrationPlate;}

        public override string ToString()
        {
            return "\nVehicle ID " + vehicleID + "\nMake: " + make + "\nModel: " + model;
        }
    }
}