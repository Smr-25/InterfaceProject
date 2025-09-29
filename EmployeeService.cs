namespace InterfaceProject
{
    public class EmployeeService : IEmployeeService
    {
        public Employee[] GetAll()
        {

            Employee employee1 = new()
            {
                FullName = "Ramiz Yusifov",
                Address = "Baku",
                Email = "rmz@edu.az",
                Age = 24,
                Phone = "+994 51 111 11 11"
            };
            Employee employee2 = new()
            {
                FullName = "Aslan Ahmedov",
                Address = "Sumgayit",
                Email = "asln@edu.az",
                Age = 30,
                Phone = "+994 51 222 22 22"
            };
            Employee employee3 = new()
            {
                FullName = "Vuqar Beylerov",
                Address = "Lankaran",
                Email = "vgr@edu.az",
                Age = 26,
                Phone = "+994 51 333 33 33"
            };

            Employee employee4 = new()
            {
                FullName = "Nigar Xanlarova",
                Address = "Lankaran",
                Email = "ngr@edu.az",
                Age = 27,
                Phone = "+994 51 444 44 44"
            };

            Employee employee5 = new()
            {
                FullName = "Tofiq Bayramov",
                Address = "Baku",
                Email = "tfg@edu.az",
                Age = 35,
                Phone = "+994 51 555 55 55"
            };

            return new Employee[] { employee1, employee2, employee3, employee4, employee5 };
        }

        public Employee[] SearchByFullName(string searchingText)
        {
            if (string.IsNullOrWhiteSpace(searchingText))
                return GetAll();

            return Array.FindAll(GetAll(), e => e.FullName.Contains(searchingText, StringComparison.OrdinalIgnoreCase
                ));
        }

        public Employee[] FilterByAddress(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
                return GetAll();

            return Array.FindAll(GetAll(), e => e.Address.Equals(address, StringComparison.OrdinalIgnoreCase
                ));
        }

        public Employee[] SortByAge(string keyValue)
        {
            Employee[] employees = GetAll();
            switch (keyValue)
            {
                case "asc":
                    Array.Sort(employees, (e1, e2) => e1.Age.CompareTo(e2.Age));
                    break;
                case "desc":
                    Array.Sort(employees, (e1, e2) => e2.Age.CompareTo(e1.Age));
                    break;
            }
            return employees;
            
        }

        public int SumOfEmployeesAges()
        {
            int sum = 0;
            foreach (var e in GetAll())
                sum += e.Age;
            return sum;
        }

        public int AverageOfEmployeeAges()
        {
            int result = 0;
            foreach (var e in GetAll())
            {
                result += e.Age;
            }
            return result / GetAll().Length;
        }
    }
}

