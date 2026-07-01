using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroRH_csharp
{
    internal class program
    {
        static void Main(string[] args)
        {
            GerenciadorRH rh = new GerenciadorRH();
            bool rodando = true;
            while (rodando)
            {
                Console.WriteLine("Escolha: ");
                Console.WriteLine("1 - Adicionar Funcionario");
                Console.WriteLine("2 - Listar Funcionarios");
                Console.WriteLine("3 - Sair");
                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    try
                    {
                        Console.WriteLine("Escolha o tipo: ");
                        Console.WriteLine("1 - CLT");
                        Console.WriteLine("2 - Estagiario");
                        Console.WriteLine("3 - Tercerizado");
                        string opcao2 = Console.ReadLine();

                        if(opcao2 != "1" && opcao2 != "2" && opcao2 != "3")
                        {
                            throw new ArgumentException("Esse tipo de funcionario nao existe!");
                        }

                        Console.WriteLine("Nome: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("CPF: ");
                        string cpf = Console.ReadLine();
                        if (opcao2 == "1")
                        {
                            Console.WriteLine("Salario base: ");
                            double salario = double.Parse(Console.ReadLine());
                            FuncionarioClt novoClt = new FuncionarioClt(nome, cpf, "CLT", salario);
                            rh.AdicionarFuncionario(novoClt);
                        }
                        else if (opcao2 == "2")
                        {
                            Console.WriteLine("Bolsa Auxilio: ");
                            double bolsa = double.Parse(Console.ReadLine());
                            Console.WriteLine("Vale Transporte: ");
                            double vale = double.Parse(Console.ReadLine());
                            FuncionarioEstagiario novoEstagiario = new FuncionarioEstagiario(nome, cpf, "Estagiario", bolsa, vale);
                            rh.AdicionarFuncionario(novoEstagiario);
                        }

                        else if (opcao2 == "3") {
                            Console.WriteLine("Horas Trabalhadas: ");
                            double horas = double.Parse(Console.ReadLine());
                            Console.WriteLine("Valor da hora: ");
                            double valorHora = double.Parse(Console.ReadLine());
                            FuncionarioTercerizado novoTercerizado = new FuncionarioTercerizado(nome, cpf, "Tercerizado", horas, valorHora);
                            rh.AdicionarFuncionario(novoTercerizado);

                        }
                        Console.Write("Funcionario adicionado com sucesso!");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Digite um valor valido!");
                    }
                    catch(ArgumentException ex)
                    {
                        Console.WriteLine($"Erro de validação: {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Occoreu um erro inesperado: {ex.Message}");
                    }
                }



                else if (opcao == "2")
                {
                    Console.WriteLine("------Listando Funcionarios-------");
                    rh.ListarFuncionarios();

                }
                else if (opcao == "3")
                {
                    rodando = false;
                    Console.Write("Saindo do sistema...");
                }
                else
                {
                    Console.WriteLine("Erro, voltando ao inicio");
                }
            }
            {

            }
            
        }
    }
}
