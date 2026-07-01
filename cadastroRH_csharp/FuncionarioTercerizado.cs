using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroRH_csharp
{
    
        public class FuncionarioTercerizado : Funcionario
        {
            public FuncionarioTercerizado(
                string Nome,
                string CPF,
                string Tipo,
                double HorasTrabalhadas,
                double ValorHora

                ):base(Nome,CPF,Tipo)
            {

                
                this.HorasTrabalhadas = HorasTrabalhadas;
                this.ValorHora = ValorHora;
            }

            
            public double HorasTrabalhadas { get; set; }
            public double ValorHora { get; set; }

            public override double CalcularSalario()
            {
                double salario = HorasTrabalhadas * ValorHora;
                return salario;
            }
            public override void ExibirDados()
            {
                Console.WriteLine($"Nome: {Nome}");
                Console.WriteLine($"CPF: {CPF}");
                Console.WriteLine($"Tipo: {Tipo}");
                Console.WriteLine($"Salario: {CalcularSalario()}");
            }
        }
    }

