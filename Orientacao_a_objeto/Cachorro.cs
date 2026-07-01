using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_a_objeto
{
    public class Cachorro : Animal
    {

        public Cachorro(
            string Nome,
            string Raca,
            DateTime DataDeNascimento,
            bool Adestrado,
            bool IsVacinado
            ) {
            Nome = Nome;
            Raca = Raca;
            DataDeNascimento = DataDeNascimento;
            Adestrado = Adestrado;
            IsVacinado = IsVacinado;
        }
      

        public string Raca { get; private set; }

       

     

        

        public bool Adestrado { get; set; }

        public bool IsVacinado { get; set; }

       

        public override void SeComunicar()
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
