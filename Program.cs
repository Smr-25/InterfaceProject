using InterfaceProject;

EmployeeController employeeController = new();

while (true)
{
Console.WriteLine("1. Add Employee");
Console.WriteLine("2. Show Employees");
Console.WriteLine("3. Search by Full Name");
Console.WriteLine("4. Filter by Address");
Console.WriteLine("5. Sort Employees by Age");
Console.WriteLine("6. Get Average by Age");
Console.WriteLine("7. Get Sum of Ages");
Console.WriteLine("8. Get Employee by ID");
Console.WriteLine("9. Quit");
Console.WriteLine();
Console.WriteLine("Please enter option number: ");
Option: string optionStr = Console.ReadLine();
bool isCorrectFormatOption = int.TryParse(optionStr, out int option);

    if (isCorrectFormatOption)
    {
        switch (option)
        {
            case 1:
                employeeController.ExecuteCreate();
                break;
            case 2:
                employeeController.ExecuteGetAll();
                break;
            case 3:
                employeeController.ExecuteSearchByFullName();
                break;
            case 4:
                employeeController.ExecuteFilterByAddress();
                break;
            case 5:
                employeeController.ExecuteSortByAge();
                break;
            case 6:
                employeeController.ExecuteAvarageOfAges();
                break;
            case 7:
                employeeController.ExecuteSumOfAges();
                break;
            case 8:
                employeeController.ExecuteGetById();
                break;
            case 9:
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

