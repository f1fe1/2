using System;

class Ex8
{
    static void Main()
    {
        Console.Write("size: ");
        int size = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
        {
            Random r = new Random();
            arr[i] = r.Next(0, 10);
            Console.Write($"{arr[i]} ");
        }

        int frequentNumber = arr[0];
        int count = 1;
        int tempCount = 1;

        Console.WriteLine();


        for (int i = 1; i < size; i++)
        {
            if (arr[i] == arr[i - 1])
                tempCount++;
            else
                tempCount = 1;

            if (tempCount > count)
            {
                count = tempCount;
                frequentNumber = arr[i];
            }
            else if (arr[i] == frequentNumber) count++;
        }

        Console.WriteLine($"The number {frequentNumber} is the most frequent (occurs {count} times)");
        Console.ReadKey();
    }
}