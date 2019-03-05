using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
	public abstract class Pessoa
	{
		public string nome { get; set; }
		public DateTime dataDeNascimento { get; set; }
		public string telefone { get; set; }
		public string cpf { get; set; }
		public string rg { get; set; }
		public string cep { get; set; }
		public string estado { get; set; }
		public string cidade { get; set; }
		public string endereco { get; set; }

		public abstract void ExibeInformacao();
		public abstract void RegistraInformacao();

	}
}
