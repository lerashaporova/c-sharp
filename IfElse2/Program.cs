using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Введите число");
        int a = Convert.ToInt32(Console.ReadLine()); 
        if (a % 3 == 0)
        {
            Console.WriteLine("Число "+a+" кратно 3ем");
        } else if (a % 7 == 0)
        {
            Console.WriteLine("Число " + a + " кратно 7ем");
        } else
        {
            Console.WriteLine("Число не кратно 3ем или 7ми");
        }
    }
}