using Biblioteca.Converters;
using Biblioteca.Exports;
using Biblioteca.Model;
using System.Collections.Generic;
using static System.Console;

namespace _01_Projeto_Udemy.Telas
{
	public class ManterCliente : IPerson
	{
		private List<Cliente> listaClientes;
		public ManterCliente()
		{
			listaClientes = new List<Cliente>();
			RetrievePersonFromFile();
		}

		public void Cadastrar()
		{
			Clear();
			WriteLine("-------------REGISTRA INFORMAÇÃO:---------------");
			Cliente c = new Cliente();
			c.RegistraInformacao();
			AddClientes(c);
		}


		public void AddClientes(Cliente c)
		{
			listaClientes.Add(c);
		}


		public void Listar()
		{
			Clear();
			WriteLine("-------------LISTAGEM DE CLIENTES:---------------");
			int indice = 0;
			foreach (Cliente c in listaClientes)
			{
				WriteLine("Cliente numero " + ++indice + ":");
				c.ExibeInformacao();
			}
			ReadKey(false);
		}

		public void EnviarLista()
		{
			ConvertClass.convertPersonToString(listaClientes);
		}


		public void RetrievePersonFromFile()
		{
			if (GerenciadorArquivo.IsThereFile("clientes.txt"))
			{
				Cliente[] clientes = ConvertClass.convertStringToClient();

				if (clientes.Length > 0)
				{
					for (int i = 0; i < clientes.Length; i++)
					{
						AddClientes(clientes[i]);
					}
				}
			}

		}
	}
}
