using System;
namespace ForLoop;

class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the first number : ");
        int startNumber=int.Parse(Console.ReadLine());

        Console.Write("Enter the second number : ");
        int endNumber = int.Parse(Console.ReadLine());
        
        int sum=0;
        int squreValue=0;
       
        for(int i=startNumber;i<=endNumber;i++){
            squreValue=i*i;
            sum=squreValue+sum;
        }
        
        Console.WriteLine(sum);


    }
}