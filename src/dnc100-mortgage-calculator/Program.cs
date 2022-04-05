using System;

namespace dnc100_mortgage_calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
          //  Mortgage mortgage;
           double principal; 
           double interestRate, monthlyPayment;
            int term, period;
            // Use .WriteLine to greet the user
            Console.WriteLine("Welcome, calculate your Mortgage Payment");
            // Use a mix of WriteLine and ReadLine to obtain the mortgage attributes (Making sure to typecast)
            //  Using WriteLine write a message to user to obtain the Principal
            // Using ReadLine to capture the principal and assign it to a variable
            Console.WriteLine("Enter the principal amount");
            principal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter InterestRate here");
            interestRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter term here");
            term = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter period here");
            period = Convert.ToInt32(Console.ReadLine());


            // Create a new Mortgage with the given attributes;
             monthlyPayment =  Convert.ToDouble(new Mortgage(principal, interestRate, term, period));

            // Use the Mortgage functions to calculate the monthly payment

            // Use WriteLine to output the monthly payment
            Console.WriteLine($"your monthly payment would be {monthlyPayment}");
        }
    }
}
