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
    }
}
