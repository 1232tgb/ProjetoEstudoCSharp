using Biblioteca.Converters;
using Biblioteca.Exports;
using Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _01_Projeto_Udemy.Telas
{
	public class ManterFuncionario : IPerson
	{
		private List<Funcionario> listaFuncionario;
		public ManterFuncionario()
		{
			listaFuncionario = new List<Funcionario>();
			RetrievePersonFromFile();
		}

		public void Cadastrar()
		{
			Clear();
			WriteLine("-------------REGISTRA INFORMAÇÃO:---------------");
			Funcionario f = new Funcionario();
			f.RegistraInformacao();
			AddFuncionarios(f);
		}

		public void Listar()
		{
			Clear();
			WriteLine("-------------LISTAGEM DE FUNCIONÁRIOS:---------------");
			int indice = 0;
			foreach (Funcionario func in listaFuncionario)
			{
				WriteLine($"Funcnionario numero {++indice}");
				func.ExibeInformacao();
			}
			ReadKey(false);
		}


		void AddFuncionarios(Funcionario f)
		{
			listaFuncionario.Add(f);

		}

		public void EnviarLista()
		{

			ConvertClass.convertPersonToString(listaFuncionario);

		}

		public void RetrievePersonFromFile()
		{
			if (GerenciadorArquivo.IsThereFile("funcionarios.txt"))
			{
				Funcionario[] funcionarios = ConvertClass.ConvertStringToFuncionario();

				if (funcionarios.Length > 0)
				{
					for (int i = 0; i < funcionarios.Length; i++)
					{
						AddFuncionarios(funcionarios[i]);
					}
				}
			}
		}
	}
}
