using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPoo02
{
    internal class Computador
    {
        //•Crie uma classe chamada Computador que possua 4 atributos: marca, modelo, tipo(notebook, netbook, tablet, etc) e preço.

        //Crie dois objetos onde o primeiro objeto deverá ser criado através da solicitação dos valores ao usuário por linha de execução.Já, os valores do segundo objeto, deverão ser definidos no código - fonte da classe que o criou.Exiba na tela os resultados.

        public string marca;
        public string modelo;
        public string tipo;
        public double preco;

        public Computador()
        {

        }

        public Computador(string marca, string modelo, double preco, string tipo)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.preco = preco;
            this.tipo = tipo;
        }

        public void exibeDados()
        {
            Console.WriteLine($"Marca: {this.marca}");
            Console.WriteLine($"Modelo: {this.modelo}");
            Console.WriteLine($"Tipo: {this.tipo}");
            Console.WriteLine($"Preço: {this.preco:f2}");
        }
    }
}
