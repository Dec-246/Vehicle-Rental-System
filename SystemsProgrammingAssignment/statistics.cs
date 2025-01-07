using System;

namespace SystemsProgrammingAssignment
{
	//create a dictionary of car stats| the user searches for model, the vehicle class info and stat info is displayed 

	//organise all stats into this class from the vehicle class 
	public class Statistics
	{
        protected float acceleration; //0-60 seconds
        protected int power; //BHP
		protected int mileage;
		protected int fuelEconomy; //MPG
		protected int topSpeed;
		protected int doors; // number of doors including boot
		protected float weight; //KG
		protected string driveTrain; //FWD, RWD, 4WD
        protected string fuelType; //petrol/ diesel/ hybrid/ electric
        protected float engineSize;
        protected string transmission; //automatic/ manual/ semi-automatic
        protected int seatCapacity; //seat capacity
		protected int fuelCapacity; // average 50L ***
		protected int weightCapacity; // what weight is loadable (kg)
		protected int loadCapacity; // what volume it can carry (cubic feet)
        protected int year; // year of manufacture
        protected string vehicleType; //super/ sports/ classic/ vans/ tanks/ helicopters/ 
        protected string features; //special features which separates this from the rest 

		/*public int mileage
		{
			get { return mileage(); }
			set { mileage = value; }
			}*/
        //Constructor
        public Statistics(float acceleration, int power, int mileage, int fuelEconomy, int topSpeed, int doors, float weight, string driveTrain, string fuelType, float engineSize, string transmission, int seatCapacity, int fuelCapacity, int weightCapacity, int loadCapacity, int year, string vehicleType, string features)
	{
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
		public Statistics()
		{

		}
	
		// Accessors / getters (include the data type of object)
		public float GetAcceleration() { return acceleration;  }
		public int GetPower() { return power;  }
		public int GetMileage() { return mileage; }
		public int GetFuelEconomy() { return fuelEconomy; }
		public int GetTopSpeed() { return topSpeed;  }
		public int GetDoors() { return doors; }
		public float GetWeight() { return weight; }
		public string GetDriveTrain() { return driveTrain; }
		public string GetFuelType() { return fuelType; }
		public float GetEngineSize() { return engineSize; }
		public string GetTransmission() { return transmission; }
		public int GetSeatCapacity() { return seatCapacity; }
		public int GetFuelCapacity() { return fuelCapacity; }
		public int GetWeightCapacity() { return weightCapacity; }
		public int GetLoadCapacity() { return loadCapacity; }
		public int GetYear() { return year; }
		public string GetVehicleType() { return vehicleType; }
		public string GetFeatures() { return features; }

		// Mutators / setters (void)
		public void SetAcceleration(float acceleration) { this.acceleration = acceleration; }
		public void SetPower(int power) { this.power = power; }
		public void SetMileage(int mileage) { this.mileage = mileage; }
		public void SetFuelEconomy(int fuelEconomy) { this.fuelEconomy = fuelEconomy; }
		public void SetTopSpeed (int topSpeed) { this.topSpeed = topSpeed; }
		public void SetDoors(int doors) { this.doors = doors; }
		public void SetWeight(int weight) { this.weight = weight; }
		public void SetDriveTrain(string driveTrain) { this.driveTrain = driveTrain; }
		public void SetFuelType(string fuelType) { this.fuelType = fuelType; }
		public void SetEngineSize(float engineSize) { this.engineSize = engineSize; }
		public void SetTransmission(string transmission) { this.transmission = transmission; }
		public void SetSeatCapacity(int seatCapacity) { this.seatCapacity = seatCapacity; }
		public void SetFuelCapacity(int fuelCapacity) { this.fuelCapacity = fuelCapacity; }
		public void SetWeightCapacity(int weightCapacity) { this.weightCapacity = weightCapacity; }
		public void SetLoadCapacity(int loadCapacity) { this.loadCapacity = loadCapacity; }
		public void SetYear(int year) { this.year = year; }
		public void SetVehicleType(string vehicleType) { this.vehicleType = vehicleType; }
		public void SetFeatures(string features) { this.features = features; }
    }
}

