using System;
namespace TypeConversion;

class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name : ");
        string name=Console.ReadLine();

        Console.Write("Enter your age :");
        int age=int.Parse(Console.ReadLine());

        Console.Write("Enter mark of subject1 :");
        double subject1=double.Parse(Console.ReadLine());

        Console.Write("Enter mark of subject2 :");
        double subject2=double.Parse(Console.ReadLine());

        Console.Write("Enter mark of subject3 :");
        double subject3=double.Parse(Console.ReadLine());

        Console.Write("Enter a Grade :");
        char grade=char.Parse(Console.ReadLine());

        Console.Write("Enter mobile number : ");
        long num=long.Parse(Console.ReadLine());

        Console.Write("Enter email Id : ");
        string email=Console.ReadLine();

        double total=subject1+subject2 +subject3;
        double avg=total/3;

        Console.WriteLine("Trainee Details are :");
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Age : " + age);
        Console.WriteLine("Mobile : " + num);
        Console.WriteLine("Marks1 : " + subject1);
        Console.WriteLine("Mark2 : " + subject2);
        Console.WriteLine("Mark3 : " + subject3);
        Console.WriteLine("Total : " + total);
        Console.WriteLine("Average : " + avg);
        Console.WriteLine("Grade : " + grade);
        Console.WriteLine("Mail id : " + email);

    }
}