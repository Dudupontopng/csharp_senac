using System.Security.Cryptography.X509Certificates;

namespace exercicio_parimpar_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try { 
            Console.WriteLine("Digite um numero inteiro: ");
            string numero1text = Console.ReadLine();
            int numero = int.Parse(numero1text);


            
            

                if (numero % 2 == 0)
                {
                    Console.WriteLine($"{numero} é par");
                }
                else
                {
                    Console.WriteLine($"{numero} é impar");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Digite um numero valido");
            }
            
        }
    }
}
