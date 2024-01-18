// See https://aka.ms/new-console-template for more information

Console.WriteLine("1) To convert Fahrenheit press F. \n2) To convert Celsius press C.");
string choice = Console.ReadLine().ToUpper();
Console.WriteLine("Enter the temperature");
float temp = Convert.ToInt32(Console.ReadLine());
switch (choice)
{
    case "F":
        Console.WriteLine((temp * 1.8) + 32);
        break;
    case "C":
        Console.WriteLine((temp - 32) / 1.8);
        break;
    default:
        Console.WriteLine("Something went wrong, please try again.");
        break;
}