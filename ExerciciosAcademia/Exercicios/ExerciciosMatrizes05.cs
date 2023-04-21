using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

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

        public void Exercicio02()
        {
            /*
             * 2) Solicite ao usuário, preencher uma Matriz 3x3

                    Informe ao usuário:
                    *A soma dos elementos de cada linha
	                    -Ex: Linha 1: 30
	                         Linha 2: 17
                    *A soma dos elementos de cada coluna
	                    -Ex: Coluna 1: 23
	                         Coluna 2: 36
             * **/

            int[,] matriz = new int[3, 3];
            Console.WriteLine(matriz.GetLength(0)); //mostra qtas linhas ha
            Console.WriteLine(matriz.GetLength(1)); //mostra qtas colunas ha

            Console.WriteLine("Preencha a matriz 3x3!!");

            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    Console.Write("Posicao[" + linha + "," + coluna + "]: ");
                    matriz[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            //exibir a matriz
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    Console.Write(matriz[linha, coluna] + "\t");
                }
                Console.WriteLine();
            }

            int soma;
            //calcular e mostrar a soma de linha a linha
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                soma = 0;
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    soma = soma + matriz[linha, coluna];
                }
                Console.WriteLine("A soma dos elementos da linha " + linha + ": " + soma);
            }


            //calcular e mostrar a soma de coluna a coluna
            for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
            {
                soma = 0;
                for (int linha = 0; linha < matriz.GetLength(0); linha++)
                {
                    soma = soma + matriz[linha, coluna];
                }
                Console.WriteLine("A soma dos elementos da coluna " + coluna + ": " + soma);
            }
        }

        public void Exercicio03()
        {
            /*
             * 3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!
             * **/

            int[,] matriz = new int[4, 4];

            Console.WriteLine("Preencha uma matriz 4x4");

            for(int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for(int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    Console.WriteLine($"Informe o valor da linha {linha+1} na coluna {coluna+1}:");
                    matriz[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("Elementos da Diagonal Principal: ");
            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for(int coluna = 0; coluna < matriz.GetLength(1);coluna++)
                {
                    if(linha == coluna)
                    {
                        Console.Write($"{matriz[linha, coluna]} ");
                    }
                }
            }
        }

        public void Exercicio04()
        {
            /*
             * 4) Popule uma matriz 5x5 e informe:
                    -Quantos números são pares
                    -Quantos números são impares
                    -Quantos números são positivos
                    -Quantos números são negativos
                    -Quantos zeros existem!
             * **/

            int[,] matriz = new int[2,2];

            int numerosPares = 0, numerosImpares = 0, numerosPositivos = 0, numerosNegativos = 0, numerosZeros = 0;

            Console.WriteLine("Popule uma matriz 5x5");

            for(int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for(int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    Console.WriteLine($"Informe o valor da coluna {coluna+1} na linha {linha+1}");
                    matriz[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            for(int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    if((matriz[linha,coluna] % 2 == 0) && (matriz[linha,coluna] != 0))
                    {
                        numerosPares++;
                    }
                    if ((matriz[linha,coluna] % 2 == 1) || (matriz[linha,coluna] % 2 == -1))
                    {
                        numerosImpares++;
                    }
                    if (matriz[linha,coluna] > 0)
                    {
                        numerosPositivos++;
                    }
                    if (matriz[linha,coluna] < 0)
                    {
                        numerosNegativos++;
                    }
                    if (matriz[linha,coluna] == 0)
                    {
                        numerosZeros++;
                    }
                }
            }

            Console.WriteLine($"Existem {numerosPares} números pares");
            Console.WriteLine($"Existem {numerosImpares} números ímpares");
            Console.WriteLine($"Existem {numerosPositivos} números positivos");
            Console.WriteLine($"Existem {numerosNegativos} números negativos");
            Console.WriteLine($"Existem {numerosZeros} números zeros");
        }

        public void Exercicio05()
        {
            /*
             * 5) Leia duas matrizes 2x3 de números double. 
                    Imprima a soma destas duas matrizes.
             * **/

            Console.WriteLine("Leia duas matrizes 2x3 de números double");

            double[,] matrizA = new double[2, 3];
            double[,] matrizB = new double[2, 3];
            double[,] matrizResultado = new double[2, 3];


            // leitura da primeira matriz
            for(int linha = 0; linha < matrizA.GetLength(0); linha++)
            {
                for(int coluna = 0; coluna < matrizB.GetLength(1); coluna++)
                {
                    Console.WriteLine($"Informe o valor da coluna {coluna+1} na linha {linha+1} da Matriz A");
                    matrizA[linha,coluna] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
            }

            // leitura da segunda matriz
            for(int linha = 0; linha < matrizB.GetLength(0); linha++)
            {
                for(int coluna = 0; coluna < matrizB.GetLength(1); coluna++)
                {
                    Console.WriteLine($"Informe o valor da coluna {coluna + 1} na linha {linha + 1} da Matriz B");
                    matrizB[linha, coluna] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
            }


            for(int linha = 0; linha < matrizA.GetLength(0); linha++)
            {
                for(int coluna = 0; coluna < matrizA.GetLength(1); coluna++)
                {
                    matrizResultado[linha,coluna] = matrizA[linha,coluna] + matrizB[linha, coluna];
                    Console.WriteLine($"Soma da  Coluna {coluna+1} na linha {linha+1} da Matriz A com a Coluna {coluna+1} na Linha {linha+1} da Matriz B = {matrizResultado[linha,coluna]}");
                }
            }
        }

        public void Exercicio06()
        {
            /*
             * 6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9. Após isso determine o maior número da matriz.
                    Random random = new Random();
                    int randomNumber = random.Next(0, 100);
             * **/

            Random random = new Random();
            int maiorNumero = 0;
            int[,] matriz = new int[4, 4];

            for(int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for(int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    int numeroRandom = random.Next(0, 100);
                    matriz[linha, coluna] = numeroRandom;

                    if (matriz[linha, coluna] > maiorNumero)
                    {
                        maiorNumero = matriz[linha, coluna];
                    }
                }
            }

            Console.WriteLine($"O maior número da matriz é: {maiorNumero}");
        }

        public void Exercicio07()
        {
            /*
             * 7) Leia duas matrizes A e B com 3x3 elementos. Construir uma matriz C, onde cada elemento de C é a subtração do elemento correspondente de A com B.
             * **/
            int[,] matrizA = new int[3, 3];
            int[,] matrizB = new int[3, 3];
            int[,] matrizC = new int[3, 3];

            Random random = new Random();

            for (int linha = 0; linha < matrizA.GetLength(0);linha++)
            {
                for (int coluna = 0; coluna < matrizB.GetLength(1); coluna++)
                {
                    Console.WriteLine($"Informe o valor da coluna {coluna+1} na linha {linha+1} da Matriz A:");
                    int numeroRandom = random.Next(0, 100);
                    matrizA[linha, coluna] = numeroRandom;
                    //matrizA[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            for(int linha = 0; linha < matrizB.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matrizB.GetLength(1); coluna++)
                {
                    Console.WriteLine($"Informe o valor da coluna {coluna+1} na linha {linha+1} da Matriz B:");
                    int numeroRandom = random.Next(0, 100);
                    matrizB[linha, coluna] = numeroRandom;
                    //matrizB[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            for(int linha = 0; linha < matrizC.GetLength(0); linha++)
            {
                for(int coluna = 0; coluna < matrizC.GetLength(1); coluna++)
                {
                    matrizC[linha, coluna] = matrizA[linha, coluna] - matrizB[linha, coluna];
                    Console.Write($"{matrizC[linha, coluna]} | ");
                }
                Console.WriteLine("\n");
            }
        }

        public void Exercicio08()
        {
            /*
             * 8) Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta e inversa a que foram lidos.
             * **/

            //Random random = new Random();
            int[,] matriz = new int[4, 4];

            for(int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for(int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    int numeroRandom = int.Parse(Console.ReadLine());
                    matriz[linha, coluna] = numeroRandom;

                }
            }
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Valores na Ordem Direta");
            Console.ResetColor();

            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for(int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    Console.Write($" {matriz[linha, coluna]} |");
                }
                Console.WriteLine();
            }

            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("\nValores na ordem inversa");
            Console.ResetColor();

            for (int linha = 3; linha >= 0; linha--)
            {
                for(int coluna = 3; coluna >= 0; coluna--)
                {
                    Console.Write($" {matriz[linha, coluna]} |");
                }
                Console.WriteLine();
            }
        }

        public void Exercicio09()
        {
            /*
             * 9) Leia uma matriz 3x3.  Em seguida, solicite um número qualquer ao usuário e pesquise na matriz se o número existe.  
                    Caso, seja verdade imprima a mensagem:  “O número existe no vetor” , caso contrário “Número inexistente”.
             * **/

            Random numeroRandom = new Random();
            int[,] matriz = new int[3, 3];

            

            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for(int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    matriz[linha, coluna] = numeroRandom.Next(0, 9);
                    Console.WriteLine(matriz[linha,coluna]);
                }
            }

            Console.WriteLine("Digite um numero:");
            int numeroUsuario = int.Parse(Console.ReadLine());

            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    if (matriz[linha, coluna] == numeroUsuario)
                    {
                        Console.WriteLine("O número existe no vetor");
                        break;
                    }
                    else if ( (linha == 2) && (coluna == 2) && (matriz[linha, coluna] != numeroUsuario))
                    {
                        Console.WriteLine("Número inexistente.");

                    }
                }
            }




            
        }

        public void Exercicio10()
        {
            /*
             * 10) Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos, em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.
             * **/

            double[,] matrizA = new double[4,4];
            double[,] matrizB = new double[4,4];

            double media = 0;
            int acimaDaMedia = 0, naMedia = 0, abaixoDaMedia = 0;

            Random numeroRandom = new Random();

            for(int linha = 0; linha < matrizA.GetLength(0); linha++)
            {
                for(int coluna = 0; coluna < matrizA.GetLength(1); coluna++)
                {
                    matrizA[linha, coluna] = numeroRandom.NextDouble();
                }
            }

            for (int linha = 0; linha < matrizB.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matrizB.GetLength(1); coluna++)
                {
                    matrizB[linha, coluna] = numeroRandom.NextDouble();
                }
            }

            for (int linha = 0; linha < matrizA.GetLength(0); linha++)
            {
                for(int coluna = 0; coluna < matrizA.GetLength(1);coluna++)
                {
                    media += matrizA[linha, coluna] + matrizB[linha, coluna];
                }
            }

            media = media / 32;

            for (int linha = 0; linha < matrizA.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matrizA.GetLength(1); coluna++)
                {
                    if(matrizA[linha, coluna] > media)
                    {
                        acimaDaMedia++;
                    }
                    if (matrizB[linha, coluna] > media)
                    {
                        acimaDaMedia++;
                    }
                    if (matrizA[linha, coluna] == media)
                    {
                        naMedia++;
                    }
                    if (matrizB[linha, coluna] == media)
                    {
                        naMedia++;
                    }
                    if (matrizA[linha, coluna] < media)
                    {
                        abaixoDaMedia++;
                    }
                    if (matrizB[linha, coluna] < media)
                    {
                        abaixoDaMedia++;
                    }
                }
            }

            Console.WriteLine($"\n{naMedia} elementos na media. \n{acimaDaMedia} elementos acima da média. \n{abaixoDaMedia} elementos abaixo da media.");

        }

        public void Exercicio11()
        {
            /*
             * 11) Leia uma matriz A de tipo double de dimenção 3x3, crie uma nova matriz resultante da divisão dos elementos da matriz A pela soma dos seus indices.
             * **/

        }

        public void Exercicio12()
        {
            /*
             * 12) Escreva um programa que leia os valores de uma matriz 4x3, e em seguida mostre na tela apenas os valores cuja soma dos índices (i+j) seja um número par.
             * **/
            Random numeroRandom = new Random();
            int[,] matriz = new int[4, 3];

            for( int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    matriz[linha, coluna] = numeroRandom.Next();
                }
            }

            for(int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for(int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    int calculo = (linha + coluna) % 2;
                    if(calculo == 0)
                    {
                        Console.WriteLine(matriz[linha, coluna]);
                    }
                }
            }
        }

        public void Exercicio13()
        {
            /*
             * 13) Escreva um programa que leia uma matriz de ordem 5 (ou seja, 5x5) e verifique se a soma dos elementos da diagonal principal é igual a soma dos elementos da 
                    diagonal secundária.
             * **/
        }

        public void Exercicio14()
        {
            /*
             * 14) Escreva um programa que leia uma matriz de ordem 5 e verifique se os elementos da diagonal principal (da esquerda para a direita) são os mesmos da diagonal secundária (direita pra esquerda).

             * **/
        }

        public void Exercicio15()
        {
            /*
             * 15) Escreva um programa em C# para ler os valores e somar duas matrizes 4 x 4. Mostrar a matriz resultante.
             * **/
        }

        public void Exercicio16()
        {
            /*
             * 16) Escreva um algoritmo para transpor uma matriz 3x4 para outra 4x3. Transpor uma matriz significa transformar suas linhas em colunas e vice-versa.
             * **/
        }

        public void Exercicio17()
        {
            /*
             * 17) Desafio: Fazer um algoritmo que leia uma matriz de 10 linhas por 10 colunas e escreva o elemento minimax, ou seja,o menor elemento da linha onde se encontra o maior elemento da matriz. Escreva também a linha e a coluna onde foi encontrado.
             * **/
        }
    }
}
