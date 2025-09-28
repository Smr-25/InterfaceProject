using InterfaceProject;
IEmployeeService employee = new EmployeeService();


//foreach(var e in employee.SortByAge("desc"))
//    Console.WriteLine($"{e.FullName} {e.Address} {e.Email} {e.Age} {e.Phone}");

//foreach (var e in employee.GetAll())
//    Console.WriteLine($"{e.FullName} {e.Address} {e.Email} {e.Age} {e.Phone}");

//foreach (var e in employee.SearchByFullName("n"))
//    Console.WriteLine($"{e.FullName} {e.Address} {e.Email} {e.Age} {e.Phone}");

//foreach (var e in employee.FilterByAddress("Baku"))
//    Console.WriteLine($"{e.FullName} {e.Address} {e.Email} {e.Age} {e.Phone}");

Console.WriteLine(employee.SumOfEmployeesAges());

Console.WriteLine(employee.AverageOfEmployeeAges());
