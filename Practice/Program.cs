using System;
namespace Practice;
class Program{
    public static void Main(string[] args)
    { 
      // series 2nd question
  /*        int n=int.Parse(Console.ReadLine());

        int m=int.Parse(Console.ReadLine());
        double c,fac,d=0;
        for(int i=1;i<=m;i++){

            c=Math.Pow(n,i);

            fac=1;
           for(int k=i;k>0;k--){
            fac*=k;
           }
          
          d+= c/fac;
           
          
        }

       
     Console.WriteLine(double.Round(d,3)+1.0); */

 /*   string a="yathav";
    string b="vathay";
  int count=0;
    char[] arr=new char[a.Length];

    for(int i=0;i<arr.Length;i++){
      arr[i]=a[i];
    }
    for(int i=0;i<arr.Length;i++){
      Console.WriteLine(arr[i]);
    }

    for(int i=0;i<a.Length;i++){
    for(int j=i+1;j<b.Length;j++){

      if(b[i] == a[j]){
          count++;
      }else{
        
        
      }
    }
    if (count == a.Length){
      System.Console.WriteLine("Anagram");
    }else{
      System.Console.WriteLine("not anagrsm");
    }
    }

    Console.WriteLine(b);*/
 
                 string s= Console.ReadLine();

               string x="";
                string y="";
                for(int i=0;i<s.Length;i++){
                    y=s[i].ToString();
                    if( y.ToUpper()=="A" ||  y.ToUpper()=="E" || y.ToUpper()=="I" || y.ToUpper()=="O" || y.ToUpper()=="U" || y.ToUpper()==" " ){
                      x=x+y;
                    }
                }
            System.Console.WriteLine(x);
            
    }         

}
            

