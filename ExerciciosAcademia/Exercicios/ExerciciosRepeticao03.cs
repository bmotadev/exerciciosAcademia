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
        }

        public void Exercicio04()
        {
            /*
             * 4 - Escreva um algoritmo que leia dois valores pelo teclado, x e y, e em seguida calcule a potência de xelevado na y sem utilizar a função pow.
             * **/
        }

        public void Exercicio05()
        {
            /*
             * 5 - Escreva um algoritmo para calcular o fatorial de um número.
             * **/
        }

        public void Exercicio06()
        {
            /*
             * 6 - Escreva um algoritmo que leia o número de alunos de uma turma e em seguida leia a quantidade de avaliações aplicadas para aquela turma. Por fim, leia as notas das avaliações de cada aluno e mostre sua nota final (média das notas das avaliações).
             * **/
        }

        public void Exercicio07()
        {
            /*
             * 7 - Escreva um programa em C# leia 20 números e que conte a quantidade de números pares e ímpares digitados por um usuário. Apresente o resultado.
             * **/
        }
    }
}
