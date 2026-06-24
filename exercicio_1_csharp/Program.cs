namespace exercicio_1_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <=10; i++)
            {
                decimal raiz = (decimal)Math.Sqrt(i);
                Console.WriteLine($"Numero: {i:F2}");
                Console.WriteLine($"Raiz quadrada: {raiz:F2}");
                Console.WriteLine("");
            }
        }
    }
}
