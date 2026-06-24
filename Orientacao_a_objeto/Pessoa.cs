using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_a_objeto
{
    public class Pessoa
    {
        public Pessoa(
            string Nome, 
            DateTime Data_nascimento, 
            double Altura, 
            string Cpf, 
            bool is_Ativo)
        {
            this.Nome = Nome;
            this.Data_nascimento = Data_nascimento;
            this.Cpf = Cpf;
            this.Altura = Altura;
            this.Is_ativo = is_Ativo;

        }
        public string Nome{ get; private set; }

        public DateTime Data_nascimento { get; private set; }

        public double Altura { get; set; }

        public string Cpf { get; private set; }

        public string Rg { get; private set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public bool Is_ativo { get; set; }

        public void SeComunicar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}");
        }

        public void Caminhar()
        {
            Console.WriteLine("Pessoa caminhando...");
        }


    }
}
