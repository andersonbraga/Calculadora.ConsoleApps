namespace Calculadora.ConsoleApps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao;

            List<String> operacoes = new List<string>();

            while (true)
            {


                Console.Clear();

                Console.WriteLine("Calculadora Tabajara 1.0\n");

                Console.WriteLine("Tela Principal\n");


                Console.Write("Opção: ");
                opcao = Console.ReadLine();


                Console.WriteLine("Digite 1 para Adicionar ");
                string operacao = "";
               switch (opcao)
                {
                    case "1" : operacao = "Adição";
                        break;
                }
                Console.WriteLine("Digite o primeiro número");
                double primeiroNumero = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número");
                double segundoNumero = double.Parse(Console.ReadLine());

                double resultado = 0;
                switch (opcao)
                {
                    case "1": resultado = primeiroNumero + segundoNumero;
                        break;
                    default:break;
                }
                Console.WriteLine(resultado);
                string simbolo = "";
                switch (opcao)
                {
                    case "1":simbolo = "+";
                        break;
                        default:break;
                }
                operacoes.Add(simbolo);
            }


        }
    }
}