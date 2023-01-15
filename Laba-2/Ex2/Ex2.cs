using System;

class Ex2
{
    static void Main()
    {
        // Вводиться кількість елементів
        Console.Write("n: ");
        string? TempN = Console.ReadLine();
        int n = 0;
        if (TempN != null)
            n = int.Parse(TempN);

        // Вводиться кількість поворотів
        Console.Write("k: ");
        TempN = Console.ReadLine();
        int k = 0;
        if (TempN != null)
            k = int.Parse(TempN);



        // Створюються масиви
        int[] arr = new int[n];
        int[,] tempArr = new int[k, n];

        // Зчитуються елементи і зразу конвертуються в числове значення і записюються в числовий масив
        arr = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.TryParse(i, out int pars) ? pars : 0).ToArray();



        for (int i = 0; i < k; i ++)
        {
            int Temp = arr[n - 1]; // в тимчасову змінну записую останній елемент масиву
            for (int j = n - 1; j >= 0; j--) // міняю елементи місцями проходячи з кінця масиву
            {
                int temp = arr[j];
                arr[j] = arr[j - 1];
                arr[j - 1] = temp;

                tempArr[i, j] = arr[j]; // записую результати переміщення(щоб бачити як працює кожен крок)

                // Якщо дойшов до початку масиву то замінюю перший елемент останнім елементом скопійованим раніше
                if (j - 1 == 0) { arr[j - 1] = Temp; tempArr[i, j - 1] = arr[j - 1]; break; }
            }
        }

        for (int i = 0; i < n; i++) arr[i] = 0; // занулюю масив остаточних результатів

        Console.WriteLine();


        for (int i = 0; i < k; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{tempArr[i, j]} "); // виводжу результати переміщення(щоб бачити як працює кожен крок)
                arr[j] += tempArr[i, j]; // сумую результати переміщення(щоб бачити як працює кожен крок) в масив остаточних результатів
            }

            Console.WriteLine();
        }

        Console.WriteLine();


        for (int i = 0; i < n; i++)
            Console.Write($"{arr[i]} "); // виводжу остаточні результати

    }
} 