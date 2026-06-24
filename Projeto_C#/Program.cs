using System.Security.Cryptography.X509Certificates;

namespace Projeto_C_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Meu nome é Eduardo");

            int idade = 16;
            string nome = "Eduardo";
            string sobrenome = "Finger";
            bool ehProfessor = false;
            double altura = 1.81;


            //Console.WriteLine($"Meu nome é {nome} {sobrenome}");
            //Console.WriteLine($"Tenho {idade} anos");
            //Console.WriteLine($"Sou professor: {ehProfessor}");
            //Console.WriteLine($"Tenho {altura} de altura");
            string nomeCompleto = ObterNomeCompleto(nome, sobrenome);
            Console.WriteLine(nomeCompleto);

            ExibirSeEhProfessorEAltura(ehProfessor, altura);
        }
        static string ObterNomeCompleto(string nome, string sobrenome)
        {
            return $"{nome} {sobrenome}";
        }

        static void ExibirSeEhProfessorEAltura(bool ehProfessor, double altura)
        {
            Console.WriteLine($"Sou professor: {ehProfessor}");
            Console.WriteLine($"Tenho {altura} de altura");
        }
    }
}
