﻿using System;

//ref link:https://www.youtube.com/watch?v=qkwrXQt6Oi0&list=PLRwVmtr-pp06rfSgNYu_oBg40DkwXiRHt&index=9
//  JIT(Just in Time) -> 


class AnotherClass
{
    public static void Moo()
    {
        Console.WriteLine("Moooooooooooooooooooo");
    }
}

class MainClass
{
    static void Main()
    {
        AnotherClass.Moo();
        AnotherClass.Moo();
    }
}