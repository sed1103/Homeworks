// See https://aka.ms/new-console-template for more information

int[] numbers = { 5, 3, 9, 1, 7, 2, 8, 4, 6 };

int secondLargest = FindSecondLargest(numbers);
Console.WriteLine("Second Largest element: " + secondLargest);

static int FindSecondLargest(int[] array)
{
    if (array.Length < 2)
    {
        Console.WriteLine("Array should have at least two elements.");
        return -1;
    }

    int largest = Math.Max(array[0], array[1]);
    int secondLargest = Math.Min(array[0], array[1]);

    for (int i = 2; i < array.Length; i++)
    {
        if (array[i] > largest)
        {
            secondLargest = largest;
            largest = array[i];
        }
        else if (array[i] > secondLargest && array[i] != largest)
        {
            secondLargest = array[i];
        }
    }

    return secondLargest;
}