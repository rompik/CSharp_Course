namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(100);
            account.Notify += DisplayMessage;

            account.Put(20);
            account.Take(70);
            account.Take(150);

            void DisplayMessage(Account sender, AccountEventsArgs e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Сумма транзакции: {e.Sum}");
                Console.WriteLine(e.Message);
                Console.WriteLine($"Текущая сумма на счете: {sender.Sum}");
                Console.ResetColor();
            }
        }
    }

    public class Account
    {

        public delegate void AccountHandler(Account sender, AccountEventsArgs e);

        public event AccountHandler? Notify;

        public int Sum { get; private set; }

        public Account(int sum)
        {
            Sum = sum;
        }

        public void Put(int sum)
        {
            Sum += sum;
            Notify?.Invoke(this, new AccountEventsArgs($"На счет поступило {sum}", sum));
        }

        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke(this, new AccountEventsArgs($"Сумма {sum} снята со счета", sum));
            }

            else
            {
                Notify?.Invoke(this, new AccountEventsArgs($"Недостаточно денег на счете.", sum));
            }
        }
    }

    public class AccountEventsArgs
    {
        public string Message { get; }
        public int Sum { get; }

        public AccountEventsArgs(string message, int sum)
        {
            Message = message;
            Sum = sum;
        }
    }
}
