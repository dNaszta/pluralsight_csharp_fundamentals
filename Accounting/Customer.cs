namespace BethanysPieShopHRM.Accounting;

public class Customer
{
    private string customerId;
    private string name;
    
    public string CustomerId
    {
        get => customerId;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Customer ID cannot be empty.");
                return;
            }
            customerId = value;
        }
    }
    
    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Customer name cannot be empty.");
                return;
            }
            name = value;
        }
    }
}