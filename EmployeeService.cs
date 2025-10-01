using System;
using System.Linq;

namespace InterfaceProject
{
    public class EmployeeService : IEmployeeService
    {
        private static int _countId = 0;
   
        public IEnumerable<Employee> GetAll()
        {
            return AppDbContext<Employee>.Datas;
        }

        public IEnumerable<Employee> SearchByFullName(string searchingText)
        {
            return AppDbContext<Employee>.Datas.FindAll(m => m.FullName.Contains(searchingText, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<Employee> FilterByAddress(string address)
        {
            return AppDbContext<Employee>.Datas.FindAll(m => m.Address.Equals(address, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<Employee> SortByAge(string keyValue)
        {
            switch (keyValue)
            {
                case "asc":
                    return AppDbContext<Employee>.Datas.OrderBy(m => m.Age);
                case "desc":
                    return AppDbContext<Employee>.Datas.OrderByDescending(m => m.Age);
                default:
                    return AppDbContext<Employee>.Datas;
            }
           
        }

        public int SumOfEmployeesAges()
        {
            return AppDbContext<Employee>.Datas.Sum(m=>m.Age);
        }

        public double AverageOfEmployeeAges()
        {
            return AppDbContext<Employee>.Datas.Average(m => m.Age);
        }

        public void Create(Employee employee)
        {
            employee.Id = _countId++;
            AppDbContext<Employee>.Datas.Add(employee);
        }

        public Employee GetById(int id)
        {
            return AppDbContext<Employee>.Datas.Find(m => m.Id == id);  
        }
    }
}

