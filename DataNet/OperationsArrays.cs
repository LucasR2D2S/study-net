// Sort and Reverse Arrays
/*
string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/

// Clear and Resize
/*
string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/


// Split and Join
/*
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}
*/

// Challenge
/*
using System.Xml.XPath;

string pangram = "The quick brown fox jumps over the lazy dog";
string[] arrayPangram = pangram.Split(" ");
string[] newMessage = new string[arrayPangram.Length];
int i = 0;

foreach (string palavra in arrayPangram){
    char[] reserve = palavra.ToCharArray();
    Array.Reverse(reserve);
    newMessage[i] = new string(reserve);
    i++;
}
string result = String.Join(" ", newMessage);
Console.WriteLine(result);
*/


// Challenge find errors
/*
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] newOrder = orderStream.Split(",");

Array.Sort(newOrder);

foreach(string order in newOrder){
    if (order.Length == 4){
        Console.WriteLine(order);
    } else {
        Console.WriteLine($"{order}\t- Error");
    }
}
*/