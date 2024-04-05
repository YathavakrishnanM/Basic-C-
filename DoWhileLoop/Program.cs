using System;
namespace DoWhileLoop;

class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number :");
        bool temp=int.TryParse(Console.ReadLine(),out int a);
        do{
            if(a%2==0){
                Console.WriteLine("even");
            }
            else{
                Console.WriteLine("odd");
            }
        }while(!temp);

       string userInput="";
        do{
            Console.WriteLine("If you check with another number - yes/no");
             userInput=Console.ReadLine();
             if(userInput=="yes"){
                    Console.Write("Enter the number :");
                    bool temp1=int.TryParse(Console.ReadLine(),out int a1);
                    do{
                        if(a1 % 2 == 0){
                            Console.WriteLine("even");
                        }
                        else{
                            Console.WriteLine("odd");
                        }
                    }while(!temp1);
             }
             else if(userInput=="no"){
                break;
             }
             else{
                Console.WriteLine("Please enter the correct option");
             }
        }while(userInput!="");
    }
}