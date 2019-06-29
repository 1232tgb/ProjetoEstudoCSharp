using System;
using static System.Console;

namespace Biblioteca.DataEnter
{
	public static class DataInput
	{
		public static string ReturnString(string str)
		{
			Write($"{str}:");
			return ReadLine();
		}

		public static int ReturnInt(string str)
		{
			int number;

			while (true)
			{
				Write($"{str}:");
				try
				{
					number = Convert.ToInt32(ReadLine());
					return number;
				}
				catch (FormatException e)
				{
					WriteLine("Dados inválidos: " + e.Message);
				}

			}
		}

		public static DateTime ReturnDate(string str)
		{
			DateTime dt;
			while (true)
			{
				Write($"{str}:");
				try
				{
					dt = DateTime.Parse(ReadLine());
					return dt;
				}
				catch (Exception e)
				{
					Write($"Dados Inválidos:{e.Message}");
				}
			}
		}
	}
}
