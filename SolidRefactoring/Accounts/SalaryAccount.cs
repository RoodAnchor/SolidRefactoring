namespace SolidRefactoring.Accounts
{
    /// <summary>
    /// Класс зарплатного аккаунта
    /// </summary>
    public class SalaryAccount : Account, ICalculatable
    {
        public SalaryAccount(Double balance) :
            base(balance)
        { }

        /// <summary>
        /// Реализация расчёта процентной ставки
        /// </summary>
        public void CalculateInterest() =>
            Interest = Balance * 0.5;
    }
}
