using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes
{
	internal class CustomCollection<T> where T : Person
	{
		public T[] Employee;
        public CustomCollection()
		{
			Employee = new T[0];
        }
        public void AddEmployee(T employee)
		{
			Array.Resize(ref Employee, Employee.Length+1);
			Employee[Employee.Length-1] = employee;
            Console.WriteLine($"{employee.Name} elave olundu");
        }
		public void GetInfoID(int id)
		{
			if(Employee.Length ==0 )
			{
                Console.WriteLine("Istifadeci yoxdur");
            }
			else
			{
				foreach (var item in Employee)
				{
					if (item.Id == id)
					{
						Console.WriteLine($"Name: {item.Name} Surname: {item.Surname} Age: {item.Age}");
					}
					else
					{

						Console.WriteLine("Istifadeci tapilmadi");
					}
				}
			}
			
		}
		public void GetAllEmployees()
		{
			if (Employee.Length == 0)
			{
				Console.WriteLine("Istifadeci yoxdur");
			}
			else
			{
				foreach (var item in Employee)
				{
					Console.WriteLine($"Name: {item.Name} Surname: {item.Surname} Age: {item.Age}");
				}
			}
		}
	}
}
