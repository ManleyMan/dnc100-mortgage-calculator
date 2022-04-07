using System;

namespace dnc100_mortgage_calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
          //  Mortgage mortgage;
           double principal; 
           double interestRate, monthlyPayment;
            int term, period;
            // Use .WriteLine to greet the user
            Console.WriteLine("Welcome, calculate your Mortgage Payment, press Enter");
            // Use a mix of WriteLine and ReadLine to obtain the mortgage attributes (Making sure to typecast)
            //  Using WriteLine write a message to user to obtain the Principal
            // Using ReadLine to capture the principal and assign it to a variable
           
            Console.Write("Enter the principal amount: ");
            principal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"your principal amount is {principal}");
            Console.Write("Enter InterestRate here: ");
            interestRate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter term here: ");
            term = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter period here: ");
            period = Convert.ToInt32(Console.ReadLine());


            // Create a new Mortgage with the given attributes;
             Mortgage mortgage =  new Mortgage(principal, interestRate, term, period);

            // Use the Mortgage functions to calculate the monthly payment
             monthlyPayment = mortgage.Calculate(principal,  interestRate,  term,  period);
            // Use WriteLine to output the monthly payment
            Console.WriteLine($"your monthly payment would be {monthlyPayment}");
            Console.ReadLine();
        }
    }
}
