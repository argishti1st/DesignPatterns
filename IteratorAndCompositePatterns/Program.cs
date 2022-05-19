using IteratorAndCompositePatterns.Contracts;
using IteratorAndCompositePatterns.Models;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
MenuComponent dinerMenu = new Menu("DINER MENU", "Lunch");
MenuComponent cafeMenu = new Menu("CAFE MENU", "Dinner");
MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert of course!");
MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");

DinnerMenu dinmenu = new DinnerMenu();
var dinnerEnumerator = dinmenu.CreateEnumeratorGeneric();
while(dinnerEnumerator.MoveNext()){
    dinerMenu.Add(dinnerEnumerator.Current);
}

allMenus.Add(pancakeHouseMenu);
allMenus.Add(dinerMenu);
allMenus.Add(cafeMenu);
// add menu items here
dinerMenu.Add(new MenuItem("Pasta", "Spaghetti with Marinara Sauce, and a slice of sourdough bread", true, 3.89));
dinerMenu.Add(dessertMenu);
dessertMenu.Add(new MenuItem( "Apple Pie", "Apple pie with a flakey crust, topped with vanilla ice cream", true, 1.59));
// add more menu items here
Waitress waitress = new Waitress(allMenus);

waitress.PrintMenu();


