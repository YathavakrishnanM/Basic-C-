using System;
namespace StringManipulation;

class Program{
    public static void Main(string[] args)
    {
        string userInput=Console.ReadLine();
        string subStr=userInput.Substring(1,2);
        string[] arr=userInput.Split(subStr);
        int count=0;
        for(int i=0;i<arr.Length;i++){
            //Console.WriteLine(arr[i]);
            
                count++;
            
        }
        Console.WriteLine(count-1);

        
    }
}