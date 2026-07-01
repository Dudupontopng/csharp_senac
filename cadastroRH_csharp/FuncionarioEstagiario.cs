using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cadastroRH_csharp
{
    
        public class FuncionarioEstagiario : Funcionario
        {
            public FuncionarioEstagiario(
               string Nome,
                string CPF,
                string Tipo,
               double BolsaAuxilio,
               double ValeTransporte
               ):base(Nome,CPF,Tipo)
            {
                this.BolsaAuxilio = BolsaAuxilio;
                this.ValeTransporte = ValeTransporte;
                
            }

            
            
            public double BolsaAuxilio { get; set; }

            public double ValeTransporte { get; set; }

            public override double CalcularSalario()
            {
                double salario = BolsaAuxilio + ValeTransporte;
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

