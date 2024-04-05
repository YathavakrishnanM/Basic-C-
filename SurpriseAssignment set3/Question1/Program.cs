using System;
namespace Question1;

class Program{
    public static void Main(string[] args)
    {
       int num=int.Parse(Console.ReadLine());

       string a=Console.ReadLine();

       string[] x=a.Split(" ");

       string b=Console.ReadLine();

       string [] y=b.Split(" ");

       string [] z=new string[num*2];
    int j=0;
       for(int i=0;i<z.Length;i++){
         
        if(i>=0 && i<=num){
            z[i]=x[i];
        }else{
             if(j>=1 && j<=6){
                 z[i]=y[j];
                
            }else{
                break;
            }
           
           
            
        }
        j++;
       }

       for(int i=0;i<x.Length;i++){
        Console.Write(x[i]+" ");
       }
    }
}
       

        
        



        

        
    
    