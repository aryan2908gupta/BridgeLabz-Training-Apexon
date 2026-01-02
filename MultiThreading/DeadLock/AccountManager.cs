using MultiThreading.DeadLock;

using System.Threading;

internal class AccountManager
{
    private Account FromAccount;
    private Account ToAccount;

    public AccountManager(Account from, Account to)
    {
        FromAccount = from;
        ToAccount = to;
    }

    public void FundTransfer()
    {
        lock (FromAccount)              // 🔒 lock 1
        {
            Thread.Sleep(1000);         // ⏸ still holding lock 1

            lock (ToAccount)            // 🔒 lock 2
            {
                // never reaches here
            }
        }
    }
}
