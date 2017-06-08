using System;
using System.Threading;

namespace Tutorial1
{
	class Program
	{
		/// <summary>
		/// Переделать код так, чтобы потоки выполнялись один за другим и на момент вывода на экран состояние было "Finished"
		/// Как можно улучшить этот код? Какие проблемы вы заметили? Улучшайте!
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			Worker worker = new Worker();

			while (true)
			{
				Console.ReadLine();
				Thread worker1 = new Thread(worker.Start);
				Thread worker2 = new Thread(worker.Finish);

				worker1.Start();
				worker2.Start();

				Console.WriteLine(worker.Condition);
			}
		}

		public class Worker
		{
			public string Condition = "none";

			public void Start()
			{
				Condition = "Just started";
			}

			public void Finish()
			{
				Condition = "Finished";
			}
		}
	}
}