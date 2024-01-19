using ChallengeApp;

var employee = new Employee("Jan", "Kowalski");
employee.AddGrade("Jan");
employee.AddGrade("4000");
employee.AddGrade(2);
employee.AddGrade(6);
var statistics = employee.GetStatistics();


Console.WriteLine($"Avarage: {statistics.Avarage:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max {statistics.Max}");









