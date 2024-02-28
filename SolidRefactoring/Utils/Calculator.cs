using SolidRefactoring.Accounts;

namespace SolidRefactoring.Utils
{
    /// <summary>
    /// Калькулятор процентной ставки
    /// </summary>
    internal static class Calculator
    {
        internal static void CalculateInterest(ICalculatable account) =>
            account.CalculateInterest();
    }
}
