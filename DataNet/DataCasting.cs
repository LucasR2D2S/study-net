/*
// Compiler conversion

int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);


// Converting int to string

int three = 5;
int four = 7;
string message = three.ToString() + four.ToString();
Console.WriteLine(message);


// String to int

string five = "5";
string six = "7";
int sum = int.Parse(five) + int.Parse(six);
Console.WriteLine(sum);


// Using Convert

string value1 = "5";
string value2 = "7";
int result2 = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);


// Using Try Parse

string value = "12";
int result3 = 0;
if (int.TryParse(value, out result3))
{
   Console.WriteLine($"Measurement: {result3}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}

if (result3 > 0)
   Console.WriteLine($"Measurement (w/ offset): {50 + result3}");

*/


// Challenge
/*
string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (var value in values)
{
    decimal number; // stores the TryParse "out" value
    if (decimal.TryParse(value, out number))
    {
        total += number;
    } else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");
*/


// Challenge 2 
/*
int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// The Convert class is best for converting the fractional decimal numbers into whole integer numbers
// Convert.ToInt32() rounds up the way you would expect.
int result1 = Convert.ToInt32(value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
*/


// 