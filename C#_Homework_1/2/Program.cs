// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter your age");
int age = Convert.ToInt32(Console.ReadLine());
if (age < 13 && age >= 0)
{
    Console.WriteLine("Child");
}else if (age > 13 && age < 19)
{
    Console.WriteLine("Teenager");
}else if (age > 19)
{
    Console.WriteLine("Adult");
}
else
{
    Console.WriteLine("Something went wrong");
}