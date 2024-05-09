using Extension.Extensions;
using System;
public class ProcessFile
{
    public static void Main()
    {
        DateTime dt = new DateTime(2024, 05, 01, 8, 10, 45);
        Console.WriteLine(dt.ElapsedTime());
    }
}