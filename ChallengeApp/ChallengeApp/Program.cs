using ChallengeApp;

var employee = new Employee("Jan", "Kowalski");
employee.AddGrade(6);
employee.AddGrade(2.2);
employee.AddGrade(2);
employee.AddGrade(6);
var statistics = employee.GetStatistics();
var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();




//Console.WriteLine($"Avarage: {statistics.Avarage:N2}");
//Console.WriteLine($"Min: {statistics.Min}");
//Console.WriteLine($"Max {statistics.Max}");









