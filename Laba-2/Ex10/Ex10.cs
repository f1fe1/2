using System;

class Ex10
{
    static void Main()
    {
        Console.Write("size: ");
        int size = Convert.ToInt32(Console.ReadLine());

        Console.Write("difference: ");
        int difference = Convert.ToInt32(Console.ReadLine());

        int differenceIndex = 0;

        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
        {
            Random r = new Random();
            arr[i] = r.Next(0, 20);
            Console.Write($"{arr[i]} ");
        }

        for (int i = 0; i < size; i++)
            for (int j = 0; j < size; j++)
                if (arr[i] != arr[j] && arr[i] - arr[j] == difference)
                    differenceIndex++;

        Console.WriteLine($"\nDifference digit: {differenceIndex}");
    }
}