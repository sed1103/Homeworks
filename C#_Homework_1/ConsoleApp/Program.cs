// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter the temperature");
int temp = Convert.ToInt32(Console.ReadLine());
if (temp < 0)
{
    Console.WriteLine("Freezing weather.");
}else if (temp > 0)
{
    Console.WriteLine("Not freezing weather");
}
else
{
    Console.WriteLine("It is about to be freezing.");
}