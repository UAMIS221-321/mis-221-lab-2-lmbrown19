//variables
int numberOfSandwiches = 0;
int numberOfToppings = 0;
double tip = 0;
double totalSandwichCost;
double totalToppingCost;
double baseCost;
double orderCost;
//constants
const double COST_OF_SANDWICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = 0.10;
//Prompt user for sandwiches
System.Console.WriteLine("How many sandwiches do you want?");
numberOfSandwiches = int.Parse(Console.ReadLine());
System.Console.WriteLine("Sandwiches "+numberOfSandwiches);
//Prompt user for toppings
System.Console.WriteLine("How many toppings do you want?");
numberOfToppings = int.Parse(Console.ReadLine());
System.Console.WriteLine("Toppings "+numberOfToppings);
//Prompt user for tip
System.Console.WriteLine("How much would you like to tip?");
tip = double.Parse(Console.ReadLine());
System.Console.WriteLine("Tip "+tip);
//Math
totalSandwichCost = COST_OF_SANDWICH*numberOfSandwiches;
totalToppingCost = COST_OF_TOPPING*numberOfToppings;
baseCost = totalSandwichCost + totalToppingCost;
orderCost = tip + baseCost*(1-DISCOUNT_AMOUNT);
orderCost = Math.Round(orderCost,2);
System.Console.WriteLine("Your total is "+orderCost+"!");
//Program end
