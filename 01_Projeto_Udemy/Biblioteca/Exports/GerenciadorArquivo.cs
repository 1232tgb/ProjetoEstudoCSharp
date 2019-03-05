using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Exports
{
	public class GerenciadorArquivo
	{
		public static void SaveFile(string nome, string dados)
		{
			//string path = nome + ".txt";
			string path = @"../../../Biblioteca/Docs/" + nome + ".txt";


			using (StreamWriter str = new StreamWriter(path, false))
			{
				str.Write(dados);
			}

		}

		public static bool IsThereFile(string nome)
		{
			string path = @"../../../Biblioteca/Docs/" + nome;
			return File.Exists(path);
		}


		public static string[] GetStrings(string nome)
		{
			string path = @"../../../Biblioteca/Docs/" + nome;
			return File.ReadAllLines(path);
		}
	}
}
