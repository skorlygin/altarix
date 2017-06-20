using System;
using System.Collections.Generic;

namespace task2
{
	class Program
	{
		//to-do: выпилить все foreach
		//to-do: разбить на методы
		//to-do: пофиксить баги
		static void Main(string[] args)
		{
			var employees = new List<Employee>();
			var activities = new List<Activity>();
			var salaries = new List<Salary>();

			employees.Add(new Employee
			{
				Id = Guid.NewGuid(),
				Name = "A"
			});
			employees.Add(new Employee
			{
				Id = Guid.NewGuid(),
				Name = "B"
			});
			employees.Add(new Employee
			{
				Id = Guid.NewGuid(),
				Name = "C"
			});
			employees.Add(new Employee
			{
				Id = Guid.NewGuid(),
				Name = "D"
			});
			employees.Add(new Employee
			{
				Id = Guid.NewGuid(),
				Name = "E"
			});
			employees.Add(new Employee
			{
				Id = Guid.NewGuid(),
				Name = "F"
			});

			activities.Add(new Activity
			{
				Id = Guid.NewGuid(),
				Name = "a"
			});
			activities.Add(new Activity
			{
				Id = Guid.NewGuid(),
				Name = "b"
			});
			activities.Add(new Activity
			{
				Id = Guid.NewGuid(),
				Name = "c"
			});
			activities.Add(new Activity
			{
				Id = Guid.NewGuid(),
				Name = "d"
			});
			activities.Add(new Activity
			{
				Id = Guid.NewGuid(),
				Name = "e"
			});

			foreach (var employee in employees)
			{
				foreach (var activity in activities)
					if (string.Compare(employee.Name, activity.Name) > 0)
					{
						salaries.Add(new Salary
						{
							Id = Guid.NewGuid(),
							Name = employee.Name + " " + activity.Name,
							Rate = (decimal)new Random().NextDouble() * 100,
							WorkTime = (decimal)new Random().NextDouble() * 8,
							EmployeeId = employee.Id,
							ActivityId = activity.Id
						});
					}
			}

			var employeeSums = new Dictionary<Guid, decimal>();
			var activitySums = new Dictionary<Guid, decimal>();
			foreach (var salary in salaries)
			{
				var employee = employees.Find(__employee => __employee.Id == salary.EmployeeId);
				if (employee != null)
				{
					employeeSums[employee.Id] += salary.WorkTime * salary.Rate;
				}

				var activity = activities.Find(__activity => __activity.Id == salary.ActivityId);
				if (activity != null)
				{
					activitySums[activity.Id] += salary.Rate;
				}
			}

			foreach (var employee in employees)
			{
				Console.WriteLine("Employee {1} salary: {0}", employeeSums[employee.Id], employee.Name);
			}

			foreach (var activity in activities)
			{
				Console.WriteLine("Activity {1} k rate: {0}", activitySums[activity.Id] / activitySums.Count, activity.Name);
			}

			Console.ReadKey();
		}
	}
}
