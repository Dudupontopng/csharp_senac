using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_alunoscsharp
{
    public class Aluno
    {
        public Aluno
            (
            string nome,
            DateTime dataDeNascimento,
            string CPF
            )
        {
            this.nome = nome;
            this.CPF = CPF;
            this.dataDeNascimento = dataDeNascimento;
            this.matricula = Guid.NewGuid();
            

        }

        public string nome { get; private set; }
        public string CPF { get; private set; }
        public DateTime dataDeNascimento { get; private set; }

        public Guid matricula { get; private set; }

       public int CalcularIdade()
        {
            DateTime hoje = DateTime.Today;
            int idade = hoje.Year - dataDeNascimento.Year;
            return idade;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome do aluno: {nome}");
            Console.WriteLine($"CPF do aluno: {CPF}");
            Console.WriteLine($"Idade do aluno: {CalcularIdade()}");
            Console.WriteLine("");
        }

    }
}
