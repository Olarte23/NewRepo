using AutomovilList;
using System;

var ford1 = new Car { Brand = "Ford", Model = "Modelo1", Year = 2015 , Color = "Red", Price = 180,  };
var mazda1 = new Car { Brand = "Mazda", Model = "Modelo1", Year = 2022, Color = "Gray", Price = 120,  };
var mazda2 = new Car { Brand = "Mazda", Model = "Modelo2", Year = 2022, Color = "Gray", Price = 165, };
var chevrolet1 = new Car { Brand = "chevorolet", Model = "Modelo2", Year = 2010, Color = "Blue", Price = 25, };
var chevrolet2 = new Car { Brand = "chevorolet", Model = "Modelo3", Year = 2015, Color = "Black", Price = 30 };
var mercedes1= new Car { Brand = "Mercedes", Model = "Modelo3", Year = 2022, Color = "Gray", Price = 200, };
var mercedes2 = new Car { Brand = "Mercedes", Model = "Modelo4", Year = 2010, Color = "Red", Price = 110, };
var chevrolet3 = new Car { Brand = "chevorolet", Model = "Modelo1", Year = 2010, Color = "Red", Price = 50, };
var mazda3 = new Car { Brand = "Mazda", Model = "Modelo4", Year = 2020, Color = "Blue", Price = 80, };
var mercedes3 = new Car { Brand = "Mercedes", Model = "Modelo3", Year = 2015, Color = "Blue", Price = 75, };
var ford2 = new Car { Brand = "Ford", Model = " Modelo2", Year = 2020, Color = "Black", Price = 55, };
var ford3 = new Car { Brand = "Ford", Model = "Modelo4", Year = 2020, Color = "Black", Price = 90, };

var Car = new YourLinkedList<Car>();
Car.Add(ford1);
Car.Add(ford2);
Car.Add(ford3);
Car.Add(mazda1);
Car.Add(mazda2);
Car.Add(mazda3);
Car.Add(chevrolet1);
Car.Add(chevrolet2);
Car.Add(chevrolet3);
Car.Add(mercedes1);
Car.Add(mercedes2);
Car.Add(mercedes3);
Console.WriteLine("Car List => Get Brand");
var C = Car.GetBrand("Mazda");
Console.WriteLine(C);
Console.WriteLine("\nCar List => Get Year");

var D = Car.GetYear(2015, 2023);
Console.WriteLine(D);
Console.WriteLine("\nCar List => Get Price");

var A = Car.GetPrice(160, 230);
Console.WriteLine(A);
Console.WriteLine("\nCar List => Get Several Filters");

var S = Car.GetSeveralFilters("Mercedes", "Modelo3", "Gray", 2015, 2023);
Console.WriteLine(S);


