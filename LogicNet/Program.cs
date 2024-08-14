/*
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue!= "a");

// Using string methods to compare
string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// Methods that returns Boolean
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

// These two lines of code will create the same output
Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));


Console.WriteLine("Condition Operator");
// Condition Operator
int saleAmount = 1001;
//int discount = saleAmount > 1000 ? 100 : 50;
//Console.WriteLine($"Discount: {discount}");

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
*/

// Code Challenge Coin Flip
/*
Random coin = new();
int valor = coin.Next(0 , 2);

Console.WriteLine($"Coin is: {((valor == 0) ? "heads" : "tails")}");
*/

//Decision logic challenge
/*
Console.WriteLine("Olá usuário! Você é um Admin ou um Manager?");
string permission = Console.ReadLine() ?? string.Empty;
Console.WriteLine("Qual seu nível de privilégio?");
int level = Convert.ToInt32(Console.ReadLine() ?? string.Empty);

if (permission.Contains("Admin")){
    if (level > 55){
        Console.WriteLine("Welcome, Super Admin user.");
    } else {
        Console.WriteLine("Welcome, Admin user.");
    }
} else if (permission.Contains("Manager")) {
    if (level >= 20){
        Console.WriteLine("Contact an Admin for access.");
    } else {
        Console.WriteLine("You do not have sufficient privileges.");
    }
} else {
    Console.WriteLine("You do not have sufficient privileges.");
}
*/

// Code blocks and variable declaration
/*
bool flag = true;
int value = 0;

if (flag)
{
    Console.WriteLine($"Inside the code block: {value}");
}

value = 10;
Console.WriteLine($"Outside the code block: {value}");
*/

// Removing code blocks
/*
string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");
*/

// Variable scope challenge
/*
int[] numbers = { 4, 8, 15, 16, 23, 42 };
bool found = false;
int total = 0;

foreach (int number in numbers)
{
    total += number;
    if (number == 42) found = true;
}

if (found) Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");
*/

//