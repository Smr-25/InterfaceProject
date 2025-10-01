using System;
using System.Linq;

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

            bool isSearchingText = !string.IsNullOrWhiteSpace(searchingTxt) && searchingTxt.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
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

            bool isSearchingAddress = !string.IsNullOrWhiteSpace(searchingAddress) && searchingAddress.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c) || c == ',' || c == '.' || c == '-');
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
            foreach (var item in _employeeService.SortByAge(keyValue))
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
                Console.WriteLine("Incorrect id format");
                goto Id;
            }

            var item =  _employeeService.GetById(id);

            Console.WriteLine(item.Id + " " + item.FullName + " " + item.Age + " " + item.Email + " " + item.Address);
        }

        public void ExecuteCreate()
        {
            Console.WriteLine();

            Console.WriteLine("Input full name");
        FullName: string fullName = Console.ReadLine();
            bool isText = !string.IsNullOrWhiteSpace(fullName) && fullName.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
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
                goto Phone;
            }

        }


    }
}

