# ExerciciosAcademia

### Exercicios Sequenciais

1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.

2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.

3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre 
si os valores de duas variáveis A e B.

4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.

5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
(medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível 
consumido para percorrê-la (medido em l).

6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem 
de IPI (única) a ser acrescentada. 

7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
Calcule o salário total do vendedor. Escreva o número do vendedor e o salário total do vendedor.

8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
A fórmula da conversão é F=(9*C+160)/5.

9) Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior 
do que ou igual às prestações, que devem ser iguais, inteiras e as maiores possíveis. 
Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00; 
se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00.
Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
da entrada e das duas prestações, de acordo com as regras acima. 
Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o 
conseqüente pagamento dos boletos das duas prestações.
 
10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
notas de menor valor fossem distribuídas em número mínimo possível. 
Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, uma nota de R$ 20,00,
uma nota de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
de acordo com o critério da “distribuição ótima”.

11) Escreva um algoritmo para ler o número de eleitores de um município, 
o número de votos brancos, nulos e válidos. 
Calcule e escreva o percentual que cada um  representa em relação ao total de eleitores.

12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a 
marcação do odômetro (marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total (R$) recebido 
dos passageiros. Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.

Fórmulas: Total quilometragem =  marcação odômetro final do dia - marcação odômetro inicio do dia 

Média do consumo = Total quilometragem/ quantidade de combustível gasto

Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)

13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o 
preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas 
vendidas pelo vendedor, calcule e mostre: o salário do empregado

---

### Exercicios Seleção

1 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
Área do triangulo = (base * altura) / 2; 
Teste se a base ou a altura digitada não foi igual a zero. 

2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. 

3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e escrever na tela os que são superiores à média.

4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles. 
Mostrar na tela qual dos professores tem o maior salário total.

5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
se a média das duas notas for maior ou igual a 7,0. 

Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final,
é a média entre a nota do exame e a média das 2 notas. 
Se esta média final for maior ou igual a 5,0, o programa deve escrever “Aprovado”, caso contrário deve 
escrever “Reprovado”.

6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
O programa deve calcular o Indice de Massa Corpórea (IMC), exibi-lo ao usuário e informar sua situação conforme a tabela.
O cálculo do imc = peso / (altura * altura)

IMC 
menor que 18                -> baixo peso
maior que 18 e menor que 25 -> peso normal
maior que 25 e menor que 30 -> sobrepeso
maior que 30 e menor que 35 -> obesidade
maior que 35                -> obesidade grau sério


7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por 
exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.

8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
total de vendas. 

9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.

Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que
150, avisá-lo que será necessário adicionar 2 unidades de insulina.

10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
O programa deve mostrar os dados do atleta mais novo e mais alto.
