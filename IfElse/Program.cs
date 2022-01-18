using System;
class HelloWorld
{
    static void Main()
    { 
        int a, b;
        Console.WriteLine("Введите количество голов у хозяев");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество голов у гостей");
        b = Convert.ToInt32(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine("Выиграли хозяева");
        } else if (a < b) {
            Console.WriteLine("Выиграли гости");
        } else {
            Console.WriteLine("Ничья");
        }
    }   
}