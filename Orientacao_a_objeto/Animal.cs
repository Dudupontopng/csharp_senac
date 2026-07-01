using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_a_objeto
{
    public class Animal
    {

  
        public string Nome { get; set; }

        public double Altura { get; set; }

        public double Peso { get; set; }

        public DateTime DataDeNascimento { get; private set; }

        public bool IsAtivo { get; set; }

        public virtual void SeComunicar()
        {
            Console.WriteLine($"Fala generica...");
        }

    }
}
