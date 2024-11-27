using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SystemsProgrammingAssignment
{
			//converting make and model to [Name]
			private string make;
			private string model;
	public class vehicle
    {
		class Vehicle
		{
		

			public string GetMake()
			{
				return make;
			}
			public void SetMake(string make)
			{
				this.make = make;
			}
			public string GetModel()
			{
				return model;
			}
			public void SetModel(string model)
			{ 
				this.model = model;
			}
			public void Name(string Make, string Model)
			{
				make += Make;
				model += Model;
			}

			public string Name { get { return model; } }
			public int vehicleID { get; set; }
			public int year { get; set; }
			public double mileage { get; set; }
			public bool availabilityStatus { get; set; }

            public abstract void WriteBinary(BinaryWriter bw);
            public abstract void ReadBinary(BinaryReader br);
        }	
	}
}
 

