using StatePattern;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

GumBallMachine machine = new GumBallMachine(5);

Console.WriteLine(machine);

machine.InsertQuarter();
machine.TurnCrank();

Console.WriteLine(machine);

machine.InsertQuarter();
machine.EjectQuarter();
machine.TurnCrank();

Console.WriteLine(machine);
machine.InsertQuarter();
machine.TurnCrank();
machine.InsertQuarter();
machine.TurnCrank();
machine.EjectQuarter();

Console.WriteLine(machine);
machine.InsertQuarter();
machine.InsertQuarter();
machine.TurnCrank();
machine.InsertQuarter();
machine.TurnCrank();
machine.InsertQuarter();
machine.TurnCrank();

Console.WriteLine(machine);

