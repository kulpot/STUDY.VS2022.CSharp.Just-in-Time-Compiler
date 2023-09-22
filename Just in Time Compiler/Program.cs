using System;

//ref link:https://www.youtube.com/watch?v=qkwrXQt6Oi0&list=PLRwVmtr-pp06rfSgNYu_oBg40DkwXiRHt&index=9
//  JIT(Just in Time) -> compiles method by method, after MSIL when run(f5)
// CS -> CSC(BUILD|ctrl+shift+B|) -> MSIL(MSintermediateLanguage) -> JIT(run(f5)) -> NativeLanguage(CPU)


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
        AnotherClass.Moo(); //runtime - JIT
        AnotherClass.Moo();
    }
}