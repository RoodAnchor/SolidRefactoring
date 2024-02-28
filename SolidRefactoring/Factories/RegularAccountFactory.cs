using SolidRefactoring.Accounts;

namespace SolidRefactoring.Factories
{
    /// <summary>
    /// Класс-создатель регулярного аккаунта
    /// </summary>
    internal class RegularAccountFactory : AccountFactory
    {
        internal override Account CreateAccount(double balance) =>
            new RegularAccount(balance);
    }
}