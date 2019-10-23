using Biblioteca.Exports;
using Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Biblioteca.Converters
{
	public class ConvertClass
	{
		public static void convertPersonToString(List<Cliente> c)
		{
			string str = "";
			if (c.Count > 0)
			{
				for (int i = 0; i < c.Count; i++)
				{
					str += $"{c[i].nome},";
					str += $"{c[i].dataDeNascimento.ToString()},";
					str += $"{c[i].telefone },";
					str += $"{c[i].cpf},";
					str += $"{c[i].rg },";
					str += $"{c[i].cep},";
					str += $"{c[i].estado},";
					str += $"{c[i].cidade},";
					str += $"{c[i].endereco}";
					str += "\r\n";
				}
			}
			GerenciadorArquivo.SaveFileNote("clientes", str);
		}


		public static void convertPersonToString(List<Funcionario> f)
		{
			string str = "";

			if (f.Count > 0)
			{

				for (int i = 0; i < f.Count; i++)
				{
					str += $"{f[i].nome},";
					str += $"{f[i].dataDeNascimento.ToString()},";
					str += $"{f[i].telefone },";
					str += $"{f[i].cpf},";
					str += $"{f[i].rg },";
					str += $"{f[i].cep},";
					str += $"{f[i].estado},";
					str += $"{f[i].cidade},";
					str += $"{f[i].endereco},";
					str += $"{f[i].dataContratacao.ToString()},";
					str += $"{f[i].cargo},";
					str += $"{f[i].salario}";
					str += "\r\n";

				}
			}
			GerenciadorArquivo.SaveFileNote("funcionarios", str);
		}


		public static Cliente[] convertStringToClient()
		{
			
			string[] linhas = GerenciadorArquivo.GetStrings("clientes.txt");
			int numeroClientes = linhas.Length;

			Cliente[] clientes = new Cliente[numeroClientes];

			if (linhas.Length > 0)
			{
				for (int i = 0; i < numeroClientes; i++)
				{
					string[] linha = linhas[i].Split(',');
					Cliente c = new Cliente();
					c.nome = linha[0];
					c.dataDeNascimento = DateTime.Parse(linha[1]);
					c.telefone = linha[2];
					c.cpf = linha[3];
					c.rg = linha[4];
					c.cep = linha[5];
					c.estado = linha[6];
					c.cidade = linha[7];
					c.endereco = linha[8];
					clientes[i] = c;
				}
			}


			return clientes;

		}

		public static Funcionario[] ConvertStringToFuncionario()
		{
			Funcionario[] funcionarios;

			string[] linhas = GerenciadorArquivo.GetStrings("funcionarios.txt");
			int numeroLinhas = linhas.Length;
			funcionarios = new Funcionario[numeroLinhas];

			for (int i = 0; i < numeroLinhas; i++)
			{
				string[] linha = linhas[i].Split(',');
				Funcionario f = new Funcionario();
				f.nome = linha[0];
				f.dataDeNascimento = DateTime.Parse(linha[1]);
				f.telefone = linha[2];
				f.cpf = linha[3];
				f.rg = linha[4];
				f.cep = linha[5];
				f.estado = linha[6];
				f.cidade = linha[7];
				f.endereco = linha[8];
				f.dataContratacao = DateTime.Parse(linha[9]);
				f.cargo = linha[10];
				f.salario = Convert.ToDouble(linha[11]);	
				funcionarios[i] = f;

			}

			return funcionarios;


		}
	}
}
