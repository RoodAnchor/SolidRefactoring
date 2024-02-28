namespace SolidRefactoring.Accounts
{
    /// <summary>
    /// Класс обычного аккаунта
    /// </summary>
    public class RegularAccount : Account, ICalculatable
    {
        public RegularAccount(Double balance) : 
            base(balance) 
        { }

        /// <summary>
        /// Реализация расчёта процентной ставки
        /// </summary>
        public void CalculateInterest()
        {
            Interest = Balance * 0.4;

            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance >= 1000)
                Interest -= Balance * 0.4;
        }
    }
}
