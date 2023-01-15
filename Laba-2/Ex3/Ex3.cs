using System;

class Ex3
{
    static void Main()
    {
        // Зчитую кільіксть чисел
        Console.Write("k: ");
        string? strN = Console.ReadLine();
        int n = 0;
        if (strN != null)
            n = int.Parse(strN) * 4;

        // Створюю масим
        //int[] arr = { 5, 2, 3, 6 };
        //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int[] arr = { 4, 3, -1, 2, 5, 0, 1, 9, 8, 6, 7, -2 };
        //int[] arr = new int[n];
        n = arr.Length;

        for (int i = 0; i < n; i++) // запомнюю і виводжу масив
        {
            //Random rand = new Random();
            //arr[i] = rand.Next(1, 6);
            Console.Write($"{arr[i]} ");
        }
        Console.WriteLine();


        // Створюю додаткові масиви для лівого та правого складування
        int[] arrResultOne = new int[n / 4];
        int[] arrResultTwo = new int[n / 4];


        // Алгоритм лівого складування
        for (int i = 0; i < n / 4; i++)
            arrResultOne[n / 4 - i - 1] = arr[i] + arr[n / 2 - i - 1];
        for (int i = 0; i < n / 4; i++) 
            Console.Write($"{arrResultOne[i]} ");

        // Алгоритм правого складування
        for (int i = 0; i < n / 4; i++)
        {
            arrResultTwo[i] = arr[n / 2 + i] + arr[n - i - 1];
            Console.Write($"{arrResultTwo[i]} ");
        }
    }
}