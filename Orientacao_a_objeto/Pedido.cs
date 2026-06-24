using Orientacao_a_objeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientacao_a_objeto
{
    public class Pedido
    {
        public Pedido(
            Pessoa Cliente,
            DateTime DataDoServico
           

            )
        {
            this.Cliente = Cliente;
            this.DataDoServico = DataDoServico;
            
        }
        public Pedido
            (
            Pessoa Cliente,
            DateTime DataDoServico,
            double ValorTotal,
            string observacao
            ) 
        
        {
            this.Cliente = Cliente;
            this.DataDoServico = DataDoServico;
            this.ValorTotal = ValorTotal;
            this.Observacao = observacao;

        }
        public Pessoa Cliente { get; private set; }
            
        public IList<string> Produto { get;private set; }

        public double ValorTotal { get; set; }

        public DateTime DataDoServico { get; set; }

        public bool IsPago { get; private set; }

        public string Observacao { get; set; }
    }
}
