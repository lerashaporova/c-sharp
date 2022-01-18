using System;

public class MainClass
{
    public static void Main()
    {
        int[] array = new int[6];
        array[0] = 1;
        array[1] = 2;
        array[2] = 3;
        array[3] = 4;
        array[4] = 5;
        array[5] = 6;
      Console.WriteLine(array);

        List <int> num = new List<int>();
        num.Add(1);
        num.Add(2);
        num.Add(3);
        num.AddRange(num);
    }
}