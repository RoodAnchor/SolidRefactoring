using SolidRefactoring.Accounts;

namespace SolidRefactoring.Factories
{
    /// <summary>
    /// Базовый абстрактный класс-фабрика для создания аккаунтов
    /// </summary>
    internal abstract class AccountFactory
    {
        internal abstract Account CreateAccount(double balance);
    }
}
