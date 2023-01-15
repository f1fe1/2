using System;

class Ex5
{
    static void Main()
    {
        string strOne = Console.ReadLine();
        string strTwo = Console.ReadLine();

        Console.WriteLine();

        int size = strOne.Length;
        if (strOne.Length < strTwo.Length)
            size = strTwo.Length;

        for (int i = 0; i < size; i++)
        {
            if (strOne[i] != strTwo[i])
            {
                if ((int)strOne[i] < (int)strTwo[i])
                {
                    Console.WriteLine(strOne);
                    Console.WriteLine(strTwo);
                    break;
                }
                else if ((int)strOne[i] > (int)strTwo[i])
                {
                    Console.WriteLine(strTwo);
                    Console.WriteLine(strOne);
                    break;
                }
                break;
            }
            if (i == size - 1)
            {
                Console.WriteLine(strOne);
                Console.WriteLine(strTwo);
            }
        }
    }
}
