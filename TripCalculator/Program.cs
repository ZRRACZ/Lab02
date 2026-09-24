//Part 1: Road Trip

//Question/Answer
System.Console.WriteLine("How many miles for your trip?");
double tripMiles = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("How many miles per gallon can your car go??");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("How much did you pay for gas?");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

//Calculations for Part 1
double gallonsNeeded = tripMiles / milesPerGallon;
double fuelCost = gallonsNeeded * pricePerGallon;

//Print the calculations
Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
Console.WriteLine("Fuel cost: " + fuelCost.ToString("C"));