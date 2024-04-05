using System;
namespace SwitchCase;

class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number 1 : ");
        double num1=double.Parse(Console.ReadLine());

        Console.Write("Enter the number two : ");
        double num2=double.Parse(Console.ReadLine());

        Console.Write("Enter the symbol : ");
        string sym=Console.ReadLine();

        switch (sym){
            case "+":
            {
                Console.WriteLine(num1+num2);
                break;
            }
            case "-":
            {
                Console.WriteLine(num1-num2);
                break;
            }
            case "*":
            {
                Console.WriteLine(num1*num2);
                break;
            }
            case "/":
            {
                Console.WriteLine(num1/num2);
                break;
            }
            case "%":
            {
                Console.WriteLine(num1%num2);
                break;
            }
            default:
            {
                Console.WriteLine("Invalid symbol");
                break;
            }

        }
    }
}