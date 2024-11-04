using ReporterCode;

List<Employee> employies = new()
{
    new Employee{ Name = "Ivan", Salary = 100},
    new Employee{ Name = "Petr", Salary = 50},
    new Employee{ Name = "Vlad", Salary = 200}
};

var builder = new EmployeeReportBuilder(employies);

var director = new EmployeeReportDirector(builder);

director.Build();

var report = builder.GetReport();

Console.WriteLine(report);

Console.ReadKey();