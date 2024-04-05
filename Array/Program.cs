using System;
namespace Array;

class Program{
    public static void Main(string[] args)
    {
        /*Console.Write("Enter the array length : ");
        int a=int.Parse(Console.ReadLine());
        string[] array1=new string[a];*/

        string[] array1={"mani","suresh","venakt","yathav","venkat"};

       /* for(int i=0;i<array1.Length;i++){
            array1[i]=Console.ReadLine();
        }*/
        for(int i=0;i<array1.Length;i++){
            Console.WriteLine(array1[i]+" ");
        }

        Console.Write("Enter the name : ");
        string b=Console.ReadLine();
        bool temp=false;
        for(int i=0;i<array1.Length;i++){
            if(b==array1[i]){
                temp=true;
                break;
            }
        }

        if(temp == true){
            Console.WriteLine("The name is present in array");
        }else{
            Console.WriteLine("The name is not present in array");
        }


    
        Console.Write("Enter the name for ForEach loop : ");
        string c=Console.ReadLine();
        foreach(string i in array1 ){
                if(c==i){
                temp=true;
            }
        }

            if(temp==true){
                Console.WriteLine("The name is present in array");
            }
            else{
                Console.WriteLine("The name is not present in array");
            }
        
    }
}