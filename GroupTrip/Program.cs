/*
 *Name:        Kade Russell
 *Course:      CSCI 1250, Section 001
 *Assignment:  Lab 04, The Group Trip
 *Date:        October 14, 2026
 *Description: Rebuilds the trip calculator with methods and arrays for it to report on a whole group instead of one person.
*/

const int slicesPerPizza = 8;
const double taxRate = 0.18;

Console.Write("Road trip miles: ");
double totalMiles = Convert.ToDouble(Console.ReadLine());

Console.Write("Miles per gallon: ");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("Price per gallon: ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("How many pizzas: ");
int pizzas = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the price per pizza: ");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

// Part 1 calculates the total cost of the trip.
Console.WriteLine("=== Part 1: The Trip ===");

double fuelCost = FuelCost(totalMiles, milesPerGallon, pricePerGallon);
double pizzaCost = pizzas * pricePerPizza;
double tripTotal = fuelCost + pizzaCost; 

Console.WriteLine("Fuel cost: " + fuelCost.ToString("C"));
Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C"));
Console.WriteLine("Trip total: " + tripTotal.ToString("C"));


// Returns the total fuel cost for the trip.
static double FuelCost(double miles, double milesPerGallon, double pricePerGallon)
{
    double gallons = miles / milesPerGallon;
    return gallons * pricePerGallon;
}

//Returns take-home pay after taxes.
static double TakeHomePay(double hours, double hourlyRate, double taxRate)
{
    double grossPay = hours * hourlyRate;
    double taxWithheld = grossPay * taxRate;
    return grossPay - taxWithheld;
}

//Returns the hours needed to cover a person's share.
static double HoursToCover(double amountOwed, double takeHomePerHour)
{
    return amountOwed / takeHomePerHour;
}