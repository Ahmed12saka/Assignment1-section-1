Console.Write("Put the amount you want to convert to Fahrenheit in degrees Celsius: ");
double celsius = Convert.ToDouble(Console.ReadLine());
Console.Write("Put the amount you want to convert to Celsius in degrees Fahrenheit: ");
double fahrenheit = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Farenhiet= {(celsius * 9 / 5) + 32}");
Console.WriteLine($"Celsius = {(fahrenheit - 32) * 5 / 9}");
if (fahrenheit < celsius)
{
    Console.WriteLine("Fahrehiet is bigger than Celsius");
}else if (celsius < fahrenheit)
{
    Console.WriteLine("Celsius is bigger than Fahrenhiet");
}else
{
    Console.WriteLine("Both are equal");
}