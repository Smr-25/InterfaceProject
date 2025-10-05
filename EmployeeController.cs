namespace InterfaceProject
{
	public class EmployeeController
	{
		private readonly IEmployeeService _employeeService;

        public EmployeeController()
		{
			_employeeService = new EmployeeService();
		}

		public void ExecuteGetAll()
		{
			foreach (var item in _employeeService.GetAll())
			{
				Console.WriteLine(item.FullName + " " + item.Age + " " + item.Email + " " + item.Address);
			}
		}

		public void ExecuteSearchByFullName()
		{
            Console.WriteLine("Input Text");
        SearchText: string searchingTxt = Console.ReadLine();

            bool isSearchingText = searchingTxt.All(char.IsLetter);
            if (!isSearchingText)
            {
                Console.WriteLine("Incorrect Text");
                goto SearchText;

            }

            foreach (var item in _employeeService.SearchByFullName(searchingTxt))
            {
                Console.WriteLine(item.FullName + " " + item.Age + " " + item.Email + " " + item.Address);
            }
        }

        public void ExecuteFilterByAddress()
        {

            Console.WriteLine("Input Address for Filtering");
        SearchingAddress: string searchingAddress = Console.ReadLine();

            bool isSearchingAddress = searchingAddress.All(char.IsLetter);
            if (!isSearchingAddress)
            {
                Console.WriteLine("Incorrect Text");
                goto SearchingAddress;

            }
            foreach (var item in _employeeService.FilterByAddress(searchingAddress))
            {
                Console.WriteLine(item.FullName + " " + item.Age + " " + item.Email + " " + item.Address);
            }
        }

        public void ExecuteSortByAge()
        {
            Console.WriteLine("Input asc or desc");
        KeyValue: string keyValue = Console.ReadLine();

            bool isKeyValue = keyValue.All(char.IsLetter);

            if (!isKeyValue)
            {
                Console.WriteLine("Incorrect Option");
                goto KeyValue;

            }
            foreach (var item in _employeeService.SortByAge("asc"))
            {
                Console.WriteLine(item.FullName + " " + item.Age + " " + item.Email + " " + item.Address);
            }
        }

        public void ExecuteSumOfAges()
        {
            Console.WriteLine(_employeeService.SumOfEmployeesAges());
        }

        public void ExecuteAvarageOfAges()
        {
            Console.WriteLine(_employeeService.AverageOfEmployeeAges());
        }

        public void ExecuteGetById()
        {
        Id: string idStr = Console.ReadLine();
            bool isCorrectId = int.TryParse(idStr, out int id);
            if (!isCorrectId)
            {
                try
                {
                    var item = _employeeService.GetById(id);
                    Console.WriteLine(item.Id + " " + item.FullName + " " + item.Age + " " + item.Email + " " + item.Address);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Incorrect id format");
                    goto Id;
                }
                Console.WriteLine("Incorrect id format");
                goto Id;
            }

          
        }

        public void ExecuteCreate()
        {
            Console.WriteLine();

            Console.WriteLine("Input full name");
        FullName: string fullName = Console.ReadLine();
            bool isText = fullName.All(char.IsLetter);
            if (!isText)
            {
                Console.WriteLine("Incorrect Full Name");
                goto FullName;

            }

            Console.WriteLine("Input age");
        Age: string ageStr = Console.ReadLine();
            bool isCorrectAge = int.TryParse(ageStr, out int age);
            if (!isCorrectAge)
            {
                Console.WriteLine("Incorrect age format");
                goto Age;
            }
          
            Console.WriteLine("Input email");
            string email = Console.ReadLine();

            Console.WriteLine("Input address");
            string address = Console.ReadLine();

            Console.WriteLine("Input phone +994 ");
        Phone: string phoneStr = Console.ReadLine();
            bool isCorrectPhone = int.TryParse(phoneStr, out int phone);
            if (isCorrectPhone)
            {
                _employeeService.Create(new Employee
                {
                    FullName = fullName,
                    Age = age,
                    Email = email,
                    Address = address,
                    Phone = phone

                });
                Console.WriteLine("Created");
            }
            else
            {
                Console.WriteLine("Incorrect phone format");
                goto Age;
            }

        }


    }
}

