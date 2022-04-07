using System;
using System.Collections.Generic;
using System.Text;

namespace dnc100_mortgage_calculator
{
    public class Mortgage
    {
        public Mortgage(double principal, double interest, int term, int period)
        {
      
            Calculate(principal,  interest,  term,  period);
           
        }

        public double Calculate(double principal, double interest, int term, int period)
        {   
         
             term = NumberOfPayments(term,period);
            interest = MonthlyInterestRate(interest, period);
            double x = CompoundedInterestRate(interest,term);
           double mortgage = Math.Round((principal*(interest*x)/(x-1)),2);
         
            return mortgage;
        }

        public double MonthlyInterestRate(double interest, int period)
        {
         return  (interest / 100) / period;
        }

        public int NumberOfPayments(int term, int period)
        {
            return term * period;
        }

        public double CompoundedInterestRate(double monthlyInterestRate, int numberOfPayments)
        {
            return Math.Pow((1+monthlyInterestRate),numberOfPayments);
        }

        public double InterestQuotient(double monthlyInterestRate, double compoundedInterestRate, int numberOfPayments)
        {   
             return Math.Abs((monthlyInterestRate * numberOfPayments) * (1 - compoundedInterestRate));
        }
    }
}
