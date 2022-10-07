using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNT_Classes_Assignment
{
    internal class BankAccounts
    {
       public class SavingsAccount
        {
            public double balance; //Account Balance
            public double annualInterestRate; //Account annual interest rate
            public double monthlyInterestRate;
            public double totalDeposits;
            public double totalWithdraws;
            public double totalInterest;

            public SavingsAccount(double startBalance, double annual_Interest_Rate)
            {
                balance = startBalance;
                annualInterestRate = annual_Interest_Rate;
            }

            public void setAnnualInterestRate(double annual_Interest_Rate)
            {
                monthlyInterestRate = annualInterestRate / 12;
            }

            public void setDeposit(double amount)
            {
                balance += amount;
                totalDeposits += amount;
            }

            public void setWithdraw(double amount)
            {
                balance -= amount;
                totalWithdraws += amount;
            }

            public void calculateMonthlyInterest()
            {
                totalInterest = totalInterest + balance * monthlyInterestRate;
                balance = balance + balance * monthlyInterestRate;
            }

            public double getBalance()
            {
                return balance;
            }

            public double getAnnualInterestRate()
            {
                return annualInterestRate;
            }

            public double getMonthlyInterestRate()
            {
                return monthlyInterestRate;
            }

            public double getTotalDeposits()
            {
                return totalDeposits;
            }

            public double getTotalWithdraws()
            {
                return totalWithdraws;
            }

            public double getTotalnterest()
            {
                return totalInterest;
            }


            public void displayData()
            {
                balance = Math.Round(balance * 100.0) / 100.0;
                totalInterest = Math.Round(totalInterest * 100.0) / 100.0;
                Console.WriteLine();
                Console.WriteLine("The ending balance is: $" + balance);
                Console.WriteLine("Total amount of deposits: $" + totalDeposits);
                Console.WriteLine("Total amount of withdraws: $" + totalWithdraws);
                Console.WriteLine("Total interest earned: $" + totalInterest);
            }
        }
        public static void Main()
        {
            double startBalance;
            double annual_Interest_Rate;
            int months;
            double deposit_Amount;
            double withdraw_Amount;


           //SavingsAccount input=new SavingsAccount(startBalance, annual_Interest_Rate);

             
            Console.WriteLine("Enter starting balance: ");
            startBalance = Convert.ToDouble(Console.ReadLine());

         
            Console.WriteLine("Enter annual interest rate: ");
            annual_Interest_Rate = Convert.ToDouble(Console.ReadLine());

           
            Console.WriteLine("Enter the number of months: ");
            months = Convert.ToInt32(Console.ReadLine());   

       
            SavingsAccount sa = new
            SavingsAccount(startBalance, annual_Interest_Rate);

            
            sa.setAnnualInterestRate(annual_Interest_Rate);
 
            for (int i = 0; i < months; i++)
            {
              
                Console.WriteLine("Enter amount to deposit for the month " + (i + 1) + ":$");
                deposit_Amount = Convert.ToDouble(Console.ReadLine());
 
            
                sa.setDeposit(deposit_Amount);

         
                Console.WriteLine("Enter amount to withdraw for the month " + (i + 1) + ":$");
                withdraw_Amount = Convert.ToDouble(Console.ReadLine());

                
                sa.setWithdraw(withdraw_Amount);

             
                sa.calculateMonthlyInterest();

            }
           
            sa.displayData();

            Console.ReadLine();
        }
       
    }

}
    
