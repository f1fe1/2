using System;

class Ex9
{
    static void Main()
    {
        string? temp = Console.ReadLine();

        if (temp != null)
            for (int i = 0; i < temp.Length; i++)
            {
                if ((int)temp[i] >= 65 && (int)temp[i] <= 90) // якщо верхній регістр то через конвертацію переводжу в нижній
                    Console.WriteLine($"{Convert.ToChar((int)temp[i] + 32)} -> {(int)temp[i] - 65}");
                else
                    Console.WriteLine($"{temp[i]} -> {(int)temp[i] - 65 - 32}");
            }
    }
}