namespace myFluent
{
	class Program
	{
		//to-do: реализовать настройку конфига всеми известными методами
		static void Main(string[] args)
		{
			var config = new Config
			{
				Foo = "foo",
				SubConfig = new SubConfig
				{
					Foo = "sub-foo",
					Bar = "sub-bar",
				}
			};

			var foo = new Foo(config);
		}
	}
}
