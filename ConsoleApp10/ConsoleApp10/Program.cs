using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int triesCount = 5;
			string password = "passwordExample";
			string passwordUserInput;

			for (int i = 0; i < triesCount; i++)
			{
				Console.WriteLine("Введите пароль:");
				passwordUserInput = Console.ReadLine();

				if (passwordUserInput == password)
				{
					Console.WriteLine("Верный пароль! *вход в систему выполнен*");
					Console.ReadLine();
					break;
				}
				else
				{
					Console.WriteLine("Вы ввели неправильный пароль! *вход в систему не выполнен*");
					Console.WriteLine($"У вас осталось попыток: {triesCount - i - 1}");
				}
				Console.ReadLine();
			}
		}
	}
}
