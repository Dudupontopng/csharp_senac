using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace cadastroRH_csharp
{
  
        public class Funcionario
        {
            public Funcionario(
                string Nome,
                string CPF,
                string Tipo

                )
            {
                this.Nome = Nome;
                this.CPF = CPF;
                this.Tipo = Tipo;
            }

            public string Nome { get; private set; }
            public string CPF { get; private set; }
            public string Tipo { get; private set; }

        
        public virtual double CalcularSalario()
        {
            double salario = 0;
            return salario;
        }
        public virtual void ExibirDados()
        {
            Console.WriteLine("Dados genericos...");
        }
    }
}
