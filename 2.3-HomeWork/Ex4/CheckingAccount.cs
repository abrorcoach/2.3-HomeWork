namespace _2._3_HomeWork.Ex4
{
    internal class CheckingAccount : BankAccount
    {
        public void OverdraftLimit(double limit)
        {
            Console.WriteLine("Your overdraft limit");
            Info(limit);
        }
    }
}
