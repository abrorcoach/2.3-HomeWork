namespace _2._3_HomeWork.Ex4
{
    internal class SavingsAccount : BankAccount
    {
        public void InterestRate(double rate)
        {
            Console.WriteLine("Your interest Rate");
            Info(rate);
        }
    }
}
