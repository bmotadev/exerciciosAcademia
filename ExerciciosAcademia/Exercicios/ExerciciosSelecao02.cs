﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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

        public void Exercicio05()
        {
            /*
             * 5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” se a média das duas notas for maior ou igual a 7,0.
             * 
             * Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final,é a média entre a nota do exame e a média das 2 notas. 
             * Se esta média final for maior ou igual a 5,0, o programa deve escrever “Aprovado”, caso contrário deve escrever “Reprovado”.
             * **/
            Console.WriteLine("Exercicio 05 - Exercicios Seleção");

            Console.WriteLine("Informe a primeira nota:");
            double notaUm = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota:");
            double notaDois = double.Parse(Console.ReadLine());

            double media = (notaUm + notaDois) / 2;

            double mediaFinal = 0;

            if(media < 7.0)
            {
                Console.WriteLine("Informe a nota do exame:");
                double notaDoExame = double.Parse(Console.ReadLine());

                mediaFinal = (media + notaDoExame) / 2;
            }

            if(mediaFinal >= 5.0)
            {
                Console.WriteLine("Aprovado");
            } else
            {
                Console.WriteLine("Reprovado");
            }



        }

        public void Exercicio06() 
        {
            /*
             * 6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
             * O programa deve calcular o Indice de Massa Corpórea (IMC), exibi-lo ao usuário e informar sua situação conforme a tabela.
             * O cálculo do imc = peso / (altura * altura)
             * 
             * IMC 
             * menor que 18                -> baixo peso
             * maior que 18 e menor que 25 -> peso normal
             * maior que 25 e menor que 30 -> sobrepeso
             * maior que 30 e menor que 35 -> obesidade
             * maior que 35                -> obesidade grau sério
             * **/
            Console.WriteLine("Exercicio 06 - Exercicios Seleção");

            Console.WriteLine("Informe seu nome");
            string nome = Console.ReadLine().ToUpper();

            Console.WriteLine("Informe sua altura em metros:");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu peso:");
            double peso = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            string situacao;

            if(imc < 18)
            {
                situacao = "Baixo peso";
            }
            else if ( imc > 18 && imc < 25)
            {
                situacao = "Peso normal";
            }
            else if ( imc > 25 && imc < 30)
            {
                situacao = "Sobrepeso";
            }
            else if ( imc > 30 && imc < 35)
            {
                situacao = "Obesidade";
            }
            else
            {
                situacao = "Obesidade Grau Sério";
            }

            Console.WriteLine($"{nome} seu imc é de : {imc:f2}. E você está com: {situacao}");

        }

        public void Exercicio07()
        {
            /*
             * 7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
             * O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.
             * **/

            Console.WriteLine("Digite uma frase: ");
            string frase = Console.ReadLine();

            Console.WriteLine("Digite uma palavra: ");
            string palavra = Console.ReadLine();

            if(frase.Contains(palavra))
            {
                Console.WriteLine($"A palavra {palavra} está dentro da frase {frase}");
            } else
            {
                Console.WriteLine("Não possui a palavra");
            }
        }

        public void Exercicio08()
        {
            /*
             * 8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
             * Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
             * Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
             * E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do total de vendas. 
             * **/
            Console.WriteLine("Exercicio 08 - Exercicios Seleção");

            Console.WriteLine("Digite o código:");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome:");
            string nome  = Console.ReadLine();

            Console.WriteLine("Digite o salário base:");
            double salarioBase = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o total de vendas do funcionário:");
            double totalDeVendasDoFuncionario = double.Parse(Console.ReadLine());

            double salarioFinal = salarioBase;

            if(totalDeVendasDoFuncionario > 500 && totalDeVendasDoFuncionario <= 1000)
            {
                salarioFinal = salarioFinal + (totalDeVendasDoFuncionario * 0.05);
            }
            else if (totalDeVendasDoFuncionario > 1000 && totalDeVendasDoFuncionario <= 5000)
            {
                salarioFinal = salarioFinal + (totalDeVendasDoFuncionario * 0.07);
            } 
            else if (totalDeVendasDoFuncionario > 5000)
            {
                salarioFinal = salarioFinal + (totalDeVendasDoFuncionario * 0.10);
            }

            Console.WriteLine($"O vendedor {nome} teve um salário final de R$ {salarioFinal:f2}");

        }

        public void Exercicio09()
        {
            /*
             * 9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
             * 
             * Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
             * Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.
             * 
             * Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. 
             * Se a média for maior que150, avisá-lo que será necessário adicionar 2 unidades de insulina.
             * **/
            Console.WriteLine("Exercicio 09 - Exercicios Seleção");

            Console.WriteLine("Informe a primeira medição:");
            double primeiraMedicao = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a segunda medição");
            double segundaMedicao = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a terceira medição");
            double terceiraMedicao = double.Parse(Console.ReadLine());

            if(primeiraMedicao < 65 || segundaMedicao < 65 || terceiraMedicao < 65 )
            {
                Console.WriteLine("Risco de Hipoglicemia");
            }
            if(primeiraMedicao > 250 || segundaMedicao > 250 || terceiraMedicao > 250)
            {
                Console.WriteLine("Risco de Hiperglicemia");
            }

            double media = (primeiraMedicao + segundaMedicao + terceiraMedicao) / 3;

            if(media < 80)
            {
                Console.WriteLine("Diminuir 2 unidades de insulina");
            }
            if(media > 150)
            {
                Console.WriteLine("Adicionar 2 unidades de insulina");
            }

        }

        public void Exercicio10()
        {
            /*
             * 10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
             * O programa deve mostrar os dados do atleta mais novo e mais alto.
             * **/
            Console.WriteLine("Exercicio 10 - Exercicios Seleção");

            //int idadeAtletaUm = 0, idadeAtletaDois = 0;

            Console.WriteLine("Escreva o nome do atleta 1:");
            string nomeAtletaUm = Console.ReadLine();

            Console.WriteLine("Escreva a idade do atleta 1:");
            int idadeAtletaUm = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva a altura do atleta 1:");
            double alturaAtletaUm = double.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o nome do atleta 2:");
            string nomeAtletaDois = Console.ReadLine();

            Console.WriteLine("Escreva a idade do atleta 2:");
            int idadeAtletaDois = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva a altura do atleta 2:");
            double alturaAtletaDois = double.Parse(Console.ReadLine());

            if (idadeAtletaUm < idadeAtletaDois)
            {
                Console.WriteLine($"O atleta mais novo é o {nomeAtletaUm}");
            }
            else
            {
                Console.WriteLine($"O atleta mais novo é o {nomeAtletaDois}");
            }

            if(alturaAtletaUm > alturaAtletaDois)
            {
                Console.WriteLine($"O atleta mais alto é o {nomeAtletaUm}");
            } else
            {
                Console.WriteLine($"O atleta mais alto é o {nomeAtletaDois}");
            }



        }

        public void Exercicio11()
        {
            /*
             * 11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis (uma para hora e outra para minutos).
             * O programa deve exibir se a hora digitada está ou não válida. 
             * Lembre que usaremos o padrão de hora com 24h, de 0 a 23.
             * **/
            Console.WriteLine("Exercicio 11 - Exercicios Seleção");

            Console.WriteLine("Digite um horário:");
            string[] horario = Console.ReadLine().Split(':');
            int hora = int.Parse(horario[0]);
            int minutos = int.Parse(horario[1]);


            if(hora >= 0 && hora <= 23)
            {
                if(minutos >= 0 && minutos <= 59)
                {
                    Console.WriteLine("Hora digitada é válida");
                }
                else
                {
                    Console.WriteLine("Hora digitada não é valida");
                }
            }
            else
            {
                Console.WriteLine("Hora digitada não é valida");
            }

            
        }

        public void Exercicio12()
        {
            /*
             * 12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e número de horas trabalhadas de um operário. 
             * Na sequência, calcule o salário sabendo-se que ele ganha R$ 10,00 por hora. 
             * Quando o número de horas exceder a 50 calcule o excesso de pagamento armazenando-o na variável "extra", caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. 
             * No final do processamento, exibir o salário total e o salário excedente do operário.
             * **/
            Console.WriteLine("Exercicio 12 - Exercicios Seleção");

            Console.WriteLine("Informe o código do operário:");
            int codigoOperario = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número de horas trabalhas do operário:");
            int horasTrabalhasOperario = int.Parse(Console.ReadLine());

            double horaExtra;
            double salarioTotal;
            if(horasTrabalhasOperario > 50)
            {
                horaExtra = (horasTrabalhasOperario - 50) * 20;
                salarioTotal = (50 * 10) + horaExtra;
            } else
            {
                horaExtra = 0;
                salarioTotal = horasTrabalhasOperario * 10;
            }

            Console.WriteLine($"O funcionário {codigoOperario} tem o salário total de R$ {salarioTotal:f2} com o excedente de R$ {horaExtra}");
        }

        public void Exercicio13()
        {
            /*
             * 13 - Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule seu peso ideal, utilizando as seguintes fórmulas:
             * Para homens: (72.7 * h) - 58
             * Para mulheres: (62.1 * h) - 44.7
             * **/
            Console.WriteLine("Exercicio 13 - Exercicios Seleção");

            Console.WriteLine("Informe altura:");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual seu sexo? \nH - Homem \nM - Mulher");
            char sexo = char.Parse(Console.ReadLine());
            double calculoPesoIdeal;

            if(sexo == 'H')
            {
                calculoPesoIdeal = (72.7 * altura) - 58;
            } else
            {
                calculoPesoIdeal = (62 * altura) - 44.7;
            }

            Console.WriteLine($"Seu peso ideal é de: {calculoPesoIdeal:f2}");

        }

        public void Exercicio14()
        {
            /*
             * 14 - Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um link de Internet (em Mbps). 
             * Em seguida, calcule e informe o tempo aproximado de download do arquivo usando este link (em minutos).
             * **/
            Console.WriteLine("Exercicio 14 - Exercicios Seleção");

            Console.WriteLine("Informe o tamanho do arquivo:");
            double tamanhoDoArquivoMb = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a velocidade do link da internet(em Mbps):");
            double velocidadeLinkMbps = double.Parse(Console.ReadLine());

            double tempoAproximadoDownloadMinutos = (tamanhoDoArquivoMb / (velocidadeLinkMbps / 8)) / 60;

            Console.WriteLine($"Tempo aproximado de download é de: {tempoAproximadoDownloadMinutos}");
        }

        public void Exercicio15()
        {
            /*
             * 15 - Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados da área a ser pintada. 
             * Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00.
             * Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.
             * **/
            Console.WriteLine("Exercicio 15 - Exercicios Seleção");

            double area, qtdTinta, valorTotal, qtdLatas, qtdLatasCeiling = 0, qtdLatasFloor;

            Console.WriteLine("Digite a área a ser pintadas:");
            area = double.Parse(Console.ReadLine());

            qtdTinta = area / 3;
            qtdLatas = qtdTinta / 18;

            qtdLatasFloor = Math.Floor(qtdLatas);
            qtdLatasCeiling = Math.Ceiling(qtdLatasCeiling);

            Console.WriteLine($"A área de {area} precisa de {qtdTinta} litros de tinta");
            Console.WriteLine($"Será necessário comprar {qtdLatas} latas de tinta");
            Console.WriteLine($"Será necessário comprar {qtdLatasCeiling} latas de tinta");
            Console.WriteLine($"Será necessário comprar {qtdLatasFloor} latas de tinta");
            valorTotal = qtdLatas * 80;

            Console.WriteLine($"Custará R$ {valorTotal}");
        }

        public void Exercicio16()
        {
            /*
             * 16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil. 
             * Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. 
             * Caso contrário, mostre uma mensagem indicando que os dois times irão se enfrentar novamente em um novo jogo.
             * ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
             * ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
             * plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.
             * **/
            Console.WriteLine("Exercicio 16 - Exercicios Seleção");

        }

        public void Exercicio17()
        {
            /*
             * 17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), e então diga se esses lados podem ou não formar um triangulo. 
             * Para que os lados formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. 
             * Caso os lados formem um triangulo, diga se o mesmo é equilátero (todos os lados iguais), isoceles (somente 2 lados são iguais) ou escaleno (os 3 lados são diferentes).
             * **/
            Console.WriteLine("Exercicio 17 - Exercicios Seleção");

            char[] lados = {'A','B','C'};

            int[] valorDosLados = new int[3];

            int valorA, valorB, valorC;
            for(int i  = 0; i < lados.Length; i++)
            {
                Console.WriteLine($"Informe o lado {lados[i]}");
                valorDosLados[i] = int.Parse(Console.ReadLine());
            }

            valorA = valorDosLados[0];
            valorB = valorDosLados[1];
            valorC = valorDosLados[2];


            if( valorA <= (valorB + valorC) && valorB <= (valorC + valorA) && valorC <= (valorA + valorB)) 
            {
                Console.WriteLine("Pode formar um Triangulo");



                if(valorA == valorB && valorC == valorA && valorB == valorC)
                {
                    Console.WriteLine("Equilátero");
                } else if ( valorA == valorB || valorC == valorA || valorB == valorC)
                {
                    Console.WriteLine("Isoceles");
                } else
                {
                    Console.WriteLine("EScaleno");
                }
            }


        }

        public void Exercicio18()
        {
            /*
             * 18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.
             * **/
            Console.WriteLine("Exercicio 18 - Exercicios Seleção");

            int n1, n2, n3;
            Console.WriteLine("Digite o N1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o N2: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o N3: ");
            n3 = int.Parse(Console.ReadLine());
            if (n1 > n2 && n1 > n3)
            {
                if (n2 < n3)
                {
                    Console.WriteLine("N2 " + n2);
                    Console.WriteLine("N3 " + n3);
                }
                else if (n2 > n3)
                {
                    Console.WriteLine("N3 " + n3);
                    Console.WriteLine("N2 " + n2);
                }
                else
                {
                    Console.WriteLine("N2 e N3 são iguais");
                }
                Console.WriteLine("N1 " + n1);
            }
            else if (n2 > n1 && n2 > n3)
            {
                if (n1 < n3)
                {
                    Console.WriteLine("N1 " + n1);
                    Console.WriteLine("N3 " + n3);
                }
                else if (n1 > n3)
                {
                    Console.WriteLine("N3 " + n3);
                    Console.WriteLine("N1 " + n1);
                }
                else
                {
                    Console.WriteLine("N1 e N3 são iguais");
                }
                Console.WriteLine("N2 " + n2);
            }
            else if (n3 > n1 && n3 > n2)
            {
                if (n1 < n2)
                {
                    Console.WriteLine("N1 " + n1);
                    Console.WriteLine("N2 " + n2);
                }
                else if (n1 > n2)
                {
                    Console.WriteLine("N2 " + n2);
                    Console.WriteLine("N1 " + n1);
                }
                else
                {
                    Console.WriteLine("N1 e N2 são iguais");
                }
                Console.WriteLine("N3 " + n3);
            }
            else
            {
                Console.WriteLine("Algum dos valores são iguais");
            }

        }

        public void Exercicio19()
        {
            /*
             * 19 - Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente.
             * **/
            Console.WriteLine("Exercicio 19 - Exercicios Seleção");

            
        }

        public void Exercicio20()
        {
            /*
             * 20 - Escreva um algoritmo para o jogo de adivinhação do número secreto. 
             * O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
             * plus: você pode gerar o número de forma randomica (função random c#).
             * **/
            Console.WriteLine("Exercicio 20 - Exercicios Seleção");
        }

        public void Exercicio21()
        {
            /*
             * 21 - Crie um programa que permita que o usuário selecione uma unidade de medida de entrada (metros, centímetros, polegadas ou pés) e uma unidade de medida de saída usando um menu com o comando switch case. 
             * O programa deve, em seguida, pedir ao usuário um valor de entrada e converter esse valor para a unidade de saída selecionada.
             * **/
            Console.WriteLine("Exercicio 21 - Exercicios Seleção");
        }
    }
}
