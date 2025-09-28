namespace InterfaceProject
{
	public interface IEmployeeService
	{
		public Employee[] GetAll();
		public Employee[] SearchByFullName(string searchingText);
		public Employee[] FilterByAddress(string address);
		public Employee[] SortByAge(string keyValue);
		public int SumOfEmployeesAges();
		public int AverageOfEmployeeAges();
    }
}
