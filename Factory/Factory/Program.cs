using System;
using Factory.Stores;
using Factory.Abstractions;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
PizzaStore nyStore = new NYStylePizzaStore();
PizzaStore chicagoStore = new ChicagoStylePizzaStore();

Pizza pizza = nyStore.OrderPizza("cheese");
Console.WriteLine($"Ethan ordered a {pizza.Name}");

pizza = chicagoStore.OrderPizza("cheese");
Console.WriteLine($"Joel ordered a {pizza.Name}");

Console.ReadLine();