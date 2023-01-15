using System;

class Ex1
{
    static void Main()
    {
        string ArrayWordOne = "js hi php java csharp sql html css";
        string ArrayWordTwo = "softuni js nakov hi php java java learn";

        Console.WriteLine(ArrayWordOne);
        Console.WriteLine(ArrayWordTwo);

    }
}

// js hi php java csharp sql html css
// softuni js nakov hi php java java learn

// hi php java csharp sql html css js
// hi php java js softuni nakov java learn

// hi php java xml csharp sql html css js
// nakov java sql html css js

// I love programming
// Learn Java or C#