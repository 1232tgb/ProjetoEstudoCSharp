using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Biblioteca.Model
{
	public sealed class Funcionario : Pessoa
	{
		public string cargo { get; set; }
		public double salario { get; set; }
		public DateTime dataContratacao { get; set; }

		public override void ExibeInformacao()
		{
			WriteLine("Nome:" + nome);
			WriteLine("Data de nascimento:" + dataDeNascimento);
			WriteLine("Telefone:" + telefone);
			WriteLine("CPF:" + cpf);
			WriteLine("RG:" + rg);
			WriteLine("CEP:" + cep);
			WriteLine("Estado:" + estado);
			WriteLine("Cidade:" + cidade);
			WriteLine("Endereço:" + endereco);
			WriteLine("Cargo:" + cargo);
			WriteLine("Salario" + salario);
			WriteLine("Data de contratação:" + dataContratacao);
		}

		public override void RegistraInformacao()
		{
			bool isDate = false;
			int tentativas = 0;

			Write("Entre com o nome: ");
			nome = ReadLine();
			while (!isDate)
			{
				if (tentativas > 0)
				{
					Write("Valor inválido. Entre com a data de nascimento novamente: ");
				}
				else
				{
					Write("Entre com a data de nascimento:");
				}

				DateTime d;
				isDate = DateTime.TryParse(ReadLine(), out d);
				dataDeNascimento = d;
				tentativas++;
			}
			Write("Entre com o telefone:");
			telefone = ReadLine();
			Write("Entre com o CPF:");
			cpf = ReadLine();
			Write("Entre com o RG:");
			rg = ReadLine();
			Write("Entre com o CEP:");
			cep = ReadLine();
			Write("Entre com o estado:");
			estado = ReadLine();
			Write("Entre com a cidade:");
			cidade = ReadLine();
			Write("Entre com o endereço:");
			endereco = ReadLine();
			isDate = false;
			tentativas = 0;
			while (!isDate)
			{
				if (tentativas > 0)
				{
					Write("Valor inválido. Entre com a data de contratação novamente: ");
				}
				else
				{
					Write("Entre com a data de contratação:");
				}

				DateTime d;
				isDate = DateTime.TryParse(ReadLine(), out d);
				dataContratacao = d;
				tentativas++;
			}
			Write("Cargo:");
			cargo = ReadLine();
			Write("Salario:");
			salario = Convert.ToDouble(ReadLine());


		}
	}
}
