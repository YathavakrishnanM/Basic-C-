using System;
namespace WhileLoop;

class Program{
    public static void Main(string[] args)
    {
        // Question 1
        
        int number=0;
        while(number<25){
            if(number%2 == 0){
                Console.WriteLine(number);
            }
            number++;
        }

        //Question 2

        Console.Write("Enter the number  :");
       
        bool temp=int.TryParse(Console.ReadLine(),out int a);

        while(!temp){
            Console.Write("Invalid input format. Please enter the input in number format : ");
            temp=int.TryParse(Console.ReadLine(),out a);
        }
    }
}