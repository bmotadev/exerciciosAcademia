using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;
using System;

namespace ExercicioPoo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•Crie uma classe chamada Computador que possua 4 atributos: marca, modelo, tipo(notebook, netbook, tablet, etc) e preço.

            //Crie dois objetos onde o primeiro objeto deverá ser criado através da solicitação dos valores ao usuário por linha de execução.Já, os valores do segundo objeto, deverão ser definidos no código - fonte da classe que o criou.Exiba na tela os resultados.

            Computador computador = new Computador();
            Computador computador2 = new Computador();

            Console.WriteLine("Informe a marca:");
            computador.marca = Console.ReadLine();

            Console.WriteLine("Informe o modelo: ");
            computador.modelo = Console.ReadLine();

            Console.WriteLine("Informe o tipo: ");
            computador.tipo = Console.ReadLine();

            Console.WriteLine("Informe o valor: ");
            computador.preco = double.Parse(Console.ReadLine());

            computador2.marca = "Positivo";
            computador2.modelo = "G320";
            computador2.tipo = "Notebook";
            computador2.preco = 2800;

            Console.WriteLine("Computador 1");
            computador.exibeDados();

            Console.WriteLine("Computador 2");
            computador2.exibeDados();
        }
    }
}