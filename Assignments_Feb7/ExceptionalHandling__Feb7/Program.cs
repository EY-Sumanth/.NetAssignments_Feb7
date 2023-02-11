
using System.Collections.Generic;
using System;

class Bike : IVehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Bike(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }
}

class Car : IVehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }
}

class Vehicle
{
    List<IVehicle> vehicles = new List<IVehicle>();

    public void AddVehicle(IVehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void ListVehicles()
    {
        foreach (var vehicle in vehicles)
        {
            Console.WriteLine("Make: " + vehicle.Make + ", Model: " + vehicle.Model + ", Year: " + vehicle.Year);
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        Vehicle vehicle = new Vehicle();
        vehicle.AddVehicle(new Bike("Honda", "CBR", 2018));
        vehicle.AddVehicle(new Car("Toyota", "Camry", 2020));
        vehicle.AddVehicle(new Bike("Yamaha", "R6", 2022));
        vehicle.AddVehicle(new Car("Tesla", "Model S", 2021));

        vehicle.ListVehicles();
    }
}