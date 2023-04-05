using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int z;
             do
             {
                 Console.WriteLine("Enter two numbers");
                 int a = Convert.ToInt32(Console.ReadLine());
                 int b = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("1. Add");
                 Console.WriteLine("2. Sub");
                 Console.WriteLine("3. Multi");
                 Console.WriteLine("4. Division");
                 Console.WriteLine("5. Mod");
                 Console.WriteLine("select your option");
                 int op = Convert.ToInt32(Console.ReadLine());
                 switch (op)
                 {
                     case 1:
                         Console.WriteLine($"Addition is {a + b}");
                         break;
                     case 2:
                         Console.WriteLine($"Sub is {a - b}");
                         break;
                     case 3:
                         Console.WriteLine($"Multiplication is {a * b}");
                         break;
                     case 4:
                         Console.WriteLine($"Division is {a/b}");
                         break;
                     case 5:
                         Console.WriteLine($"mod is{a%b}");
                         break;
                     default:
                         Console.WriteLine("Wrong option selection");
                         break;
                 }
                 Console.WriteLine("Select 1 for continue and 0 for exit");
                 z = Convert.ToInt32(Console.ReadLine());
             } while (z == 1);*/


            //WAP to print numbers from 1 - 10
            /*int a = 1;
            do
            {
                Console.WriteLine(a);
                a++;
            }
            while (a <= 10);

            //WAP to print even numbers from 1.- 50
           
            int b = 1;
            Console.WriteLine("The numbers from 1 to 50 are :- ");
            do
            { 
                
                Console.WriteLine(b);
                b++;
            }
            while (b <= 50);

            //WAP to print odd numbers from 1 - 50
            int c = 1;
            Console.WriteLine("--------------------------");
            do
            {
                if(c% 2 != 0)
                Console.WriteLine(c);
                c++;
            }
            while (c <=50  );


            //WAP to print series from 100 - 50

            int d = 100;
            do
            {
                Console.WriteLine(d);
                d--;
            }
            while (d >= 50); */





            //WAP to accept a 3 digit number from user &print in reverse order using while loop
            // Input: 123
            //Output: 321

            /*Console.WriteLine("enter a number:- ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number:- ");
            int b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("enter a third number:- ");
            int c = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"{a}{b}{c}");

            Console.WriteLine($"The reverse order is {c}{b}{a}" );*/
            /*
                        //wap to print reverse number
                        int n, rem, rev = 0;
                        n = Convert.ToInt32(Console.ReadLine());
                        while(n>0)
                        {
                            rem = n % 10;
                            rev = rev * 10 + rem;
                            n = n / 10;

                        }
                        Console.WriteLine("Reverse number is " + rev);*/


            //wap to print armstrong number or not
            int rem, sum = 0;
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;

            while(num!=0)
            {
                rem = num % 10;
                sum = sum + (rem * rem * rem);
                num = num / 10;

            }
            if(temp==num)
            {
                Console.WriteLine("It is Armstrong number");
            }
          





        }

    }
}
