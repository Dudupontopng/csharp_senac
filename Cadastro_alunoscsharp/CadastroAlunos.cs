using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_alunoscsharp
{
    public class CadastroAlunos
    {

        public List<Aluno> listaAluno = new List<Aluno>();
        public void adicionarAluno(Aluno novoAluno)
        {
            bool cpfJaExiste = false;
            foreach(var alunoDaLista in listaAluno)
            {
                if(alunoDaLista.CPF == novoAluno.CPF)
                {
                    cpfJaExiste = true;
                    break;
                }
            }
            if (cpfJaExiste) {
                Console.WriteLine("Esse CPF ja existe cadastrado!");
            }
            else
            {
                listaAluno.Add(novoAluno);
                Console.WriteLine("Aluno adicionado com sucesso!");
            }
        }
        public void RemoverAluno()
        {
            Console.WriteLine("Informe o CPF do aluno que voce deseja remover: ");
            string CPFaluno = Console.ReadLine();
            Aluno alunoRemover = listaAluno.FirstOrDefault(a => a.CPF == CPFaluno);
            if(alunoRemover != null)
            {
                listaAluno.Remove(alunoRemover);
                Console.WriteLine("Aluno removido com sucesso");
            }
            else
            {
                Console.WriteLine("Não tem alunos com esse CPF cadastrado");
            }
        }
        public void ListarPorCPF(string CPFDigitado)
        {
            if (listaAluno.Count == 0)
            {
                Console.WriteLine("Não há alunos para serem listados");
                return;
            }
            Aluno AlunoCPF = listaAluno.FirstOrDefault(a => a.CPF == CPFDigitado);

            if(AlunoCPF != null)
            {
                Console.WriteLine("Aluno encontrado");
                Console.WriteLine($"Nome do aluno: {AlunoCPF.nome}");
                Console.WriteLine($"CPF do aluno: {AlunoCPF.CPF}");
                Console.WriteLine($"Idade do aluno: {AlunoCPF.CalcularIdade()}");
                Console.WriteLine($"Matricula do aluno: {AlunoCPF.matricula}");
               
            }

            
        }
        public void ListarAlunosPrimeiraLetra(string letra)
        {
            if(listaAluno.Count == 0)
            {
                Console.WriteLine("Não há alunos para serem listados");
                return;
            }

            var AlunosFiltrados = listaAluno.Where(a => a.nome.ToUpper().StartsWith(letra.ToUpper()));

            if (!AlunosFiltrados.Any())
            {
                Console.WriteLine($"Não há nenhum aluno que começe com a letra {letra}");
                return;
            }
            Console.WriteLine($"Alunos que começam com a letra {letra.ToUpper()}");
            foreach(var a in AlunosFiltrados)
            {
                Console.WriteLine($"Nome: {a.nome} Idade: {a.CalcularIdade()} anos");
                Console.WriteLine("");
            }
            
        }
        public void listarAlunos()
        {
            if (listaAluno.Count == 0)
            {
                Console.WriteLine("Não há nenhum aluno para listar");
            }
            else
            {
                foreach (var a in listaAluno)
                {
                    a.ExibirDados();
                }
            }
        }
        public void listarAlunosOrdenado(string tipoOrdenacao)
        {
            if (listaAluno.Count == 0)
            {
                Console.WriteLine("Não há nenhum aluno para listar");
                return;
            }
            IEnumerable<Aluno> listaOrdenada;
            if (tipoOrdenacao == "1")
            {
                listaOrdenada = listaAluno.OrderBy(a => a.nome);
            }
            else if (tipoOrdenacao == "2")
            {
                listaOrdenada = listaAluno.OrderBy(a => a.CalcularIdade());
            }
            else
            {
                Console.WriteLine("Opcao invalida!");
                return;
            }
            Console.WriteLine("---Lista de alunos---");
            foreach (var a in listaOrdenada)
            {
                Console.WriteLine($"Nome: {a.nome}");
                Console.WriteLine($"Idade: {a.CalcularIdade()} anos");
                Console.WriteLine("");
            }
        }
    }
}
