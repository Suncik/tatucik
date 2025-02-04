    using System;
using System.Runtime.Intrinsics.Arm;
class Program{
        static void Main(){
            //1-masala
            // System.Console.WriteLine("x sonini kiriting:");
            // int x=Convert.ToInt32(Console.ReadLine());
            // string str="telefon";
            // if(x>str.Length){
            //     System.Console.WriteLine("TELEFON");
            // }  else System.Console.WriteLine("telefon");
            //2-masala
            // int x=15;
            // int y=10;
            // if(x>y){
            //     System.Console.WriteLine("x is greater than y");

            // }   else if(x<y){
            //     System.Console.WriteLine("x is  less than y");
            // } else if(x==y){
            //     System.Console.WriteLine("x is equal to y");
            // }  else System.Console.WriteLine("x and y are not comparable");
            System.Console.WriteLine("hafta kunini  kiriting:");
            string nameDay=Console.ReadLine();
            switch(nameDay){
                case "dushanba": System.Console.WriteLine("Monday");  break;
                case "seshanba": System.Console.WriteLine("tuesday");  break;
                case "chorshanba": System.Console.WriteLine("wendsday");  break;
                case "payshanba": System.Console.WriteLine("thursday");  break;
                case "juma": System.Console.WriteLine("friday");  break;
                case "shanba": System.Console.WriteLine("saturday");  break;
                case "yakshanba": System.Console.WriteLine("sunday");  break;
            }





























































        }
    }
