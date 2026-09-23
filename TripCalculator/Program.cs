Console.Write("What was the round trip in miles?");
int milesForTheTrip = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the miles per gallon ofthe car you are using?");
int milesPerGallon = Convert.ToInt32(Console.ReadLine());

Console.Write("What was the gas price?");
double gasPrice = Convert.ToDouble(Console.ReadLine());

//do the math

double gallonsNeeded = milesForTheTrip / (double)milesPerGallon;

double fuelCost = gallonsNeeded * gasPrice;

// do the output
Console.WriteLine();
Console.WriteLine("=== Part 1: Road Trip ===");
Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
Console.WriteLine("Fuel cost: " + fuelCost.ToString("C"));
Console.WriteLine();

Console.Write("How many people are going to the pizza party?");
int peopleGoing = Convert.ToInt32(Console.ReadLine());

Console.Write("How many pizzas are you purchasing?");
int pizzasPurchasing = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the pice per pizza?");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

const double slicesPerPizza = 8;

//do the math

double totalSlices = pizzasPurchasing * slicesPerPizza;

double slicePerPerson = totalSlices / peopleGoing;

double pizzaCost = pizzasPurchasing * (double)pricePerPizza;

// do the output
Console.WriteLine();
Console.WriteLine("=== Part 2: Pizza Party ===");
Console.WriteLine("Total slices: " + totalSlices.ToString("F0"));
Console.WriteLine("Slices per person: " + slicePerPerson.ToString("F1"));
Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C"));
Console.WriteLine();

Console.Write("How many hours did you work?");
int hoursWorked = Convert.ToInt32(Console.ReadLine());

Console.Write("What is your hourly rate?");
double hourlyRate = Convert.ToDouble(Console.ReadLine());

const double tax = 0.18;

//do the math

double grossPay = hoursWorked * (double)hourlyRate;

double taxWithheld = grossPay * (double)tax;

double takeHomePay = grossPay - taxWithheld;

// do the output
Console.WriteLine();
Console.WriteLine("=== Part 3: Paycheck ===");
Console.WriteLine("Gross pay: " + grossPay.ToString("C"));
Console.WriteLine("Tax withheld: " + taxWithheld.ToString("C"));
Console.WriteLine("Take home pay: " + takeHomePay.ToString("C"));
Console.WriteLine();
//do the math

double tripTotal = fuelCost + pizzaCost;

double costPerPerson = tripTotal / peopleGoing;

double takeHomePayPerHour = takeHomePay / hoursWorked;

double hoursYouMustWork = costPerPerson / takeHomePayPerHour;


// do the output
Console.WriteLine("=== Part 1: Road Trip ===");
Console.WriteLine("Round trip miles: " + milesForTheTrip.ToString("F0"));
Console.WriteLine("Miles per gallon: " + milesPerGallon.ToString("F0"));
Console.WriteLine("Price per gallon: " + gasPrice.ToString("F2"));
Console.WriteLine();
Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
Console.WriteLine("Fuel cost: " + fuelCost.ToString("C"));
Console.WriteLine();
Console.WriteLine("=== Part 2: Pizza Party ===");
Console.WriteLine("How many people are going: " + peopleGoing.ToString("F0"));
Console.WriteLine("How many pizzas: " + pizzasPurchasing.ToString("F0"));
Console.WriteLine("Price per pizza: " + pricePerPizza.ToString("F2"));
Console.WriteLine();
Console.WriteLine("Slices per person: " + slicePerPerson.ToString("F1"));
Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C"));
Console.WriteLine();
Console.WriteLine("=== Part 3: Paycheck ===");
Console.WriteLine("Hours worked this week: " + milesForTheTrip.ToString("F0"));
Console.WriteLine("Hourly rate: " + milesPerGallon.ToString("F2"));
Console.WriteLine();
Console.WriteLine("Gross pay: " + grossPay.ToString("C"));
Console.WriteLine("Tax withheld: " + taxWithheld.ToString("C"));
Console.WriteLine("Take home pay: " + takeHomePay.ToString("C"));
Console.WriteLine();
Console.WriteLine("=== Part 4: The Whole Trip ===");
Console.WriteLine("Trip total: " + tripTotal.ToString("C"));
Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));
Console.WriteLine("Take home pay per hour: " + takeHomePayPerHour.ToString("C"));
Console.WriteLine("Hours you must work: " + hoursYouMustWork.ToString("F2"));