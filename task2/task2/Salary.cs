using System;

namespace task2
{
	public sealed class Salary : IIdName
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public decimal WorkTime { get; set; }

		public decimal Rate { get; set; }

		public Guid EmployeeId { get; set; }

		public Guid ActivityId { get; set; }
	}
}