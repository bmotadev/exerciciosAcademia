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

        public void Exercicio05()
        {
            /*
             * 5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” se a média das duas notas for maior ou igual a 7,0.
             * 
             * Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final,é a média entre a nota do exame e a média das 2 notas. 
             * Se esta média final for maior ou igual a 5,0, o programa deve escrever “Aprovado”, caso contrário deve escrever “Reprovado”.
             * **/
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
        }

        public void Exercicio07()
        {
            /*
             * 7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
             * O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.
             * **/
        }

        public void Exercicio08()
        {
            /*
             * 8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
             * Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
             * Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
             * E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do total de vendas. 
             * **/
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
        }

        public void Exercicio10()
        {
            /*
             * 10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
             * O programa deve mostrar os dados do atleta mais novo e mais alto.
             * **/
        }
    }
}
