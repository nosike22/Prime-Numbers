using System;


namespace Prime_Number_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            int divisors = 0;

            for (int i = 1; i <= number; i++) 
            {
                if (number % 1 == 0) 
                {
                    divisors++;
                }

                if (divisors == 2)
                {
                    Console.WriteLine("The Above Number is a prime number");

                }

                else
                {
                    Console.WriteLine("The Above Number is not a prime number");
                    Console.ReadLine();
                }

                
           
            }




        }
    }
}
