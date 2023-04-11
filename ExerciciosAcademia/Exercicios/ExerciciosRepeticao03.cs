using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosAcademia.Exercicios
{
    internal class ExerciciosRepeticao03
    {
        public void Exercicio01()
        {
            /*
             * 1 - Escreva um algoritmo para ler um número n, e em seguida ler pelo teclado a idade de n pessoas e calcular a média das idades.
             * **/
            Console.WriteLine("Digite um numero:");
            int valorN = int.Parse(Console.ReadLine());

            int totalIdade = 0;

            for (int i = 1; i <= valorN; i++)
            {
                Console.WriteLine("Digite sua idade");
                int idade = int.Parse(Console.ReadLine());

                totalIdade += idade;
            }

            double mediaIdades = totalIdade / valorN;

            Console.WriteLine($"A media de idades é de: {mediaIdades:f2}");
        }

        public void Exercicio02()
        {
            /*
             * 2 - Faça um algoritmo que leia 10 números pelo teclado, e que no final mostre o maior deles. Não usar vetor.
             * **/
            Console.WriteLine("Exercicio 02 - Exercicio de Repetição");

            int maiorNumero = 0;

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Digite o {i}º número:");
                int numero = int.Parse(Console.ReadLine());

                if(numero > maiorNumero)
                {
                    maiorNumero = numero;
                }
            }
            Console.WriteLine($"O maior numero entre os digitados é o: {maiorNumero}");



        }

        public void Exercicio03()
        {
            /*
             * 3 - Escreva um algoritmo que leia pelo teclado um valor e então calcule a tabuada de 1 a 10 de um númerox lido utilizando laços de repetição, e mostre na tela.
             * **/
            Console.WriteLine("Exercicio 03 - Exercicio de Repetição");

            Console.WriteLine("Informe o valor da tabuada que deseja:");
            int valor = int.Parse(Console.ReadLine());

            for(int i = 1;i <= 10;i++)
            {
                Console.WriteLine($"{i} x {valor} = {i*valor}");
            }

        }

        public void Exercicio04()
        {
            /*
             * 4 - Escreva um algoritmo que leia dois valores pelo teclado, x e y, e em seguida calcule a potência de x elevado na y sem utilizar a função pow.
             * **/
            Console.WriteLine("Exercicio 04 - Exercicio de Repetição");

            Console.WriteLine("Informe o primeiro valor:");
            int primeiroValor = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor:");
            int segundoValor = int.Parse(Console.ReadLine());

            int potencia = 1;

            for(int i = 1; i <= segundoValor; i++)
            {
                potencia *= primeiroValor;
            }

            Console.WriteLine($"A potência de {primeiroValor} elevado a {segundoValor} é: {potencia}");
        }

        public void Exercicio05()
        {
            /*
             * 5 - Escreva um algoritmo para calcular o fatorial de um número.
             * **/
            Console.WriteLine("Exercicio 05 - Exercicio de Repetição");

            Console.WriteLine("Digite um valor para calcular seu fatorial:");
            int numero = int.Parse(Console.ReadLine());

            int fatorial = 1;

            for(int i = numero; i > 1; i--)
            {
                fatorial *= i; 
            }

            Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
        }

        public void Exercicio06()
        {
            /*
             * 6 - Escreva um algoritmo que leia o número de alunos de uma turma e em seguida leia a quantidade de avaliações aplicadas para aquela turma. Por fim, leia as notas das avaliações de cada aluno e mostre sua nota final (média das notas das avaliações).
             * **/
            Console.WriteLine("Exercicio 06 - Exercicio de Repetição");


            // ler o numero de alunos
            Console.WriteLine("Informe o número de alunos");
            int quantidadeAlunos = int.Parse(Console.ReadLine());

            // ler a quantidade de avaliacoes
            Console.WriteLine("Informe a quantidade de avaliações aplicadas:");
            int quantidadeAvaliacoes = int.Parse(Console.ReadLine());

            double totalNotas;

            // ler as notas das avaliações de cada aluno
            for(int i = 1; i <= quantidadeAlunos; i++)
            {
                totalNotas = 0;
                for (int j = 1; j <= quantidadeAvaliacoes; j++)
                {
                    Console.WriteLine($"Informe a nota da {j}º avaliação do {i}º aluno:");
                    double notas = double.Parse(Console.ReadLine());
                    totalNotas += notas;
                }

                // mostrar nota final
                double mediaAvaliacoes = totalNotas / quantidadeAvaliacoes;
                Console.WriteLine($"A média das notas do {i}º aluno é de: {mediaAvaliacoes:f2}");
            }

            
        }

        public void Exercicio07()
        {
            /*
             * 7 - Escreva um programa em C# leia 20 números e que conte a quantidade de números pares e ímpares digitados por um usuário. Apresente o resultado.
             * **/
            Console.WriteLine("Exercicio 07 - Exercicio de Repetição");

            int numerosPares = 0, numerosImpares = 0;

            for(int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"Digite o {i}º número:");
                int numero = int.Parse(Console.ReadLine());

                if(numero % 2 == 0 )
                {
                    numerosPares++;
                } else
                {
                    numerosImpares++;
                }
            }

            Console.WriteLine($"Foram digitados {numerosPares} numeros pares. E {numerosImpares} numeros impares");
        }
    }
}
