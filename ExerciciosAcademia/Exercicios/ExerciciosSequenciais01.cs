using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
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
            Console.WriteLine();
        }

        public void Exercicio07 () 
        {
            // 7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
            // o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
            // Calcule o salário total do vendedor.Escreva o número do vendedor e o salário total do vendedor.
            Console.WriteLine("Exercicio 07");

            Console.WriteLine("Digite o número do vendedor:");
            int numeroVendedor = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o salário fixo:");
            double salarioFixo = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor total de vendas efetuadas:");
            double totalDeVendas = double.Parse(Console.ReadLine());

            Console.WriteLine("Percentual sobre o total de vendas:");
            double percentualDaVenda = double.Parse(Console.ReadLine());

            double salarioTotal = totalDeVendas * (percentualDaVenda / 100);
            salarioTotal = salarioTotal + salarioFixo;

            Console.WriteLine($"O número do vendedor: {numeroVendedor}. O salario total é de R$ {salarioTotal:f2}");
            Console.WriteLine();
        }
        public void Exercicio08 ()
        {
            // 8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
            // A fórmula da conversão é F = (9 * C + 160) / 5.
            Console.WriteLine("Exercicio 08");

            Console.WriteLine("Digite a temperatura em Celsius:");
            double temperaturaCelsius = double.Parse(Console.ReadLine());

            double temperaturaFahrenheit = ((9 * temperaturaCelsius) + 160) / 5;

            Console.WriteLine($"A temperatura em Fahrenheit é: {temperaturaFahrenheit:f1}");
            Console.WriteLine();

        }

        public void Exercicio09 ()
        {
            // 9) Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior
            // do que ou igual às prestações, que devem ser iguais, inteiras e as maiores possíveis.
            // Por exemplo, se o valor da mercadoria for R$ 270, 00, a entrada e as duas prestações são iguais a R$ 90, 00;
            // se o valor da mercadoria for R$ 302, 75 a entrada é de R$ 102, 75 e as duas prestações são iguais a R$ 100, 00.
            // Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
            // da entrada e das duas prestações, de acordo com as regras acima.
            // Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o
            // conseqüente pagamento dos boletos das duas prestações.
            Console.WriteLine("Exercicio 09 - Loja");

            Console.WriteLine("Informe o valor da mercadoria:");
            double valorDaMercadoria = double.Parse(Console.ReadLine());

            if (valorDaMercadoria == 270)
            {
                Console.WriteLine("O valor da entrada e as duas prestações são iguais a R$ 90,00");
            } else if(valorDaMercadoria == 302.75)
            {
                Console.WriteLine("O valor da entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00");
            }
            Console.WriteLine();
        }


        public void Exercicio10 ()
        {
            // 10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo
            // para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que
            // realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as
            // notas de menor valor fossem distribuídas em número mínimo possível.
            // Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, uma nota de R$ 20,00,
            // uma nota de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00.
            // Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas
            // de acordo com o critério da “distribuição ótima”.
            Console.WriteLine("Exercicio 10");

            Console.WriteLine("Digite a quantidade desejada");
            int quantiaSolicitada = int.Parse(Console.ReadLine());

            int nota50 = quantiaSolicitada / 50;
            int valorRestante = quantiaSolicitada % 50;

            int nota20 = valorRestante / 20;
            valorRestante = valorRestante % 20;

            int nota10 = valorRestante / 10;
            valorRestante = valorRestante % 10;

            int nota5 = valorRestante / 5;
            valorRestante = valorRestante % 5;

            int nota1 = valorRestante / 1;
            valorRestante = valorRestante % 1;

            Console.WriteLine($"{nota50} notas de R$ 50,00. {nota20} notas de R$ 20,00. {nota10} notas de R$ 10,00. {nota5} notas de R$ 5,00. {nota1} notas de R$ 1,00");


        }


        public void Exercicio11 ()
        {
            // 11) Escreva um algoritmo para ler o número de eleitores de um município,
            // o número de votos brancos, nulos e válidos. 
            // Calcule e escreva o percentual que cada um  representa em relação ao total de eleitores.
            Console.WriteLine("Exercicio 11");

            Console.WriteLine("Digite o número de eleitores do município:");
            double eleitores = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de votos brancos:");
            double votosBrancos = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de votos nulos:");
            double votosNulos = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de votos válidos:");
            double votosValidos = double.Parse(Console.ReadLine());

            double percentualVotosBrancos = (votosBrancos / eleitores) * 100;
            double percentualVotosNulos = (votosNulos / eleitores) * 100;
            double percentualVotosValidos = (votosValidos / eleitores) * 100;

            Console.WriteLine($"\nVotos brancos: {percentualVotosBrancos:f1}%.\nVotos nulos: {percentualVotosNulos:f1}%.\nVotos válidos: {percentualVotosValidos:f1}%");
            

        }

        public void Exercicio12 ()
        {
        // 12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça.Sabendo - se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a
        // marcação do odômetro(marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total(R$) recebido
        // dos passageiros.Calcule e escreva a média do consumo em Km / l e o lucro líquido do dia.

        // Fórmulas: Total quilometragem = marcação odômetro final do dia - marcação odômetro inicio do dia

        // Média do consumo = Total quilometragem / quantidade de combustível gasto

        // Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)


        }

        public void Exercicio13 ()
        {
            // 13) Uma loja vende bicicletas com um acréscimo de 50 % sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15 % sobre o
            // preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas
            // vendidas pelo vendedor, calcule e mostre: o salário do empregado
        }

    }
}
