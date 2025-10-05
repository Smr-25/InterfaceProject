using InterfaceProject;

EmployeeController employeeController = new();

while (true)
{
Console.WriteLine("1. Add Employee");
Console.WriteLine("2. Show Employees");
Console.WriteLine("3. Search by Full Name");
Console.WriteLine("4. Sort Employees for Age");
Console.WriteLine("5. Get Avarage by Age");
Console.WriteLine("6. Get Sum of Ages");
Console.WriteLine("7. Quit");
Console.WriteLine();
Console.WriteLine("Please enter option number: ");
Option: string optionStr = Console.ReadLine();
bool isCorrectFormatOption = int.TryParse(optionStr, out int option);

    if (isCorrectFormatOption)
    {
        switch (option)
        {
            case (int)Operations.Create:
                employeeController.ExecuteCreate();
                break;
            case (int)Operations.Show:
                employeeController.ExecuteGetAll();
                break;
            case (int)Operations.SearchByFullName:
                employeeController.ExecuteSearchByFullName();
                break;
            case (int)Operations.SortByAge:
                employeeController.ExecuteSortByAge();
                break;
            case (int)Operations.AvarageOfAges:
                employeeController.ExecuteAvarageOfAges();
                break;
            case (int)Operations.SumOfAges:
                employeeController.ExecuteSumOfAges();
                break;
            case (int)Operations.Exit:
                Console.WriteLine("Have A Good Day");
                return;
            default:
                Console.WriteLine("Option notfound, please choose again : ");
                goto Option;
        }
    }
    else
    {
        Console.WriteLine("Option Format is wrong, please enter again");
        goto Option;
    }
}

