using _01_Projeto_Udemy.Telas;
using Biblioteca.Converters;
using Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _01_Projeto_Udemy
{
	class Program
	{
		static void Main(string[] args)
		{


			string opcoes = "";
			ManterCliente manterCliente = new ManterCliente();
			ManterFuncionario manterFuncionario = new ManterFuncionario();
			while (opcoes != "5")
			{
				Clear();
				WriteLine("O que deseja fazer? \n1 - Cadastrar cliente \n2 - Listar cliente \n3 - Cadastrar funcionário \n4 - Listar funcionário \n5 - Sair do programa.");
				opcoes = ReadLine();
				switch (opcoes)
				{
					case "1":
						manterCliente.Cadastrar();
						break;
					case "2":
						manterCliente.Listar();
						break;
					case "3":
						manterFuncionario.Cadastrar();
						break;
					case "4":
						manterFuncionario.Listar();
						break;
					case "5":
						WriteLine("Você saiu do programa.");
						manterCliente.EnviarLista();
						manterFuncionario.EnviarLista();
						break;
					default:
						WriteLine("Comando inválido");
						break;
				}

			}

			ReadKey(true);


		}
	}
}
