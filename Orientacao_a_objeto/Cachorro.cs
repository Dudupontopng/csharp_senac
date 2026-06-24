using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_a_objeto
{
    public class Cachorro
    {

        public Cachorro(
            string Nome,
            string Raca,
            DateTime DataDeNascimento
            ) {
            this.Nome = Nome;
            this.Raca = Raca;
            this.DataDeNascimento = DataDeNascimento;
        }
        public string Nome { get; private set; }

        public string Raca { get; private set; }

        public double Altura { get; set; }

        public double Peso { get; set; }

        public DateTime DataDeNascimento { get; private set; }

        public bool Adestrado { get; set; }

        public bool IsVacinado { get; set; }

        public bool IsAtivo { get; set; }

        public void SeComunicar()
        {
            Console.WriteLine($"Au au");
        }

        public void Caminhar()
        {
            Console.WriteLine("Cachorro caminhando...");
        }

        public void FazerTruque(string truque)
        {
            Console.WriteLine($"Truque: {truque}");
        }
    }
}
