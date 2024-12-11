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
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;

////////////////////////////////////////////////////////////////////////////////////////////
///Dictionary | vehicles
Dictionary<string, vehicle> vehicles = new Dictionary<string, vehicle>();
//dictionary models of vehicles.
// this allows user to search for model and then will pop up with data on that model

//( ID|Available| Make |             Model|        fuel type | eng size|transm|      seat cap|manf year|mileage| colour|  | reg plate)
vehicles.Add("test", new vehicle(1, true, "ford", "test", "red", "xs19 tye", 6.7f, 150, 200000, 50, 110, 5, 1500, "fwd", "petrol", 2.7f, "manual", 4, 50, 100, 90, 2012, "sedan", "digital radio"));

/*vehicles.Add("raptor",   new specialVehicle(1, true,    "ford",             "raptor",       "diesel",  3.0f, "manual",           5, 2019,      "grey",     "xt19 xtz",   1,  "truck",    "all-terrain"));
vehicles.Add("mondeo",   new specialVehicle(2, true,    "ford",             "mondeo",       "petrol",  1.6f, "manual",           5, 2010,      "blue",     "dt10 sdt",   2,  "sedan",    "Plug-in aux"));
vehicles.Add("mustang",  new specialVehicle(3, true,    "ford",             "mustang",      "diesel",  3.4f, "manual",           5, 2016,      "bredlue",  "sk16 qod",   3,  "sports",   "v8 engine"));
vehicles.Add("gt",       new specialVehicle(4, true,    "ford",             "gt",           "petrol",  4.0f, "manual",           5, 2019,      "black",    "dl19 tdy",   4, "super", "won most streak of Le Mans' races"));
vehicles.Add("f-150",    new specialVehicle(5, true,    "ford",             "f-150",        "diesel",  2.6f, "semi-automatic",   5, 2020,      "blue",     "gf20 gts",   5, "truck", "On- board wifi"));

vehicles.Add("vulcan",   new specialVehicle(6, true,   "aston martin",     "vulcan",       "diesel",  5.0f, "manual",           2, 2023,       "black",   "aw23 fdh",   6, "hyper", "v8 engine"));
vehicles.Add("db11",     new specialVehicle(7, false,  "aston martin",     "db11",         "petrol",  3.0f, "manual",           2, 2022,       "grey",    "ad22 sht",   7, "sports", "v8 engine"));
vehicles.Add("vantage",  new specialVehicle(8, false,  "aston martin",     "vantage",      "petrol",  4.0f, "automatic",        2, 2014,       "White",   "pd14 sgw",   8, "sports", "v8 engine"));
vehicles.Add("dbx",      new specialVehicle(9, false,  "aston martin",     "dbx",          "diesel",  3.6f, "manual",           2, 2022,       "White",   "zx22 skd",   9, "sports", "v8 engine"));
vehicles.Add("valhalla", new specialVehicle(10, true,  "aston martin",     "valhalla",     "petrol",  5.0f, "manual",           2, 2024,       "White",   "al24 oqw",   10, "sports", "v8 engine"));

vehicles.Add("taycan", new specialVehicle(11, true,  "porsche",      "taycan",       "diesel",  3.0f,       "manual",               5, 2019,           "Orange", "ap19 akd",   11, "sports", "v8 engine"));
vehicles.Add("911", new specialVehicle(12, false, "porsche",      "911",          "petrol",  3.0f,          "manual",                  2, 2016,              "Orange", "oi16 ajd",   12, "sports", "v8 engine"));
vehicles.Add("cayenne",    new specialVehicle(13, true,  "porsche",      "cayenne",      "diesel",  3.0f,   "automatic",        5, 2016,       "Orange", "ql16 qkw",   13, "sports", "v8 engine"));
vehicles.Add("911 gt3 rs", new specialVehicle(14, false, "porsche",      "911 gt3 rs",   "petrol",  3.0f,   "manual",           2, 2022,       "Orange", "ao22 ake",   14, "sports", "v8 engine"));
vehicles.Add("boxter", new specialVehicle(15, true,  "porsche",      "boxter",       "petrol",  3.0f,       "manual",               2, 2014,           "Orange", "we14 wed",   15, "sports", "v8 engine"));

vehicles.Add("polo", new specialVehicle(16, false, "volksWagen",   "polo",        "diesel",   2.0f,         "manual",               5, 2010,             "White", "ad10 adk",   16, "sports", "v8 engine"));
vehicles.Add("golf gti", new specialVehicle(17, true,  "volksWagen",   "golf gti",    "petrol",   2.0f,     "manual",           5, 2016,         "Black", "ao16 ajd",   17, "sports", "v8 engine"));
vehicles.Add("passat", new specialVehicle(18, false, "volksWagen",   "passat",      "diesel",   2.0f,       "automatic",          5, 2020,           "Black", "ad20 ahj",   18, "sports", "v8 engine"));
vehicles.Add("tiguan", new specialVehicle(19, true,  "volksWagen",   "tiguan",      "petrol",   3.0f,       "manual",             5, 2014,           "Black", "am14 afu",   19, "sports", "v8 engine"));
vehicles.Add("transporter", new specialVehicle(20, true,  "volksWagen",   "transporter", "petrol",   3.0f,  "automatic",     5, 2012,      "Black", "as12 ajg",   20, "sports", "v8 engine"));

vehicles.Add("599xx evo", new specialVehicle(21, true, "ferrari", "599xx evo", "petrol", 6.0f, "manual", 2, 2012, "red", "cv12 amb", 21, "track", "high-performance"));*/
////////////////////////////////////////////////////////////////////////////////////////////
// Customers 



////////////////////////////////////////////////////////////////////////////////////////////
//Introduction
//ask user for name and welcome them [output users name]

foreach (string arg in args)
{
    Console.WriteLine(arg);
}

if (args[0] == "--adminmode")
{
    //admin mode
    adminMenu();
}
if (args[0] == "--existingusermode")
{
    //user mode
    existingUserMenu();
} 
else if (args[0] == "--newusermode")
{
    newUserMenu();
}

void adminMenu()
{
    Console.WriteLine("Welcome back Admin");

    Console.WriteLine("\n1) Display stock list"); //displays list of vehicles

    Console.WriteLine("\n) Add vehicle to system"); //Adds vehicle to the dictionary and list of vehicles

    Console.WriteLine("\n) Add customer to system"); //Adds customer to the list of customers

    Console.WriteLine("Q) Quit \n");

    Console.Write("Enter your choice: ");
    string choice = Console.ReadLine().ToLower();

    if (choice == "q")
    {
        Console.WriteLine("Thank you for using our system");
        return;
    }
}

void existingUserMenu()   //[NE1]
{
    //existing customer? or new customer?
    while (true)
    {
        Console.WriteLine("Please enter your name! ");
        string username = Console.ReadLine();
        Console.WriteLine($"\nWelcome back {username}!");


        Console.WriteLine("\nMenu\n");
        

        Console.WriteLine("2) Return vehicle"); //asks user to enter name of vehicle details and adds them back into system

        Console.WriteLine("3) Extend rental period"); //Add x amount of days to remaining time left of rental period

        Console.WriteLine("4) Make cancellation of rental");

        Console.WriteLine("5) Rent Vehicle"); //updates vehicle data from system as being rented/ unavailable

        Console.WriteLine("6) Search for vehicle"); //displays list of all vehicles

        Console.WriteLine("7) Display stock list"); //displays list of all vehicles

        Console.WriteLine(") Display number of vehicles"); //counts number of items on list of vehicles

        Console.WriteLine(") Display available vehicles"); //displays vehicles which are stated as being available

        Console.WriteLine(") Display vehicles with low mileage"); //checks mileages that contain less than 30k [use TW1 (where function}]

        Console.WriteLine(") Display newest vehicles"); //show vehicles where the year is within past 3 years [use SE2]

        Console.WriteLine(") Contact us");

        Console.WriteLine("\nQ) Quit \n");

        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine().ToLower();


        if (choice == "q") break;

        if (choice == "1") ;
        else if (choice == "2") ;
        else if (choice == "3") ;
        else if (choice == "4") ;
        else if (choice == "5") ;
        else if (choice == "6") SearchForVehicle();
        else if (choice == "7") ;
        else if (choice == "8") ;
        else if (choice == "9") ;
        else if (choice == "10") ;
        else
        {
            Console.WriteLine("ERROR: unknown input!");
        }
    }
}
void newUserMenu()
{
    while (true)
    {

        Console.WriteLine("Please enter your name! ");
        string username = Console.ReadLine();
        Console.WriteLine($"\nWelcome {username}!");

        Console.WriteLine("\nMenu\n");

        Console.WriteLine("1) Add customer details to system"); //Add users details to the customer list and then save to binary read/ write file
    
        Console.WriteLine("5) Rent Vehicle"); //updates vehicle data from system as being rented/ unavailable

        Console.WriteLine("6) Search for vehicle"); //displays list of all vehicles

        Console.WriteLine("7) Display stock list"); //displays list of all vehicles

        Console.WriteLine(") Display number of vehicles"); //counts number of items on list of vehicles

        Console.WriteLine(") Display available vehicles"); //displays vehicles which are stated as being available

        Console.WriteLine(") Display vehicles with low mileage"); //checks mileages that contain less than 30k [use TW1 (where function}]

        Console.WriteLine(") Display newest vehicles"); //show vehicles where the year is within past 3 years [use SE2]

        Console.WriteLine(") Contact us");

        Console.WriteLine("\nQ) Quit \n");

        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine().ToLower();


        if (choice == "q") break;

        if (choice == "1") ;
        else if (choice == "2") ;
        else if (choice == "3") ;
    }
}

void SearchForVehicle()
{
    vehicle selectedVehicle;

    //user input asking for their model of interest
    Console.WriteLine("\n What vehicle model are you looking for today? \n");
    string vehicleSearch = Console.ReadLine().ToLower();

    //outputting result
    Console.WriteLine("\n These are the vehicles we have with your applied search: \n");
    
    // this allows user to search for vehicle from dictionary 
    
    if (vehicles.ContainsKey(vehicleSearch))
    {
        selectedVehicle = vehicles[vehicleSearch];
    
        // Print out basic information 
        Console.WriteLine("Basic information: ");
        Console.WriteLine("vehicle ID: " + selectedVehicle.GetVehicleID());
    
        if (selectedVehicle.GetAvailabilityStatus(true)) { Console.WriteLine("vehicle availability status: available"); }
        else { Console.WriteLine("vehicle availability status: Unavailable"); }
    
        Console.WriteLine("Make: " + selectedVehicle.GetMake());
        Console.WriteLine("Model: " + selectedVehicle.GetModel());
        Console.WriteLine("Colour: " + selectedVehicle.GetColour());
        Console.WriteLine("Registration Plate: " + selectedVehicle.GetRegistrationPlate().ToUpper());
    
        //Print out stats
        Console.WriteLine("\nWould you like to display the statistics of this vehicle? ");
        string DisplayStats = Console.ReadLine().ToLower();

        if (DisplayStats == "yes")
        {
            Console.WriteLine("Statistics: ");

            Console.WriteLine("Acceleration (0-60): " + selectedVehicle.GetAcceleration() + " seconds"); //acceleration 0-60
            Console.WriteLine("Power: " + selectedVehicle.GetPower() + " horsepower"); //bhp
            Console.WriteLine("Mileage: " + selectedVehicle.GetMileage() + " miles");
            Console.WriteLine("Fuel Economy: " + selectedVehicle.GetFuelEconomy() + " mpg"); //mpg
            Console.WriteLine("Top speed: " + selectedVehicle.GetTopSpeed() + " mph"); //top speed
            Console.WriteLine("Number of doors: " + selectedVehicle.GetDoors()); //number of doors
            Console.WriteLine("Weight of vehicle: " + selectedVehicle.GetWeight() + " kg"); //weight of vehicle (kg)
            Console.WriteLine("Drivetrain: " + selectedVehicle.GetDriveTrain()); //drivetrain
            Console.WriteLine("Fuel Type: " + selectedVehicle.GetFuelType());
            Console.WriteLine("Engine size: " + selectedVehicle.GetEngineSize() + "L");
            Console.WriteLine("Transmission type: " + selectedVehicle.GetTransmission());
            Console.WriteLine("Seat capacity: " + selectedVehicle.GetSeatCapacity());
            Console.WriteLine("Fuel capacity: " + selectedVehicle.GetFuelCapacity() + "L"); //fuel capacity (how many litres of fuel can be stored)
            Console.WriteLine("Weight capacity: " + selectedVehicle.GetWeightCapacity() + " kg"); //weight capacity
            Console.WriteLine("Load capacity: " + selectedVehicle.GetLoadCapacity() + " cubic feet"); //load capacity (volume/ m3)
            Console.WriteLine("Manufacturing year: " + selectedVehicle.GetYear());
            Console.WriteLine("Vehicle type: " + selectedVehicle.GetVehicleType()); // vehicle type
            Console.WriteLine("Features: " + selectedVehicle.GetFeatures()); // features

        }
        else if (DisplayStats == "no")
        {
            return;
        }
    }
    else
    {
        Console.WriteLine("We could not find a result for your request! \n");
        return;
    }
    Console.WriteLine("\n------------------------------------------------------------------------------");
}


/*List<vehicle> vehicles = new List<vehicle>();
List<Customer> customers = new List<Customer>();

vehicle car = new vehicle();
car.SetVehicleID(1);
car.SetAvailabilityStatus(true);
car.SetMake("Ford");
car.SetModel("Capri");
car.SetFuelType("Petrol");
car.SetEngineSize(2.0f);
car.SetTransmission("Manual");
car.SetCapacity(5);
car.SetYear(1980);
car.SetMileage(170_000);
car.SetColour("Red");
vehicles.Add(car);*/


// adds customer1 to class
//Customer customer1 = new Customer(1, "Tom derick", "tom@gmail.com", "07 345 134 777", "(1) Ford Mondeo, " + "(2)Ford Mustang");
// outputs customer 1 data
//Console.WriteLine($"Customer ID: {customer1.GetCustomerID()}\nName: {customer1.GetName()}\nEmail: {customer1.GetEmail()}\nMobile Number: {customer1.GetMobileNumber()}\nRented Vehicles: {customer1.GetRentedVehicles()}");