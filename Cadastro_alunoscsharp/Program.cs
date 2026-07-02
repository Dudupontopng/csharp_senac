namespace Cadastro_alunoscsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CadastroAlunos gerenciador = new CadastroAlunos();
            bool rodando = true;
            while (rodando)
            {
                try
                {
                    Console.WriteLine("---------Cadastro de alunos---------");
                    Console.WriteLine("");
                    Console.WriteLine("(1) - Adicionar novo aluno");
                    Console.WriteLine("(2) - Remover um aluno existente");
                    Console.WriteLine("(3) - Listar todos os alunos existentes");
                    Console.WriteLine("(4) - Encerrar programa");
                    string opcao = Console.ReadLine();
                    if(opcao == "1")
                    {
                        Console.WriteLine("Nome do aluno: ");
                        string nomeAluno = Console.ReadLine();
                        Console.WriteLine("CPF do aluno: ");
                        string cpfAluno = Console.ReadLine();
                        Console.WriteLine("Data de nascimento do aluno (DD/MM/AAAA) : ");
                        DateTime DataNascimento = DateTime.Parse(Console.ReadLine());
                        
                        Aluno novoAluno = new Aluno(nomeAluno, DataNascimento, cpfAluno);
                        gerenciador.adicionarAluno(novoAluno);
                    }
                    if(opcao == "2")
                    {
                        gerenciador.RemoverAluno();
                    }
                    if(opcao == "3")
                    {
                        Console.WriteLine("Como deseja filtrar a lista?");
                        Console.WriteLine("");
                        Console.WriteLine("(1) - Por nome (A-Z)");
                        Console.WriteLine("(2) - Por idade (Menor-Maior)");
                        Console.WriteLine("(3) - Sem filtro");
                        Console.WriteLine("(4) - Primeira letra");
                        Console.WriteLine("(5) - Por CPF");
                        string escolhaOrdem = Console.ReadLine();
                        if(escolhaOrdem != "3" && escolhaOrdem != "4" && escolhaOrdem != "5") {
                            gerenciador.listarAlunosOrdenado(escolhaOrdem);
                        }
                        else if(escolhaOrdem =="3")
                        {
                            gerenciador.listarAlunos();
                        }
                        else if(escolhaOrdem == "4")
                        {
                            Console.WriteLine("Digite a letra: ");
                            string letra = Console.ReadLine();
                            gerenciador.ListarAlunosPrimeiraLetra(letra);
                        }
                        else if(escolhaOrdem == "5")
                        {
                            Console.WriteLine("Digite o CPF do aluno: ");
                            string CPFDigitado = Console.ReadLine();
                            gerenciador.ListarPorCPF(CPFDigitado);
                        }
                        

                    }
                    if(opcao == "4")
                    {
                        Console.WriteLine("Saindo do sistema!");
                        rodando = false;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Digite um valor valido");
                }
            }
        }
    }
}
