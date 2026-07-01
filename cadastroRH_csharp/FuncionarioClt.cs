using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroRH_csharp
{
    

        public class FuncionarioClt : Funcionario
        {
            public FuncionarioClt(
                string Nome,
                string CPF,
                string Tipo,
                double SalarioBase
                ):base(Nome, CPF, Tipo)
            {
                
                this.SalarioBase = SalarioBase;


            }

           

            public double SalarioBase { get; set; }

            public override double CalcularSalario()
            {
                return SalarioBase;
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


    
