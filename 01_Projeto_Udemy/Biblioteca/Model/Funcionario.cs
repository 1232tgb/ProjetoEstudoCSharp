using Biblioteca.DataEnter;
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
			nome = DataInput.ReturnString("Entre com o nome");
			dataDeNascimento = DataInput.ReturnDate("Entre com a data de nascimento");
			telefone = DataInput.ReturnString("Entre com o telefone");
			cpf = DataInput.ReturnString("Entre com o CPF");
			rg = DataInput.ReturnString("Entre com o RG");
			cep = DataInput.ReturnString("Entre com o CEP");
			estado = DataInput.ReturnString("Entre com o estado");
			cidade = DataInput.ReturnString("Entre com a cidade");
			endereco = DataInput.ReturnString("Entre com o endereço");
			dataContratacao = DataInput.ReturnDate("Entre com a data de contratação");
			cargo = DataInput.ReturnString("Entre com o cargo");
			salario = DataInput.ReturnInt("Entre com o salario");


		}
	}
}
