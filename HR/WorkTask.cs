namespace BethanysPieShopHRM.HR;

public struct WorkTask
{
    public string Description;
    public int Hours;

    public void PerformTask()
    {
        Console.WriteLine($"Task {Description} has been performed for {Hours} hours.");
    }
}