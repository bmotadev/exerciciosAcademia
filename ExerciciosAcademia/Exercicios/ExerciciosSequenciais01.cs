using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosAcademia.Exercicios
{
    internal class ExerciciosSequenciais01
    {
        public void Exercicio01 ()
        {
            // 1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.
            Console.WriteLine("Exercicio 01");

            double numero1 = double.Parse(Console.ReadLine());
            double numero2 = double.Parse(Console.ReadLine());

            double media = (numero1 + numero2)/2;

            Console.WriteLine($"A media dos numeros digitados é: {media:f2}");
            Console.WriteLine();
        }

        public void Exercicio02 ()
        {
            // 2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.
            Console.WriteLine("Exercicio 02");

            double numero1 = double.Parse(Console.ReadLine());
            double numero2 = double.Parse (Console.ReadLine());
            double numero3 = double.Parse(Console.ReadLine());
            double numero4 = double.Parse(Console.ReadLine());

            double media = (numero1 + numero2 + numero3 + numero4) / 4;

            Console.WriteLine($"A media dos números digitados é: {media:f2}");
            Console.WriteLine();
        }

        public void Exercicio03 ()
        {
            // 3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre 
            // si os valores de duas variáveis A e B.
            Console.WriteLine("Exercicio 03");

            double variavelA = double.Parse(Console.ReadLine());
            double variavelB = double.Parse(Console.ReadLine());

            Console.WriteLine($"Variavel A: {variavelA}.\n Variavel B: {variavelB}\n");

            double variavelAuxiliar = variavelA;
            variavelA = variavelB;
            variavelB = variavelAuxiliar;

            Console.WriteLine($"O valor da variavel A: {variavelA}.\nValor da variavel B: {variavelB}");
            Console.WriteLine();

        }

        public void Exercicio04 ()
        {
            // 4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
            // forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.
            Console.WriteLine("Exercicio 04");

            Console.WriteLine("Digite o dia:");
            string dia = Console.ReadLine();

            Console.WriteLine("Digite o mês:");
            string mes = Console.ReadLine();

            Console.WriteLine("Digite o ano:");
            string ano = Console.ReadLine();

            Console.WriteLine($"{ano}{mes}{dia}");
        }


        public void Exercicio05 ()
        {
            // 5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
            // (medido em Km/ l), sendo que são conhecidos a distância total percorrida e o volume de combustível
            // consumido para percorrê-la(medido em l).
            Console.WriteLine("Exercicio 05");

            Console.WriteLine("Digite a distância percorrida");
            double distanciaTotalPercorrida = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o combustivel utilizado");
            double combustivelConsumido = double.Parse(Console.ReadLine());

            double mediaDeConsumo = distanciaTotalPercorrida / combustivelConsumido;

            Console.WriteLine($"Sua média de consumo foi: {mediaDeConsumo:f2}");

        }

        public void Exercicio06 ()
        {
            // 6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
            //   isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem
            //    de IPI(única) a ser acrescentada.
            Console.WriteLine("Exercicio 06");

            Console.WriteLine("Digite a quantidade de parafusos A:");
            int quantidadeParafusosA = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do parafuso A:");
            double valorParafusoA = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de parafusos B:");
            int quantidadeParafusosB = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do parafuso B:");
            double valorParafusoB = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a porcentagem de IPI:");
            double porcentagemIpi = double.Parse(Console.ReadLine());
            porcentagemIpi = porcentagemIpi / 100;

            double valorTotal = (valorParafusoA * quantidadeParafusosA) + (valorParafusoB * quantidadeParafusosB);
            valorTotal = valorTotal + (valorTotal * porcentagemIpi);

            Console.WriteLine($"O valor total é de R$ {valorTotal:f2}");


        }

    }
}
