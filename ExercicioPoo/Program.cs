using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace ExercicioPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•1 - Crie uma classe chamada Carro que possua 3 atributos: marca, modelo e anoFabricacao.Além disso, na main crie 2 objetos do tipo Carro e exiba na tela os valores dos atributos criados.

            //•Esses valores devem ser solicitados ao usuário, por linha de execução.

            Carro carro = new Carro();
            Carro carro2 = new Carro();

            Console.WriteLine("Informe a marca");
            carro.marca = Console.ReadLine();

            Console.WriteLine("Informe o modelo:");
            carro.modelo = Console.ReadLine();

            Console.WriteLine("Informe o ano de fabricação:");
            carro.anoFabricacao = Console.ReadLine();


            Console.WriteLine("Informe a marca");
            carro2.marca = Console.ReadLine();

            Console.WriteLine("Informe o modelo:");
            carro2.modelo = Console.ReadLine();

            Console.WriteLine("Informe o ano de fabricação:");
            carro2.anoFabricacao = Console.ReadLine();


            Console.WriteLine("Carro 1");
            carro.exibeDados();

            Console.WriteLine("Carro 2");
            carro2.exibeDados();

        }
    }
}