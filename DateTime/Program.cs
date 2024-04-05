using System;
using System.Globalization;
using System.Runtime.InteropServices;
namespace DateTimeAssignment;

class Program{
    public static void Main(string[] args)
    {
       DateTime dob=new DateTime(2021,8,10,10,40,32);

        Console.WriteLine("Days- " + dob.Day);
         Console.WriteLine("Month- " + dob.Month);
          Console.WriteLine("Year- " + dob.Year);
           Console.WriteLine("Minute- " + dob.Minute);
            Console.WriteLine("Seconds- " + dob.Second);

           string con= dob.ToString("yyyy/MM/dd  hh:mm:ss  tt");

           string [] s=con.Split(new char[]{'/',':',' '});

          for(int i=s.Length-1;i>=0;i--){
                Console.Write(s[i]+ " ");
          }
          Console.WriteLine(" ");

          
          Console.WriteLine("Enter the values in yyyy/MM/dd hh:mm:ss tt format  :  ");
          
            DateTime date=new DateTime();
          	bool temp=DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt ",null,System.Globalization.DateTimeStyles.None,out date);
		
            while(!temp){
                Console.WriteLine("Invalid format");
                temp=DateTime.TryParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out date);
            }
        
         Console.WriteLine("Year- " + date.Year);
         Console.WriteLine("Month- " + date.Month);   
         Console.WriteLine("Days- " + date.Day);
        
                

      

    }
}