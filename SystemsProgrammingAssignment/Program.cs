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
using System.Xml.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Threading;
using System.Net.NetworkInformation;
using System.Diagnostics.Metrics;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using System.Reflection.Metadata;

////////////////////////////////////////////////////////////////////////////////////////////
///Dictionary | vehicles
Dictionary<string, Vehicle> vehicles = new Dictionary<string, Vehicle>();
//dictionary models of vehicles.
// this allows user to search for model and then will pop up with data on that model

//( ID|Available| Make |             Model|        fuel type | eng size|transm|      seat cap|manf year|mileage| colour|  | reg plate)
vehicles.Add("test",    new Vehicle(1, false, "ford", "test", "red", "xs19 tye", 6.7f, 150, 200000, 50, 110, 5, 1500, "fwd", "petrol", 2.7f, "manual", 4, 50, 100, 90, 2012, "sedan", "digital radio"));
vehicles.Add("mondeo",  new Vehicle(2, false, "ford", "mondeo", "red", "xs19 tye", 6.7f, 150, 200000, 50, 110, 5, 1500, "fwd", "petrol", 2.7f, "manual", 4, 50, 100, 90, 2012, "sedan", "digital radio"));
vehicles.Add("mustang", new Vehicle(3, false, "ford", "mustang", "red", "xs19 tye", 6.7f, 150, 200000, 50, 110, 5, 1500, "fwd", "petrol", 2.7f, "manual", 4, 50, 100, 90, 2024, "sedan", "digital radio"));
vehicles.Add("gt",      new Vehicle(4, true, "ford", "gt", "red", "xs19 tye", 6.7f, 150, 20000, 50, 110, 5, 1500, "fwd", "petrol", 2.7f, "manual", 4, 50, 100, 90, 2023, "sports", "digital radio"));
vehicles.Add("f-150",   new Vehicle(5, false, "ford", "f-150", "red", "xs19 tye", 6.7f, 150, 2000, 50, 110, 5, 1500, "fwd", "petrol", 2.7f, "manual", 4, 50, 100, 90, 2022, "truck", "digital radio"));


/////////////////////////////////////////////////////////////////////
//using Json to [write] list to a file
// the file stores the model of vehicles within the system
string jsonString = JsonSerializer.Serialize(vehicles);
File.WriteAllText("stockList.json", jsonString);
/////////////////////////////////////////////////////////////////////
///


/////////////////////////////////////////////////////
//write all text to vehicle list 
// this file is used to return a vehicle
string vehicleList = "vehicleList.json";
string json = JsonSerializer.Serialize(vehicles);
File.WriteAllText(vehicleList, json);
/////////////////////////////////////////////////////


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
// user can be found via their customer ID
Dictionary<int, User> users = new Dictionary<int, User>();
users.Add(1, new User(1, "John Stone", "johns@gmail.com", "07123582538"));
users.Add(2, new User(2, "Tim Dents", "timd@gmail.com", "07123537538"));

string NewUser = "NewUser.json";
string jsonString3 = JsonSerializer.Serialize(users);
File.WriteAllText(NewUser, jsonString3);


///////////////////////////////////////////////////////////////////////////////////////////////////////////////
Dictionary<int, ExistingUser> returningCustomers = new Dictionary<int, ExistingUser>();
returningCustomers.Add(1, new ExistingUser(1, "Timothy Roscoe", "TimRos@gmail.com", "07 123 456 789", new List<Rental>()));
returningCustomers.Add(2, new ExistingUser(2, "John Siletto", "JohnS@gmail.com", "07 123 456 789", new List<Rental>()));

// asserting information to the Rental list for each customer
DateTime startDate = new DateTime(2024, 12, 12, 10, 10, 10);
DateTime endDate = new DateTime(2024, 12, 14, 10, 10, 10);
//                         start date|end date|daily rate|deposit|rental status|vID|availability status|make|model|colour|reg plate
Rental rental1 = new Rental(startDate, endDate, 20, 200, true, 2, false, "ford", "mondeo", "red", "xs19 tye");
returningCustomers[1].AddRental(rental1);


Rental rental2 = new Rental(startDate, endDate, 20, 200, true, 2, false, "ford", "bronco", "blue", "xs19 tye");
returningCustomers[2].AddRental(rental2);


//if i had more time, i would improve this file save functionality to save the details from the list of rentals for each user.//
// creating a file for returning customers data
//using Json to [write] list to a file
string CustomReturn = "returningCustomers.json";
string jsonString2 = JsonSerializer.Serialize(returningCustomers);
File.WriteAllText(CustomReturn, jsonString2);


//[SW3] hashlist of users?
// add users id to haslist- makes users unique

////////////////////////////////////////////////////////////////////////////////////////////
//Introduction
//ask user for name and welcome them [output users name]

// ask user for their user ID- this will search from dictionary of customers (this will be stored in binary file)
// the users email will be displayed and ask the user whether this is correct, will then display the rest of users info


foreach (string arg in args)
{
    Console.WriteLine(arg);
}

if (args.Length == 1)
{
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
    else if (args[0] == "--help")
    {
        Console.WriteLine("Help Menu: \n");
        Console.WriteLine("If you are a returning customer:  SystemsProgrammingAssignment.exe --existingusermode");
        Console.WriteLine("If you are a new customer:        SystemsProgrammingAssignment.exe --newusermode");
    }
    else
    {
        Console.WriteLine("Please use the following command prompt: SystemsProgrammingAssignment.exe --help \n");
    }
}
else
{
    Console.WriteLine("Please use the following command prompt: SystemsProgrammingAssignment.exe --help \n");
    
}

void adminMenu()
{
    bool AdminMenu = true;
    while (AdminMenu)
    {
        Console.WriteLine("Welcome back Admin");

        Console.WriteLine("\n1) Display stock list"); //displays list of vehicles

        Console.WriteLine("\n2) Display all customer and rental info ");

        Console.WriteLine("\n) Add vehicle to system"); //Adds vehicle to the dictionary and list of vehicles

        Console.WriteLine("\n) Add customer to system"); //Adds customer to the list of customers

        Console.WriteLine("Q) Quit \n");

        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine().ToLower();

        switch (choice)
        {
            case "1":
                DisplayStockList();
                break;

            case "2":
                DisplayUserRentalInfo();
                break;

            case "3":
                AddVehicle();
                break;

            case "4":
                AddUser();
                break;

            case "q":
                AdminMenu = false;
                break;

            default:
                Console.WriteLine("ERROR: unknown input!");
                break;
        }
    }
}

void DisplayUserRentalInfo()
{
    {
        foreach (KeyValuePair<int, ExistingUser> user in returningCustomers)
        {
            Console.WriteLine("\n------------------------------------------------------------------------------");

            //Console.WriteLine($"Customer Info:\n \nCustomer ID: {user.Value.GetUserID()} \nName: {user.Value.GetName()} \nEmail: {user.Value.GetEmail()} \nMobile Number: {user.Value.GetMobileNumber()}");

            List<Rental> rentals = user.Value.GetRentals();

            if (rentals.Count == 0)
            {
                Console.WriteLine("\nUsers rental info cannot be retrieved from system! ");
            }
            else
            {
                Console.WriteLine("\nRental info: ");
                foreach (Rental rental in rentals)
                {
                    if (rental.GetActivityStatus(true))
                    {
                        Console.WriteLine($"\nRental Status: Active \nRental Period:{rental.GetStartDate()} to {rental.GetEndDate()}, \nMake: {rental.GetMake().ToUpper()} \nModel: {rental.GetModel().ToUpper()} \nTotal fee: £{rental.RentCharge()} \n");

                    }
                    else if (rental.GetActivityStatus(false))
                    {
                        Console.WriteLine($"\nRental Status: Inactive \nRental Period:{rental.GetStartDate()} to {rental.GetEndDate()}, \nMake: {rental.GetMake().ToUpper()} \nModel: {rental.GetModel().ToUpper()} \nTotal fee: £{rental.RentCharge()} \n");
                    }
                }
            }
            Console.WriteLine("------------------------------------------------------------------------------\n");

        }
    }
}

// Main user menu
void existingUserMenu()   //[NE1]
{
    //existing customer? or new customer?
    bool ExistingUserMenu = true;
    while (ExistingUserMenu)
    {
        int processors = Environment.ProcessorCount;
        Console.WriteLine("\n\nThis computer has " +  processors + " processors. ");

        Console.WriteLine("\nMenu\n");

        Console.WriteLine("1) View current rental information. "/*displays: rental period / total cost / daily pay rate, vehicle info*/ +
            "\n2) Return vehicle" /*asks user to enter name of vehicle details and adds them back into system*/+
            "\n3) Extend rental period" /*Add x amount of days to remaining time left of rental period*/ +
            "\n4) Make cancellation of rental" /*cancel vehicle rental before end date*/ +
            "\n5) Rent Vehicle" /*updates vehicle data from system as being rented / unavailable*/ +
            "\n6) Search for vehicle" /*displays list of all vehicles*/ +
            "\n7) Display stock list" /*displays list of all vehicles*/ +
            "\n8) Display number of vehicles" /*counts number of items on list of vehicles*/ +
            "\n9) Search for vehicle availability" /*displays vehicles which are stated as being available*/ +
            "\n10) Display vehicles mileage" /*checks mileages that contain less than 30k[use TW1(where function}]*/ +
            "\n11) Display newest vehicles" /*show vehicles where the year is within past 3 years[use SE2]*/ +
            "\n12) Contact us \n\nQ) Quit ");
        Console.Write("\n\nEnter your choice: ");
        string choice = Console.ReadLine().ToLower();

        switch (choice)
        {
            case "1":
                // change back to rental info function 
                RentalInfo();
                break;

            case "2":
                ReturnVehicle();
                break;

            case "3":
                ExtendRentalPeriod();
                break;

            case "4":
                CancelRental();
                break;

            case "5":
                RentVehicle();
                break;

            case "6":
                SearchForVehicle();
                break;

            case "7":
                DisplayStockList();
                break;

            case "8":
                TotalVehicleCount();
                break;

            case "9":
                SearchVehicleAvailability();
                break;

            case "10":
                Mileage();
                break;

            case "11":
                VehicleManufactureYear();
                break;

            case "12":
                Contact();
                break;

            case "q":
                ExistingUserMenu = false;
                break;

            default:
                Console.WriteLine("ERROR: unknown input!");
                break;
        }
    }
}

void newUserMenu()
{
    bool NewUserMenu = true;
    while (NewUserMenu)
    {
        Console.WriteLine("\nMenu\n");

        Console.WriteLine("1) Add customer details to system"); //Add users details to the customer list and then save to binary read/ write file
    
        Console.WriteLine("2) Rent Vehicle"); //updates vehicle data from system as being rented/ unavailable

        Console.WriteLine("3) Search for vehicle"); //search from list of all vehicles

        Console.WriteLine("4) Display stock list"); //displays list of all vehicles

        Console.WriteLine("5) Display number of vehicles"); //counts number of items on list of vehicles

        Console.WriteLine("6) Display vehicles with low mileage"); //checks mileages that contain less than 30k [use TW1 (where function}]

        Console.WriteLine("7) Display newest vehicles"); //show vehicles where the year is within past 3 years [use SE2]

        Console.WriteLine("8) Display user information");

        Console.WriteLine("9) Contact us");

        Console.WriteLine("\nQ) Quit \n");

        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine().ToLower();

        switch (choice)
        {
            case "1":
                AddUser();
                break;

            case "2":
                RentVehicle();
                break;

            case "3":
                SearchVehicleAvailability();
                break;

            case "4":
                DisplayStockList();
                break;

            case "5":
                TotalVehicleCount();
                break;

            case "6":
                Mileage();
                break;

            case "7":
                VehicleManufactureYear();
                break;

            case "8":
                DisplayNewUserInfo();
                break;

            case "9":
                Contact();
                break;

            case "q":
                NewUserMenu = false;
                break;

            default:
                Console.WriteLine("ERROR: unknown input!");
                break;
        }
    }
} 

void AddUser()
{
    //add new user to the users list 
    Console.WriteLine("\nPlease enter your first and second name! ");
    string newUserName = Console.ReadLine().ToLower();

    Console.WriteLine("\nPlease enter your email! ");
    string newUserEmail = Console.ReadLine().ToLower();

    Console.WriteLine("\nPlease enter your mobile number! ");
    string newUserNumber = Console.ReadLine().ToLower();

    // for every new entry, the system adds 1 to the ID (key) numbers within the dictionary.
  
    Random random = new Random();
    int randomID = random.Next(0, 100000);

    users.Add(randomID, new User(randomID, newUserName, newUserEmail, newUserNumber));
    Console.WriteLine($"Your ID number is {randomID}");

    File.WriteAllText(NewUser, jsonString3);
}

void AddVehicle()
{
    //add new vehicle to the system 
    Console.WriteLine("\nPlease enter the following information! \n\n");

    Console.WriteLine("Vehicle ID: ");
    int VID = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nAvailability Status: ");
    bool availability = Convert.ToBoolean(Console.ReadLine());

    Console.WriteLine("\nMake: ");
    string make = Console.ReadLine().ToLower();

    Console.WriteLine("\nModel: ");
    string model = Console.ReadLine().ToLower();

    Console.WriteLine("\nColour: ");
    string colour = Console.ReadLine().ToLower();

    Console.WriteLine("\nRegistration Plate: ");
    string registrationPlate = Console.ReadLine().ToLower();

    Console.WriteLine("\nAcceleration: ");
    float acceleration = Convert.ToSingle(Console.ReadLine());

    Console.WriteLine("\nPower (BHP): ");
    int power = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nMileage: ");
    int mileage = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nFuel Economy (MPG): ");
    int fuelEconomy = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nTop speed: ");
    int topSpeed = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nDoors (number of doors including boot): ");
    int doors = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nWeight (KG): ");
    float weight = Convert.ToSingle(Console.ReadLine());

    Console.WriteLine("\nDrive Train: ");
    string driveTrain = Console.ReadLine().ToLower();

    Console.WriteLine("\nFuel Type: ");
    string fuelType = Console.ReadLine().ToLower();

    Console.WriteLine("\nEngine Size: ");
    float engineSize = Convert.ToSingle(Console.ReadLine());

    Console.WriteLine("\nTransmission: ");
    string transmission = Console.ReadLine().ToLower();

    Console.WriteLine("\nSeat Capacity: ");
    int seatCapacity = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nFuel Capacity: ");
    int fuelCapacity = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nWeight Capacity: ");
    int weightCapacity = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nLoad Capacity: ");
    int loadCapacity = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nYear: ");
    int year = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("\nVehicle Type: ");
    string vehicleType = Console.ReadLine().ToLower();

    Console.WriteLine("\nFeatures: ");
    string features = Console.ReadLine().ToLower();

    vehicles.Add(model, new Vehicle(VID, availability, make, model, colour, registrationPlate, acceleration, power, mileage, fuelEconomy, topSpeed, doors, weight, driveTrain, fuelType, engineSize, transmission, seatCapacity, fuelCapacity, weightCapacity, loadCapacity, year, vehicleType, features));
}

void ReturnVehicle()
{
    Console.WriteLine("Please enter the name of the vehicle that you want to return!");
    string VehicleReturn = Console.ReadLine().ToLower();

    // display availability status of vehicle
    if (vehicles.ContainsKey(VehicleReturn))
    {
        Vehicle selectedVehicle;
        selectedVehicle = vehicles[VehicleReturn];

        //reads file from vehicle list 
        readVehicleFile();

        //checks if status is available
        if (selectedVehicle.GetAvailabilityStatus(true)) 
        { 
            Console.WriteLine("This vehicle is already available. Therefore, it cannot be returned."); 
        }
        else {
            //if status is unavailable, it changes it to being available as the customer has just returned it.
            selectedVehicle.SetAvailabilityStatus(true);

            //writes to vehicle list file
           /* writeVehicleFile();*/

            try 
            {
                //displays make and model of the car that the user has just returned
                Console.WriteLine($"\nThank you! The | {selectedVehicle.GetMake().ToUpper()}: {selectedVehicle.GetModel().ToUpper()} | has successfully been returned ");

            }catch (NullReferenceException)
            {
                Console.WriteLine("We could not find a result for your request! ");
                return;
            }
        }
    }

    
}

void readVehicleFile()
{
    //using Json to [read] list to a file
    // this file is used to return a vehicle
    string json = File.ReadAllText("vehicleList.json");
    var cars = JsonSerializer.Deserialize<Dictionary<string, Vehicle>>(json);
}

void DisplayUserInfo()
{
    ExistingUser selectedCustomer = SearchCustomerID();
}

void DisplayNewUserInfo()
{

    User selectedCustomer = SearchNewCustomerID();
    /*string NewUser = "NewUser.json";
    string jsonString3 = File.ReadAllText(NewUser);
    var users = JsonSerializer.Deserialize<Dictionary<int, User>>(jsonString3);*/
}

void RentalInfo()
{
    ExistingUser selectedCustomer = SearchCustomerID();

    foreach (var r in selectedCustomer.GetRentals())
    {

            Console.WriteLine($"\nRental info: ");

        if (r.GetActivityStatus(true))
        {
            Console.WriteLine($"\nRental Status: Active \nRental Period:{r.GetStartDate()} to {r.GetEndDate()}, \nMake: {r.GetMake().ToUpper()} \nModel: {r.GetModel().ToUpper()} \nTotal fee: £{r.RentCharge()}");
        }
        else if (r.GetActivityStatus(false))
        {
            Console.WriteLine($"\nRental Status: Inactive \nRental Period:{r.GetStartDate()} to {r.GetEndDate()}, \nMake: {r.GetMake().ToUpper()} \nModel: {r.GetModel().ToUpper()} \nTotal fee: £{r.RentCharge()}");
        }
        else
        {
            Console.WriteLine("ERROR: Result not found! ");
            return;
        }
    }
}

User SearchNewCustomerID()
{
    User selectedCustomer;

    //ask user for their ID
    Console.Write("\n Please enter your customer ID: ");
    int customerSearch = Convert.ToInt32(Console.ReadLine());

    // this allows user to search for vehicle from dictionary 
    if (users.ContainsKey(customerSearch))
    {
        //outputting result
        selectedCustomer = users[customerSearch];
        Console.WriteLine($"\nWelcome back: {selectedCustomer.GetName()} \n\n\nCustomer Information: \n\nCustomer ID: {selectedCustomer.GetUserID()} \nEmail: {selectedCustomer.GetEmail()} \nMobile number: {selectedCustomer.GetMobileNumber()}");
        return selectedCustomer; //returns customer within system
    }
    else
    {
        Console.WriteLine("We could not find a result on our system! \n");
        return null; //returns nothing 
    }
}

ExistingUser SearchCustomerID()
{
    // created this function as it is included within two other functions (rental info & display user info)
    ExistingUser selectedCustomer;

    //ask user for their ID
    Console.Write("\n Please enter your customer ID: ");
    int customerSearch = Convert.ToInt32(Console.ReadLine());

    // this allows user to search for vehicle from dictionary 
    if (returningCustomers.ContainsKey(customerSearch))
    {
        //outputting result
        selectedCustomer = returningCustomers[customerSearch];
        Console.WriteLine($"\nWelcome back: {selectedCustomer.GetName()} \n\n\nCustomer Information: \n\nCustomer ID: {selectedCustomer.GetUserID()} \nEmail: {selectedCustomer.GetEmail()} \nMobile number: {selectedCustomer.GetMobileNumber()}");
        return selectedCustomer; //returns customer within system
    }
    else
    {
        Console.WriteLine("We could not find a result on our system! \n");
        return null; //returns nothing 
    }
}

void ExtendRentalPeriod()
{
    ExistingUser selectedCustomer = SearchCustomerID();

    /*foreach (var r in selectedCustomer.GetRentals())
    {
        var timer = Stopwatch.StartNew();
        Console.WriteLine($"\nCurrent Rental info: {r.GetStartDate()} to {r.GetEndDate()}, \nMake: {r.GetMake().ToUpper()} \nModel: {r.GetModel().ToUpper()} \nTotal fee: £{r.RentCharge()}");
        Console.WriteLine("Time taken: " + timer.ElapsedMilliseconds + "ms");
    }*/

    // Parallel splits the tasks between all processors to make the task run/ output results faster
    Parallel.ForEach(selectedCustomer.GetRentals(), r =>
    {
        var timer = Stopwatch.StartNew();
        // Displays current rental information
        Console.WriteLine($"\nCurrent Rental info: {r.GetStartDate()} to {r.GetEndDate()}, \nMake: {r.GetMake().ToUpper()} \nModel: {r.GetModel().ToUpper()} \nTotal fee: £{r.RentCharge()}");
        Console.WriteLine("Time taken: " + timer.ElapsedMilliseconds + "ms");
    });

    Console.WriteLine("Please enter the extended date: (year/month/day/ hour:minute:second)\n");
    DateTime extendedDate = Convert.ToDateTime(Console.ReadLine());

    endDate = extendedDate;

    /*foreach (var r in selectedCustomer.GetRentals())
    {
        r.SetEndDate(extendedDate);
        Console.WriteLine($"\nNew Rental info: {r.GetStartDate()} to {r.GetEndDate()}, \nMake: {r.GetMake().ToUpper()} \nModel: {r.GetModel().ToUpper()} \nTotal fee: £{r.RentCharge()}");
    }*/

    Parallel.ForEach(selectedCustomer.GetRentals(), r =>
    {
        //Console.WriteLine($"\nCurrent Rental info: {r.GetStartDate()} to {r.GetEndDate()}, \nMake: {r.GetMake().ToUpper()} \nModel: {r.GetModel().ToUpper()} \nTotal fee: £{r.RentCharge()}");
        var timer2 = Stopwatch.StartNew();
        r.SetEndDate(extendedDate);
        Console.WriteLine($"\nNew Rental info: {r.GetStartDate()} to {r.GetEndDate()}, \nMake: {r.GetMake().ToUpper()} \nModel: {r.GetModel().ToUpper()} \nTotal fee: £{r.RentCharge()}");
        Console.WriteLine("Time taken: " + timer2.ElapsedMilliseconds + "ms");
    });
}

void SearchForVehicle()
{
    Vehicle selectedVehicle;

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
        Console.WriteLine($"\nBasic information: \nVehicle ID: {selectedVehicle.GetVehicleID()}");

        if (selectedVehicle.GetAvailabilityStatus(true)) { Console.WriteLine("Vehicle availability status: available"); }
        else { Console.WriteLine("Vehicle availability status: Unavailable"); }

        Console.WriteLine($"Make: {selectedVehicle.GetMake()} \nModel: {selectedVehicle.GetModel()} \nColour: {selectedVehicle.GetColour()} \nRegistration Plate: {selectedVehicle.GetRegistrationPlate().ToUpper()}");


        //Print out stats
        Console.WriteLine("\nWould you like to display the statistics of this vehicle? ");
        string DisplayStats = Console.ReadLine().ToLower();

        if (DisplayStats == "yes")
        {
            Console.WriteLine($"Statistics: \nAcceleration (0-60): {selectedVehicle.GetAcceleration()}  seconds \nPower: {selectedVehicle.GetPower()}  horsepower \nMileage: {selectedVehicle.GetMileage()}  miles \nFuel Economy: {selectedVehicle.GetFuelEconomy()}  mpg \nTop speed: {selectedVehicle.GetTopSpeed()}  mph \nNumber of doors: {selectedVehicle.GetDoors()} \nWeight of vehicle: {selectedVehicle.GetWeight()} kg \nDrivetrain: {selectedVehicle.GetDriveTrain()} \n Fuel Type: {selectedVehicle.GetFuelType()} \nEngine size: {selectedVehicle.GetEngineSize()} L \nTransmission type: {selectedVehicle.GetTransmission()} \nSeat capacity: {selectedVehicle.GetSeatCapacity()} \nFuel capacity: {selectedVehicle.GetFuelCapacity()}L \nWeight capacity: {selectedVehicle.GetWeightCapacity()} kg \nLoad capacity: {selectedVehicle.GetLoadCapacity()} cubic feet \nManufacturing year: {selectedVehicle.GetYear()} \nVehicle type: {selectedVehicle.GetVehicleType()} \nFeatures: {selectedVehicle.GetFeatures()}");
        }
        else if (DisplayStats == "no")
            {
                //do not print out stats and continue with program
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

void CancelRental()
{
    // use similar features to rental info to display inactive rental status 
    ExistingUser selectedCustomer = SearchCustomerID();

    RentalInfo();

    Console.WriteLine("Are you sure you want to cancel your current rental? (yes or no)");
    string confirmCancellation = Console.ReadLine().ToLower();

    foreach (var r in selectedCustomer.GetRentals())
    {
        if (confirmCancellation == "yes")
        {
            Console.WriteLine("Please wait two seconds...");
            r.SetActivityStatus(false);
            DateTime cancelEndDate = DateTime.Now; // sets rental end date to the current date.
            string rentalInfoCleared = ("n/a");    // clears current model and make.
            int rentalChargeCleared = 0;           // sets rental charge to zero.

            r.SetEndDate(cancelEndDate);
            r.SetMake(rentalInfoCleared);
            r.SetModel(rentalInfoCleared);
            Thread.Sleep(2000); //Waits 2000 milliseconds

            Console.WriteLine($"\nCancellation complete...\n\nRental Status: Inactive \nNew Rental info: {r.GetStartDate()} to {r.GetEndDate()}, \nMake: {r.GetMake().ToUpper()} \nModel: {r.GetModel().ToUpper()} \nTotal fee: £{rentalChargeCleared}");
        }
        else if (confirmCancellation == "no") 
        {
            return;
        }
        else
        {
            Console.WriteLine("ERROR: Result not found! ");
            return;
        }
    }
}

void RentVehicle()
{
    ExistingUser selectedCustomer = SearchCustomerID();

    Console.WriteLine("What vehicle make would you like to rent? ");
    string SearchCarMakeToRent = Console.ReadLine().ToLower();

    Console.WriteLine("What vehicle model would you like to rent? ");
    string SearchCarToRent = Console.ReadLine().ToLower();

    // display availability status of vehicle
    if (vehicles.ContainsKey(SearchCarToRent))
    {
        Vehicle selectedVehicle;
        selectedVehicle = vehicles[SearchCarToRent];

        //reads file from vehicle list 
        readVehicleFile();

        //checks if status is available
        if (selectedVehicle.GetAvailabilityStatus(true))
        {
            Console.WriteLine("Please enter the end date of the rental: (year/month/day/ hour:minute:second)\n");
            DateTime extendedDate = Convert.ToDateTime(Console.ReadLine());

            //endDate = extendedDate;

            foreach (var r in selectedCustomer.GetRentals())
            {
                r.SetEndDate(extendedDate); //sets end date to the date that the user has chosen
                r.SetStartDate(DateTime.Now); //sets start date to now
                r.SetModel(SearchCarToRent); //sets model of vehicle
                r.SetMake(SearchCarMakeToRent); // sets make of vehicle
                r.SetAvailabilityStatus(false); //sets availability status to unavailable
                Console.WriteLine($"\nNew Rental info: {r.GetStartDate()} to {r.GetEndDate()}, \nMake: {r.GetMake().ToUpper()} \nModel: {r.GetModel().ToUpper()} \nTotal fee: £{r.RentCharge()}");
            }
        }
        else
        {
            //Make the user aware that the vehicle they have searched for is unavailable.
            Console.WriteLine("The selected vehicle is not available. Please select another vehicle!");

            //writes to vehicle list file
            /* writeVehicleFile();*/

            try
            {
                //displays make and model of the car that the user has just returned
                Console.WriteLine($"\nThank you! | {selectedVehicle.GetMake().ToUpper()}: {selectedVehicle.GetModel().ToUpper()} | has successfully been rented! ");

            }
            catch (NullReferenceException)
            {
                Console.WriteLine("We could not find a result for your request! ");
                return;
            }
        }
    }
}

void DisplayStockList()
{
    Console.WriteLine("\nVehicle list");

    try
    {
        //using Json to [read] list to a file
        string jsonString = File.ReadAllText("stockList.json");
        var v = JsonSerializer.Deserialize<Dictionary<string, Vehicle>>(jsonString);

        foreach (var car in vehicles)
        {
            // output car info from Tostring within the vehicle class.
            Console.WriteLine($"{car.Value}");
        }
    }
    catch (FileNotFoundException)
    {
        Console.WriteLine("The required file was not found! ");
    }
}

void TotalVehicleCount()
{
    Console.WriteLine($"The total number of vehicles within our system is {vehicles.Count}");
}

void SearchVehicleAvailability()
{
    Console.WriteLine("Search for vehicle availability: \n");
    string AvailableCar = Console.ReadLine().ToLower();

    // use the GetAvailabilityStatus to find available vehicles and return the vehicles which == true
    Vehicle selectedVehicle;
    selectedVehicle = vehicles[AvailableCar];

    if (selectedVehicle.GetAvailabilityStatus(true))
    {
        Console.WriteLine($"\n\nMake: {selectedVehicle.GetMake()}  \nModel: {selectedVehicle.GetModel()} \nAvailability: Available");
    }
    else if (selectedVehicle.GetAvailabilityStatus(false)) 
    {
        Console.WriteLine($"\n\nMake: {selectedVehicle.GetMake()}  \nModel: {selectedVehicle.GetModel()} \nAvailability: Unavailable");
    }
    else
    {
        Console.WriteLine("ERROR: Result not found! ");
         return;
    }
}

void Mileage()
{
    IEnumerable<int> mileages = vehicles.Values.Select(m => m.GetMileage());
    IEnumerable<Vehicle> Mileage = vehicles.Values.Where(M => M.GetMileage() < 30000);
    IEnumerable<Vehicle> orderedMileage = vehicles.Values.OrderBy(mileage => mileage.GetMileage());

    // display all mileages
    foreach (int m in mileages)
    {
        Console.WriteLine(m + " miles");
    }

    Console.WriteLine("Would you like to display the vehicles with low mileage? (less than 30,000 miles) ");
    string lowmileage = Console.ReadLine().ToLower();

    if (lowmileage == "yes")
    {
        Console.WriteLine("Vehicles with low mileage: ");

        //only display low mileages 
        foreach (Vehicle M in Mileage)
        {
            Console.WriteLine($"\n\nMake: {M.GetMake()}  \nModel: {M.GetModel()} [{M.GetVehicleType()}] \nMileage: {M.GetMileage()} miles");
        }
    } else
    {
        return;
    }

    Console.WriteLine("Would you like to display an ordered list of mileages? ");
    string displayOrderedMileage = Console.ReadLine().ToLower();

    if (displayOrderedMileage == "yes")
    {
        Console.WriteLine("Vehicles with low mileage: ");

        //only display low mileages 
        foreach (Vehicle mileage in orderedMileage)
        {
            Console.WriteLine($"\n\nMake: {mileage.GetMake()}  \nModel: {mileage.GetModel()} [{mileage.GetVehicleType()}] \nMileage: {mileage.GetMileage()} miles");
        }
    }
    else
    {
        return;
    }
}

void VehicleManufactureYear()
{
    IEnumerable<Vehicle> ManufactureYear = vehicles.Values.Where(Y => Y.GetYear() > 2021);
    foreach (Vehicle Y in ManufactureYear)
    {
        Console.WriteLine($"\n\nMake: {Y.GetMake()}  \nModel: {Y.GetModel()} [{Y.GetVehicleType()}] \nManufacture year: {Y.GetYear()} ");
    }

    Console.WriteLine("Would you like to display the vehicles from oldest to newest? ) ");
    string OldToNew = Console.ReadLine().ToLower();

    if (OldToNew == "yes")
    {
        IEnumerable<Vehicle> Sorted = vehicles.Values.OrderBy(year => year.GetYear());
        foreach (Vehicle year in Sorted)
        {
            Console.WriteLine($"\n\nMake: {year.GetMake()}  \nModel: {year.GetModel()} [{year.GetVehicleType()}] \nManufacture year: {year.GetYear()} ");   
        }
    } else
    {
        return;
    }
}

void Contact()
{
    Console.WriteLine("\n\nContact Info: \n\nEmail: declanrentals@hotmail.com \nTelephone Number: 07 123 456 789 \nAddress: 826 Boulevard Road");
}


//view unique vehicles (pull dictionary into hashlist?)