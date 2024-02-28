namespace SolidRefactoring.Accounts
{
    /// <summary>
    /// Базовый абстрактный класс аккаунтов
    /// </summary>
    public abstract class Account
    {
        public Double Balance { get; set; }
        public Double Interest { get; set; }

        public Account(Double balance) =>
            Balance = balance;
    }
}
