using SolidRefactoring.Utils;
using SolidRefactoring.Accounts;
using SolidRefactoring.Factories;

namespace SolidRefactoring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccountFactory regAccountFactory = new RegularAccountFactory();
            RegularAccount regularAccount = (RegularAccount)regAccountFactory.CreateAccount(1100);
            Calculator.CalculateInterest(regularAccount);

            AccountFactory sallaryAccountFactory = new SalaryAccountFactory();
            SalaryAccount sallaryAccount = (SalaryAccount)sallaryAccountFactory.CreateAccount(900);
            Calculator.CalculateInterest(sallaryAccount);

            Console.WriteLine($"Regular account interest: {regularAccount.Interest}");
            Console.WriteLine($"Sallary account interest: {sallaryAccount.Interest}");
        }
    }
}