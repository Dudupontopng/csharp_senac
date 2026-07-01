using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroRH_csharp
{
    public class GerenciadorRH
    {
        public List<Funcionario> listafuncionario = new List<Funcionario>();
        public void AdicionarFuncionario(Funcionario f)
        {
            listafuncionario.Add(f);
            Console.WriteLine("Funcionario adicionado com sucesso");
        }
        public void ListarFuncionarios()
        {
            if(listafuncionario.Count == 0)
            {
                Console.WriteLine("Não há nenhum funcionario para listar");
                return;
            }
            else
            {
                foreach(var f in listafuncionario)
                {
                    f.ExibirDados();

                }
            }
        }
    }
}
