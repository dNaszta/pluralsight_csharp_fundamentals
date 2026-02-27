namespace BethanysPieShopHRM.HR;

public interface IEmployee
{
    double ReceiveWage(bool resetHours = true);
    void GiveBonus();
    void PerformWork();
    void PerformWork(int numberOfHours);
    void DisplayEmployeeDetails();

    void GiveCompliment();
}