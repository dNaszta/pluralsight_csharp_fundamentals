using Newtonsoft.Json;

namespace BethanysPieShopHRM.HR;

public class Employee()
{
    public string firstName;
    public string lastName;
    public string email;
    
    public int numberOfHoursWorked;
    public double wage;
    public double? hourlyRate;

    public DateTime birthDay;
    public EmployeeType employeeType;
    
    const int minimalHoursWorkedUnit = 1;

    public static double taxRate = 0.15;
    
    public Employee(string firstName, string lastName, string email, DateTime birthDay) : this(
        firstName, lastName, email, birthDay, 0, EmployeeType.StoreManager)
    {
    }

    public Employee(string first, string last, string em, DateTime bd, double? rate, EmployeeType empType) : this()
    {
        firstName = first;
        lastName = last;
        email = em;
        birthDay = bd;
        hourlyRate = rate ?? 10;
        employeeType = empType;
    }

    public void PerformWork()
    {
        PerformWork(minimalHoursWorkedUnit);
    }
    
    public void PerformWork(int hours)
    {
        numberOfHoursWorked += hours;
        Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hours.");
    }

    public double ReceiveWage(bool resetHours = true)
    {
        double wageBeforeTax = 0.0;
        if (employeeType == EmployeeType.Manager)
        {
            Console.WriteLine($"An extra was added to the wage since {firstName} is a manager.");
            wageBeforeTax = hourlyRate.Value * numberOfHoursWorked * 1.25;
        }
        else
        {
            wageBeforeTax = numberOfHoursWorked * hourlyRate.Value;
        }
        
        double taxAmount = wageBeforeTax * taxRate;
        wage = wageBeforeTax - taxAmount;
        Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} dollars after tax - {numberOfHoursWorked} hours worked at a rate of {hourlyRate} dollars per hour.");
        if (resetHours)
            numberOfHoursWorked = 0;
        return wage;
    }
    
    public void DisplayEmployeeDetails()
    {
        Console.WriteLine($"Employee: {firstName} {lastName}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Birth Day: {birthDay.ToShortDateString()}");
        Console.WriteLine($"Hourly Rate: {hourlyRate} dollars");
        Console.WriteLine($"Hours Worked: {numberOfHoursWorked}");
        Console.WriteLine($"Tax Rate: {taxRate}");
    }

    public int CalculateBonus(int bonus)
    {
        if (numberOfHoursWorked > 10)
            bonus *= 2;
        Console.WriteLine($"The employee {firstName} {lastName} has a bonus of {bonus}");
        return bonus;
    }

    public int CalculateBonusAndBonusTax(int bonus, out int bonusTax)
    {
        bonusTax = 0;
        if (numberOfHoursWorked > 10)
            bonus *= 2;
        if (bonus >= 200)
        {
            bonusTax = bonus / 10;
            bonus -= bonusTax;
        }
        Console.WriteLine($"The employee {firstName} {lastName} has a bonus of {bonus} and a bonus tax of {bonusTax}");
        return bonus;
    }

    public string ConvertToJson()
    {
        return JsonConvert.SerializeObject(this, Formatting.Indented);
    }
    
    public static void DisplayTaxRate()
    {
        Console.WriteLine($"The current tax rate is {taxRate}");
    }
}