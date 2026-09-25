//Part 1: Road Trip

//Question/Answer
using System.Reflection.Metadata;

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

//Part 2 Pizza Party

//Question/Answer
const double Number_of_slices = 8;

Console.WriteLine("How many people are coming?");
double people = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("How many pizzas did you order?");
double pizzaNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("How much did you pay per pizza?");
double pizzaCost = Convert.ToDouble(Console.ReadLine());

//Calculations for part 2
double totalSlices = pizzaNumber * Number_of_slices;
double slicesNeeded = totalSlices / people;
double totalPizzaCost = pizzaNumber * pizzaCost;

//print the calculations
Console.WriteLine("Total slices: " + totalSlices.ToString("F1"));
Console.WriteLine("Slices per person: " + slicesNeeded.ToString("F2"));
Console. WriteLine("Total pizza cost: " + totalPizzaCost.ToString("C"));

//Part 3 Paycheck
//Questions/Answers
const double Tax_Rate = 0.18;

Console.WriteLine("How many hours did you work this week?");
double hoursWorked = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("What is your hourly rate?");
double hourRate = Convert.ToDouble(Console.ReadLine());

//Calculations for part 3
double grossPay = hoursWorked * hourRate;
double taxWithheld = grossPay * Tax_Rate;
double takeHomePay = grossPay - taxWithheld;

//print calculations
Console.WriteLine("Gross pay: " + grossPay.ToString("C1"));
Console.WriteLine("Tax withheld: " + taxWithheld.ToString("C2"));
Console.WriteLine("Take home pay: " + takeHomePay.ToString("C3"));

//Part 4 total trip
//Calculations for part 4
double totalTripCost = fuelCost + totalPizzaCost;
double costPerPerson = totalTripCost / people;
double takeHomePayPerHour = takeHomePay / hoursWorked;
double hoursNeededToWork = costPerPerson / takeHomePayPerHour;

//Print calculations
Console.WriteLine("Trip total: " + totalTripCost.ToString("C1"));
Console.WriteLine("cost per person: " + costPerPerson.ToString("C2"));
Console.WriteLine("Take home pay per hour: " + takeHomePayPerHour.ToString("C3"));
Console.WriteLine("Hours you must work to cover your share: " + hoursNeededToWork.ToString("C4"));
