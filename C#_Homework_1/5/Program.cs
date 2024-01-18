// See https://aka.ms/new-console-template for more information

int[] numbers = { 5, 3, 9, 1, 7, 2, 8, 4, 6 };

FindMaxAndMin(numbers);

static void FindMaxAndMin(int[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("Array is empty.");
        return;
    }

    int max = array[0];
    int min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];

        if (array[i] < min)
            min = array[i];
    }

    Console.WriteLine("Maximum element: " + max);
    Console.WriteLine("Minimum element: " + min);
}