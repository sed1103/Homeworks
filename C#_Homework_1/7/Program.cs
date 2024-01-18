// See https://aka.ms/new-console-template for more information

int[] array1 = { 1, 2, 3 };
int[] array2 = { 4, 5, 6 };

int[] resultArray = SumArrays(array1, array2);

Console.Write("Sum of corresponding elements: [");
for (int i = 0; i < resultArray.Length; i++)
{
    Console.Write(resultArray[i]);
    if (i < resultArray.Length - 1)
        Console.Write(", ");
}
Console.WriteLine("]");

static int[] SumArrays(int[] array1, int[] array2)
{
    if (array1.Length != array2.Length)
    {
        Console.WriteLine("Arrays must have the same length.");
        return null;
    }

    int[] resultArray = new int[array1.Length];

    for (int i = 0; i < array1.Length; i++)
    {
        resultArray[i] = array1[i] + array2[i];
    }
    return resultArray;
}