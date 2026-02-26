// See https://aka.ms/new-console-template for more information
using BethanysPieShopHRM.Accounting;
using BethanysPieShopHRM.HR;

const double monthlyWage = 25.00;
Console.WriteLine($"Your monthly wage is {monthlyWage} dollars.");

#region First run bethany
Employee bethany = new Employee("Bethany", "Smith", "bethany@likecoke.be", new DateTime(1990, 5, 15), monthlyWage, EmployeeType.Manager);
bethany.PerformWork(7);
bethany.DisplayEmployeeDetails();
double recievedWage = bethany.ReceiveWage();
Console.WriteLine($"Your received wage is {recievedWage} dollars.");
#endregion

Employee.taxRate = 0.02;
Employee.DisplayTaxRate();

#region First run george
Employee george = new("George", "Smith", "george@thehorse.uk", new DateTime(1985, 3, 20), null, EmployeeType.Research);
george.DisplayEmployeeDetails();

george.PerformWork();
george.PerformWork(10);
#endregion

int minimumBonus = 100;
int bonusTax;
int receivedBonus = bethany.CalculateBonusAndBonusTax(minimumBonus,  out bonusTax);
Console.WriteLine($"Received bonus: {receivedBonus} dollars, bonus tax is {bonusTax}. The minimum bonus was {minimumBonus} dollars.");

WorkTask task;
task.Description = "Bake delicious pies";
task.Hours = 2;
task.PerformTask();

Customer customer = new Customer();
customer.CustomerId = "C001";
customer.Name = "Alice";
Console.WriteLine($"Customer ID: {customer.CustomerId}, Name: {customer.Name}");