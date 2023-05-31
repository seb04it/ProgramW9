using ProgramW9;

var employee = new Employee("Adam", "K");
employee.AddGrade(2);
employee.AddGrade(7);
employee.AddGrade(5);
var statistics = employee.GetStatistics();

Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Average: { statistics.Average:N2}");