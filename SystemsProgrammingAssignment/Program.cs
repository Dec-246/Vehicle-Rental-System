// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using SystemsProgrammingAssignment;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Introduction
//ask user for name and welcome them [output users name]


List<vehicle> vehicles = new List<vehicle>();

Customer customer = new Customer();
customer.customerID = 1;
customer.name = "Tom";



 while (true)
 {
     Console.WriteLine("\n1) Display stock list"); //displays list of vehicles
     /*Console.WriteLine("2) Add to guest list");*/
     Console.WriteLine("3) Rent Vehicle"); //updates vehicle data from system as being rented/ unavailable
     Console.WriteLine("4) Display number of vehicles"); //counts number of items on list of vehicles

    //include these
    Console.WriteLine("5) Return vehicle"); //asks user to enter name of vehicle details and adds them back into system
    Console.WriteLine("6) Display available vehicles"); //displays vehicles which are stated as being available
    Console.WriteLine("7) Display vehicles with low mileage"); //checks mileages that contain less than 30k [use TW1 (where function}]
    Console.WriteLine("8) Display newest vehicles"); //show vehicles where the year is within past 3 years [use SE2]
    Console.WriteLine("9) Extend rental period");
    Console.WriteLine("10) Make cancellation of rental");

    Console.WriteLine("Q) Quit \n");
 
     Console.Write("Enter your choice: ");
     string choice = Console.ReadLine().ToLower();
 
     if (choice == "q") break;
 
     if (choice == "1") Display();
     /*else if (choice == "2") Add();*/
     else if (choice == "3") Remove();
     else if (choice == "4") Count();
     else Console.WriteLine("Unknown option.");
 }


void Display()
{
    foreach (string guest in guests)
    {
        Console.WriteLine(guest);
    }
}

/*void Add()
{
    Console.Write("Please enter name to add: ");
    string name = Console.ReadLine();
    if (guests.Contains(name) == false)
    {
        guests.Add(name);
    }
}*/

void Remove()
{
    Console.Write("Please enter name to remove: ");
    string name = Console.ReadLine();
    guests.Remove(name);
}

void Count()
{
    Console.WriteLine("There are " + guests.Count + " guests on the list");

}

void Customer()
{
    //creating list of vehicle data
    FileStream fsw = new FileStream("vehicle.dat", FileMode.Create);
    BinaryWriter bw = new BinaryWriter(fsw);

    foreach (vehicle car in vehicles)
    {
        car.WriteBinary(bw);
    }

    bw.Close();
    fsw.Close();

    List<vehicle> customerFromList = new List<vehicle>();



    FileStream fsr = new FileStream("vehicle.dat", FileMode.Open);
    BinaryReader br = new BinaryReader(fsr);

    while (br.BaseStream.Position < br.BaseStream.Length)
    {
        vehicle car = null;
        /*string type = br.ReadString();
        if (type == "Customer")
        {
            car = new Customer();
            car.ReadBinary(br);
        }
        else if (type == "SeniorEngineer")
        {
            car = new SeniorEngineer();
            car.ReadBinary(br);
        }*/

        customerFromList.Add(car);
    }

    br.Close();
    fsr.Close();


    foreach (vehicle customer in customerFromList)
    {
        Console.WriteLine(/*$"\n\nType: {eng.GetType()}, " + */car.ToString());
        /*$"ID: {eng.Id}, Name: {eng.Name}, Salary: {eng.Salary}"*/
    }
}

