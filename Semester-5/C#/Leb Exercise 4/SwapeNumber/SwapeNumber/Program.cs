using System;
class Programe {
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Firts Number :");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Second Number :");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int temp;

        temp = num1;
        num1 = num2;
        num2 = temp;

        Console.WriteLine("After Swape");
        Console.WriteLine("First Numebr :"+num1);
        Console.WriteLine("Second Numebr :"+num2);
    }
}