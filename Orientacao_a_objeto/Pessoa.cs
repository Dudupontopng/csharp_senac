using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_a_objeto
{
    public class Pessoa : Animal
    {
        public Pessoa(
            string Nome, 
            DateTime DataDeNascimento,
            double Altura, 
            string Cpf, 
            bool IsAtivo)
        {
            this.Nome = Nome;
            DataDeNascimento = DataDeNascimento;
            this.Cpf = Cpf;
            this.Altura = Altura;
            this.IsAtivo = IsAtivo;

        }

        public string Cpf { get; private set; }

        public string Rg { get; private set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

       

        public override void SeComunicar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}");
        }

        public void Caminhar()
        {
            Console.WriteLine("Pessoa caminhando...");
        }


    }
}
