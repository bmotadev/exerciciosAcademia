using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosAcademia.Exercicios
{
    internal class ExerciciosSelecao02
    {
        public void Exercicio01 () 
        {
            /*
             * 1 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
             * Área do triangulo = (base * altura) / 2; 
             * Teste se a base ou a altura digitada não foi igual a zero. 
             * **/

            Console.WriteLine("Informe o valor da base:");
            double valorBase = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor da altura:");
            double valorAltura = double.Parse(Console.ReadLine());


            if(valorBase != 0 && valorAltura != 0)
            {
                double areaDoTriangulo = (valorBase * valorAltura) / 2;
                Console.WriteLine($"Área do Triângulo: {areaDoTriangulo:f2}");
            } else
            {
                Console.WriteLine("Digite um valor diferente de 0");
            }
        }

        public void Exercicio02 ()
        {
            /*
             * 2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. 
             * **/

            Console.WriteLine("Digite um número");
            int numero = int.Parse(Console.ReadLine());

            if(numero / 2 == 0)
            {
                Console.WriteLine("Número é par");
            } else
            {
                Console.WriteLine("Número é impar");
            }
        }

        public void Exercicio03 ()
        {
            /*
             * 3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e escrever na tela os que são superiores à média.
             * **/
            Console.WriteLine("Digite o primeiro valor:");
            int valorUm = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            int valorDois = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor:");
            int valorTres = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o quarto valor:");
            int valorQuatro = int.Parse(Console.ReadLine());

            int media = (valorUm + valorDois + valorTres + valorQuatro) / 4;

            if(valorUm > media)
            {
                Console.WriteLine($"O valor {valorUm} é superior a média");
            }
            if(valorDois > media)
            {
                Console.WriteLine($"O valor {valorDois} é superior a média");
            }
            if(valorTres > media)
            {
                Console.WriteLine($"O valor {valorTres} é superior a média");
            }
            if(valorQuatro > media)
            {
                Console.WriteLine($"O valor {valorQuatro} é superior a média");
            }
        }

        public void Exercicio04()
        {
            /*
             * 4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles.
             * Mostrar na tela qual dos professores tem o maior salário total.
             * **/

            Console.WriteLine("Informe a quantidade de horas do primeiro professor:");
            double quantidadeDeHorasProfessorUm = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de horas do segundo professor:");
            double quantidadeDeHorasProfessorDois = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor por hora recebido pelo primeiro professor:");
            double valorHoraProfessorUm  = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor por hora recebido pelo segundo professor");
            double valorHoraProfessorDois = double.Parse(Console.ReadLine());

            double salarioProfessorUm = quantidadeDeHorasProfessorUm * valorHoraProfessorUm;
            double salarioProfessorDois = quantidadeDeHorasProfessorDois * valorHoraProfessorDois;

            if(salarioProfessorUm > salarioProfessorDois)
            {
                Console.WriteLine("O primeiro professor tem o maior salário");
            } else
            {
                Console.WriteLine("O segundo professor tem o maior salário");
            }


        }
    }
}
