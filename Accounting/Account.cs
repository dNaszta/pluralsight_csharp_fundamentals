namespace BethanysPieShopHRM.Accounting;

public class Account
{
    private string accountNumber;

    public string AccountNumber
    {
        get => accountNumber;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Account number cannot be empty.");
                return;
            }
            accountNumber = value;
        }
    }
}