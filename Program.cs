#region Task2
using Encapsulation__Readonly_fields.Modes;

Employee emp1 = new Employee(1, "John Doe", "Manager", 50000);
Employee emp2 = new Employee(2, "Jane Smith", "Developer", 60000);

// Setting information for each employee using setter methods
emp1.UpdateSalary(55000);
emp2.ChangePosition("Senior Developer");

// Displaying employee information using getter methods
emp1.DisplayEmployeeInformation();
Console.WriteLine();
emp2.DisplayEmployeeInformation();
#endregion