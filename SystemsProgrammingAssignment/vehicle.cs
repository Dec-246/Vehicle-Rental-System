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
        //protected allows deriving class to access things in base class | this is used to inherit class objects into another class
        protected int vehicleID;
        protected bool availabilityStatus;
        protected string make;
        protected string model;
        protected string colour;
        protected string registrationPlate;

        // constructor
        public Vehicle(int vehicleID, bool availabilityStatus, string make, string model, string colour, string registrationPlate, float acceleration, int power, int mileage, int fuelEconomy, int topSpeed, int doors, float weight, string driveTrain, string fuelType, float engineSize, string transmission, int seatCapacity, int fuelCapacity, int weightCapacity, int loadCapacity, int year, string vehicleType, string features)
        {
            this.vehicleID = vehicleID;
			this.availabilityStatus = availabilityStatus;
			this.make = make;
			this.model = model;
			this.colour = colour;
			this.registrationPlate = registrationPlate;

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



        /*public override string ToString()
        {
            return "\n\n\nVehicle: " +
                "\n\nBasic details: " + 
                "\nID: " + GetVehicleID() + 
                "\nAvailability: " + GetAvailabilityStatus(true) + 
                "\nMake: " + GetMake() + 
                "\nModel: "+ GetModel() + 
                "\nColour: " + GetColour()+
                "\nRegistration Plate: "+GetRegistrationPlate() + 
                "\n\nSpecifications: " + "\nAcceleration (0-60): " + GetAcceleration() + " seconds" + 
                "\nPower: " + GetPower()+" BHP"+ 
                "\nMileage: " + GetMileage() + " miles"+
                "\nFuel Economy: " + GetFuelEconomy()+ " MPG"+
                "\nTop speed: " + GetTopSpeed()+" MPH" +
                "\nNumber of doors: " + GetDoors()+
                "\nWeight of vehicle: " + GetWeight() + " kg"+
                "\nDrivetrain: " + GetDriveTrain()+
                "\nFuel Type: " + GetFuelType() +
                "\nEngine size: " + GetEngineSize() + "L"+
                "\nTransmission type: " + GetTransmission()+
                "\nSeat capacity: " + GetSeatCapacity()+
                "\nFuel capacity: " + GetFuelCapacity() + "L"+
                "\nWeight capacity: " + GetWeightCapacity() + " kg"+
                "\nLoad capacity: " + GetLoadCapacity() + " cubic feet"+
                "\nManufacturing year: " + GetYear()+
                "\nVehicle type: " + GetVehicleType()+
                "\nFeatures: " + GetFeatures()
                ;
        }*/

        /*public abstract void WriteBinary(BinaryWriter bw);
        public abstract void ReadBinary(BinaryReader br);*/
        /*vehicleID 
        availabilityStatus
        make 
        model
        colour 
        registrationPlate*/

        //public abstract void WriteBinary(BinaryWriter bw);
        //public abstract void ReadBinary(BinaryReader br);

        /*public override void WriteBinary(BinaryWriter bw)
        {
            *//*bw.Write("Special Vehicle");
            bw.Write(specialVehicleID);
            bw.Write(vehicleType);
            bw.Write(features);*//*

            bw.Write("\n\nVehice");
            bw.Write(vehicleID);
            bw.Write(availabilityStatus);
            bw.Write(make);
            bw.Write(model);
            *//*bw.Write(year);
            bw.Write(mileage);
            bw.Write(fuelType);
            bw.Write(transmission);
            bw.Write(capacity);*//*
        }*/

       /* public override void ReadBinary(BinaryReader br)
        {
            *//*this.specialVehicleID = br.ReadInt32();
            this.vehicleType = br.ReadString();
            this.features = br.ReadString();*//*

            this.vehicleID = br.ReadInt32();
            this.availabilityStatus = br.ReadBoolean();
            this.make = br.ReadString();
            this.model = br.ReadString();
    
            *//*this.year = br.ReadInt32();
            this.mileage = br.ReadInt32();
            this.fuelType = br.ReadString();
            this.transmission = br.ReadString();
            this.capacity = br.ReadInt32();*//*
        }*/

        


        public override string ToString()
        {
            return "\nVehicle ID " + vehicleID + "\nMake: " + make + "\nModel: " + model;
        }
    }
}