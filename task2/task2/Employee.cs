using System;

namespace task2
{
	public sealed class Employee : IIdName
	{
		public Guid Id { get; set; }

		public string Name { get; set; }
	}
}