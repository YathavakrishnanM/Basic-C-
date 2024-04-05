using System;
namespace Methods;

class Program{
    public static void Main(string[] args)
    {
        string ask="";

        do{
            Console.Write("Enter the first number : ");
            int a=int.Parse(Console.ReadLine());
            Console.Write("Enter the second number : ");
            int b=int.Parse(Console.ReadLine());
    
        Console.Write("Enter the operation : ");
        char sym=char.Parse(Console.ReadLine());

        switch(sym){
            case '+':
            {
               Console.WriteLine( Add(a,b));
                break;
            }
             case '-':
            {
               Console.WriteLine( Sub(a,b));
                break;
            }
             case '*':
            {
               Console.WriteLine( Mul(a,b));
                break;
            }case '/':
            {
              Console.WriteLine(  Div(a,b));
                break;
            }
        }
         Console.Write("If you want continue yes/no  : ");
        ask=Console.ReadLine();
        }while(ask=="yes");

    }
    static int Add(int a,int b){
        return a+b;
    }
     static int Sub(int a,int b){
        return a-b;
    }
     static int Mul(int a,int b){
        return a*b;
    }
     static int Div(int a,int b){
        return a/b;
    }
   

    
    
}