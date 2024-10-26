
using JShopping;
try
{
  Employee employee1 = new SalaryEmployee()
  {
    Id = 1,
    FirstName = "Jairo",
    LastName = "Munoz",
    BirthDate = new Date(1990, 4, 23),
    HiringDate = new Date(2022, 4, 12),
    IsActive = true,
    Salary = 182834454.45M
  };
  // Console.WriteLine(employee1);

  Employee employee2 = new CommissionEmployee()
  {
    Id = 91,
    FirstName = "Samuel",
    LastName = "Munoz",
    BirthDate = new Date(1995, 1, 23),
    HiringDate = new Date(2022, 4, 22),
    IsActive = true,
    Sales = 30000000M,
    CommissionPercentaje = 0.03F
  };
  // Console.WriteLine(employee2);

  Employee employee3 = new HourlyEmployee()
  {
    Id = 44,
    FirstName = "Mami",
    LastName = "Munoz",
    BirthDate = new Date(1995, 1, 23),
    HiringDate = new Date(2022, 4, 22),
    IsActive = true,
    Hours = 123.5F,
    HourValue = 10033.55M
  };
  // Console.WriteLine(employee3);

  Employee employee4 = new BaseCommissionEmployee()
  {
    Id = 56,
    FirstName = "Pa",
    LastName = "Munoz",
    BirthDate = new Date(1995, 1, 23),
    HiringDate = new Date(2022, 4, 22),
    IsActive = true,
    Base = 453344.45M,
    Sales = 56999999M,
    CommissionPercentaje = 0.015F
  };
  // Console.WriteLine(employee4);

  ICollection<Employee> employees = [
    employee1, employee2, employee3, employee4
  ];

  decimal payroll = 0;
  foreach (Employee employee in employees)
  {
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
  }
  Console.WriteLine("                               ==================");
  Console.WriteLine($"TOTAL                          {$"{payroll:C2}",18}");

  Invoice invoice1 = new()
  {
    Description = "iPhone 13",
    Id = 1,
    Price = 5300000M,
    Quantity = 6
  };
  Invoice invoice2 = new()
  {
    Description = "Posta Preum",
    Id = 2,
    Price = 32000M,
    Quantity = 17.5F
  };
  Console.WriteLine(invoice1);
  Console.WriteLine(invoice2);
}
catch (Exception error)
{
  Console.WriteLine(error.Message);
}