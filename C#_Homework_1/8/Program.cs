// See https://aka.ms/new-console-template for more information

int[] arr = { 1, 2, 3, 4, 5 };
int temp;
if (arr.Length > 2)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length - i - 1];
        arr[arr.Length - i - 1] = temp;
    }
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1)
            Console.Write(", ");
    }
    Console.WriteLine("]");
}
else
{
    Console.WriteLine("Array must have at least 2 elements.");
}