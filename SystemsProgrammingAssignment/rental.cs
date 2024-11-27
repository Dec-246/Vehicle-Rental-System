using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SystemsProgrammingAssignment
{
    internal class rental : vehicle
    {
        
            public int rentalID { get; set; }
            public DateTime rentalStartDate { get; set; }
            public DateTime rentalEndDate { get; set; }
            public int rentCost { get; set; }

        int Start = Convert.ToInt32(rentalStartDate);
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
            bw.Write(Name);
            bw.Write(year);
            bw.Write(mileage);
            bw.Write(availabilityStatus);
        }

        public override void ReadBinary(BinaryReader br)
        {
            this.rentalID = br.ReadInt32();
            this.Start = br.ReadInt32();
            this.End = br.ReadInt32();
            this.rentCost = br.ReadInt32();

            this.vehicleID = br.ReadInt32();
            this.Name = br.ReadString();
            this.year = br.ReadInt32();
            this.mileage = br.ReadInt32();
            this.availabilityStatus = br.ReadBoolean();
        }

        public override string ToString()
        {
            return "\n\nCustomer: " + "\nID: " + rentalID + "\nRental Start Date: " + Start + "\nRental End Date: " + End + "\nRental Cost: " + rentCost + "\nVehicle ID: " + vehicleID + "\nName: " + Name + "\nYear: " + year + "\nMileage: " + mileage + "\nAvailability Status: " + availabilityStatus;
        }

    }
}

/*public string OwnedProjectsNames { get; set; }*/ //names of owned projects

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