using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosAcademia.Exercicios
{
    internal class ExerciciosSequenciais01
    {
        public void Exercicio01 ()
        {
            // 1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.
            double numero1 = double.Parse(Console.ReadLine());
            double numero2 = double.Parse(Console.ReadLine());

            double media = (numero1 + numero2)/2;

            Console.WriteLine($"A media dos numeros digitados é: {media:f2}");
        }

        public void Exercicio02 ()
        {
            // 2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.

        }
    }
}
