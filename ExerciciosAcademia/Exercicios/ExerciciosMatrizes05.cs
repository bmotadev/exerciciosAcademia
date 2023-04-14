using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosAcademia.Exercicios
{
    internal class ExerciciosMatrizes05
    {
        public void Exercicio01()
        {
            /*
             * 1) Crie uma Matriz 5x3. Na primeira coluna, solicite que o usuário preencha. 
             * A 2ª coluna, some 10 aos elementos da 1ª coluna. 
             * Na 3º coluna, armazene o dobro dos elementos da 1ª coluna.
             * **/

            int[,] matriz = new int[5, 3];

            for (int linha = 0; linha < 5; linha++)
            {
                Console.WriteLine("Digite um valor para a primeira coluna:");
                matriz[linha, 0] = int.Parse(Console.ReadLine());
                matriz[linha, 1] = matriz[linha, 0] + 10;
                matriz[linha, 2] = matriz[linha, 0] * 2;
            }

            for (int linha = 0; linha < 5; linha++) 
            { 
                for (int coluna = 0; coluna < 3; coluna++) 
                { 
                    Console.Write(matriz[linha, coluna] + "\t"); 
                } 
                Console.WriteLine(); 
            }
        }
    }
}
