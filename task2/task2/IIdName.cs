using System;

namespace task2
{
	public interface IIdName
	{
		Guid Id { get; set; }

		string Name { get; set; }
	}
}