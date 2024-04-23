namespace GenericTypes
{
	internal class Program
	{
		static void Main(string[] args)
		{


			CustomCollection<Employee> employees = new CustomCollection<Employee>();
			while (true)
			{

				Console.WriteLine("Birini secin:");
				Console.WriteLine("1.Add Employee");
				Console.WriteLine("2.Find Employee By Id");
				Console.WriteLine("3. Get All Employees");

				int choice = int.Parse(Console.ReadLine());
				switch (choice)
				{
					case 1:
						Console.WriteLine("Adinizi daxil edin: ");
						string name = Console.ReadLine();
						Console.WriteLine("Soyadinizi daxil edin: ");
						string surname = Console.ReadLine();
						Console.WriteLine("Yasinizi daxil edin: ");
						byte age = byte.Parse(Console.ReadLine());
						Employee employee = new Employee()
						{
							Name = name,
							Surname = surname,
							Age = age

						};
						employees.AddEmployee(employee);
						break;
					case 2:
                        Console.WriteLine("Id daxil edin: ");
                        int id = int.Parse(Console.ReadLine());
						employees.GetInfoID(id);
						break;
					case 3:
						employees.GetAllEmployees();
						break;
				}
				Console.WriteLine("Davam etmek isteyirsiz?");
				string response = Console.ReadLine();
				if (response.ToLower() == "beli".ToLower())
				{
					continue;
				}
				else 
				{ 
					Environment.Exit(0);	
				}
			}

		}
	}
}