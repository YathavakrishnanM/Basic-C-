using System;
namespace WithArgumentWithReturnType;

class Program{
    public static void Main(string[] args)
    {
        int a=10;
        int b=20;
        double result=Mul(a,b);
        float x=10.4F;
        float y=5.5F;

        Div(x,y);
    }

    static double Mul(int x,int y){
        double z=x*y;
        return z;
    }

    static void Div(float x,float y){
        float z=x/y;
        Console.WriteLine(z);
        
    }
}