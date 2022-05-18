using IteratorAndCompositePatterns.Models;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

DinnerMenu dinerMenu = new DinnerMenu();
Waitress waitress = new Waitress(dinerMenu);
waitress.PrintMenu();


