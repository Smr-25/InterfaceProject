namespace InterfaceProject
{
	public interface IEmployeeService
	{
		public IEnumerable<Employee> GetAll();
		public IEnumerable<Employee> SearchByFullName(string searchingText);
		public IEnumerable<Employee> FilterByAddress(string address);
		public IEnumerable<Employee> SortByAge(string keyValue);
		public int SumOfEmployeesAges();
		public double AverageOfEmployeeAges();
		public void Create(Employee employee);
		public Employee GetById(int id);
    }
}
