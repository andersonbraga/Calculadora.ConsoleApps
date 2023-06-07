namespace Calculadora.ConsoleApps
{
    public class Program
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
                Console.WriteLine("Digite 1 para Adição ");
                Console.WriteLine("Digite 5 para Visualizar as operações\n");

                Console.Write("Opção: ");
                opcao = Console.ReadLine();


                
                string operacao = "";
               switch (opcao)
                {
                    case "1" : operacao = "Adição";
                        break;
                    case "5":
                        {
                            Console.WriteLine("Visualizando operações realizadas: \n");

                            foreach (string op in operacoes)
                            {
                                Console.WriteLine(op);
                            }

                            Console.ReadLine();
                        };
                        continue;
                    default:
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
                Console.Write($"O resultado da operação de {operacao} é: {resultado}");
                string simbolo = "";
                switch (opcao)
                {
                    case "1":simbolo = "+";
                        break;
                        default:break;
                }
                string descricaoOperacao = $"{primeiroNumero} {simbolo} {segundoNumero} = {resultado}";
                operacoes.Add(descricaoOperacao);
            }


        }
    }
}