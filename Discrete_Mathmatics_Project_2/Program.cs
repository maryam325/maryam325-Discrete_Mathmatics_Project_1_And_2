using System;

namespace Discrete_Mathmatics_Project_2
{
    class program
    {
        static void Main(string[] args)
        {
            int start, end, Check_Divisor, sum, Perfect_Counter = 0;
            Console.WriteLine("A Program To Find The Prime Numbers Between A Range Of Numbers");  //The Program Name.
            //Perfect Number Is A Positive Integer That Is Equal To The Sum Of Its Positive Divisors, Excluding The Number Itself.

            Console.WriteLine("\nPlease, Enter The Start Number : ");
            start = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPlease, Enter The End Number : ");
            end = int.Parse(Console.ReadLine());

            Console.WriteLine("\nThe Prime Numbers Between {0} And {1} Are : ", start, end);

            while (start < 6)     //The Smallest Perfect Number Is 6 So There Is No Need To Check Negative Numbers Or Positive Numbers Less Than 6.
            {
                start = 6;
            }

            for (int i = start; i <= end; i++)    // To Check All The Numbers Between The Given Numbers.
            {
                sum = 0;
                Check_Divisor = 1;     // 1 Is A Divisor For Any Number.           
                while (Check_Divisor < i)  //The Operation Is Less Than Not Or Equal, To Exclude The Number Itself.
                {
                    if (i % Check_Divisor == 0)   //If The Remainder Is 0, Then It's A Divisor.
                        sum += Check_Divisor;     
                    Check_Divisor++;
                }
                if (sum == i)    //If The Number Equal To The Sum Of It's Positive Divisors Excluding The Number Itself, Then It's A Perfect Number.
                {
                    Perfect_Counter++;      //There Exist A Perfect Number.
                    Console.Write("{0} ", i);   //Write The Perfect Number.
                }
                    
            }
            if(Perfect_Counter==0)   //If There Are No Perfect Numbers.
            Console.WriteLine("There Are No Perfect Numbers.");
        }
    }
}