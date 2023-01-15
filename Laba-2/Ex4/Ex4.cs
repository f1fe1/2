using System;

class Ex4
{
    static void Main()
    {
        void SieveOfEratosthenes(int n)
        {
            bool[] prime = new bool[n + 1];

            for (int i = 0; i < n + 1; i++)
                prime[i] = true;

            for (int p = 2; p * p <= n; p++)
                if (prime[p] == true)
                    for (int i = p * 2; i <= n; i += p)
                        prime[i] = false;

            for (int p = 2; p <= n; p++)
                if (prime[p])
                    Console.Write($"{p} ");
        }


        Console.Write("Vvedite N(konez diapazona): ");
        string? temp = Console.ReadLine();
        int n = 0;
        if (temp != null)
            n = int.Parse(temp);

        SieveOfEratosthenes(n);

        Console.ReadLine();
    }
}