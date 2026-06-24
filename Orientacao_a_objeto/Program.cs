namespace Orientacao_a_objeto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //pessoa 1
            Pessoa Pessoa1 = new Pessoa(
                "Eduardo", 
                new DateTime(2009, 10, 13), 
                1.81, 
                "044.915.150-69", 
                true);

           

            Console.WriteLine("Informações da pessoa");
            Console.WriteLine($"Nome {Pessoa1.Nome}");
            Console.WriteLine($"Data de nascimento {Pessoa1.Data_nascimento}");
            Console.WriteLine($"Altura {Pessoa1.Altura}");
            Console.WriteLine($"Telefone {Pessoa1.Telefone}");
            Console.WriteLine($"Cpf {Pessoa1.Cpf}");
            Console.WriteLine($"Esta ativo {Pessoa1.Is_ativo}");

          
            Console.WriteLine($"Novo nome pessoa 1: {Pessoa1.Nome}");
            Console.WriteLine("");





            //pessoa 2



            Pessoa pessoa2 = new Pessoa("Douglas", new DateTime(2000, 10, 13), 1.71, "044.915.159-79", true);

            

            Console.WriteLine("Informações da pessoa");
            Console.WriteLine($"Nome {pessoa2.Nome}");
            Console.WriteLine($"Data de nascimento {pessoa2.Data_nascimento}");
            Console.WriteLine($"Altura {pessoa2.Altura}");
            Console.WriteLine($"Telefone {pessoa2.Telefone}");
            Console.WriteLine($"Cpf {pessoa2.Cpf}");
            Console.WriteLine($"Esta ativo {pessoa2.Is_ativo}");
            Console.WriteLine("");



            Cachorro cachorro = new Cachorro("Luke", "Border Collie", new DateTime(2025, 12, 09));
            Console.WriteLine($"Nome : {cachorro.Nome}");
            cachorro.SeComunicar();


            Pedido pedido1 = new Pedido(Pessoa1, new DateTime(2025, 06, 15));

            Console.WriteLine($"Cliente pedido 1: {pedido1.Cliente.Nome}");

            var pedido2 = new Pedido(pessoa2, DateTime.Now, 199.90, "Sem observação");



        }
    }
}