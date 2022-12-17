using System;
using System.Security.Cryptography.X509Certificates;

namespace Discrete_Mathmatics_Project_1
{
    class program
    {
        static void Main(string[] args)
        {
            int start, end, Prime_Counter = 0, Divisor_Counter, sqrt;
            Console.WriteLine("A Program To Find The Prime Numbers Between A Range Of Numbers");  //The Program Name.
            //Prime Numbers Are Numbers Greater Than One And Only Have Two Factors, 1 And The Number Itself.

            Console.WriteLine("\nPlease, Enter The Start Number : ");  //n1
            start = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPlease, Enter The End Number : ");  //n2
            end = int.Parse(Console.ReadLine());

            Console.WriteLine("\nThe Prime Numbers Between {0} And {1} Are : ", start, end);

            while (start < 1)       //A Prime Number Can't be less Or Equal To 1 So There Is No Need To Check The Negative Numbers Or 0 And 1.
            {
                start = 2;
            }
        
            for (int i = start; i <= end; i++)     // To Check All The Numbers Between The Given Numbers.
            {
                sqrt = (int)Math.Sqrt(i);     // If The Number Hasn't A Divisior Less Than Or Equal To The Square Of The Number, Then It's A Prime Number.
                Divisor_Counter = 0;         //A Counter For The Divisiors.
                for (int j=2; j<=sqrt; j++)    //To Ckeck If The Number Has A Divisior Less Than Or Equal To The Square Of The Number.
                {
                    if (i % j == 0)  //If The Remainder Is 0, Then It's A Divisor.     
                    {
                        Divisor_Counter++;  //If The Number Has A Divisior Less Than Or Equal To The square Of The Number, Then It's Not A Prime Number So Increase The Divisior Counter By 1, Then Exit The Loop.    
                        break;           
                    }
                }
                if (Divisor_Counter == 0 && i>1)   // If The Number Hasn't A Divisior Less Than Or Equal To The Square Of The Number And The Number Doesn't Equal 0 Or 1, Then It's A Prime Number.
                {
                    Console.Write("{0} ",i);  //Write The Prime Number.
                    Prime_Counter++;    //There Exist A Prime Number.
                }
            }
            if ( Prime_Counter == 0)  //If There Are No Prime Numbers.
                Console.WriteLine("There Are No Prime Numbers.");
        }
    }
}