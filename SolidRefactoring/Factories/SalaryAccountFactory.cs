using SolidRefactoring.Accounts;

namespace SolidRefactoring.Factories
{
    /// <summary>
    /// Класс-создатель зарплатного аккаунта
    /// </summary>
    internal class SalaryAccountFactory : AccountFactory
    {
        internal override Account CreateAccount(double balance) =>
            new SalaryAccount(balance);
    }
}
