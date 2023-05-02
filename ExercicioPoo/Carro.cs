using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPoo
{
    internal class Carro
    {
        //•1 - Crie uma classe chamada Carro que possua 3 atributos: marca, modelo e anoFabricacao.Além disso, na main crie 2 objetos do tipo Carro e exiba na tela os valores dos atributos criados.

        //•Esses valores devem ser solicitados ao usuário, por linha de execução.

        public string marca;
        public string modelo;
        public string anoFabricacao;

        public Carro()
        {
        }

        public Carro(string marca, string modelo, string anoFabricacao)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.anoFabricacao = anoFabricacao;
        }

        public void exibeDados()
        {
            Console.WriteLine($"Marca: {this.marca}");
            Console.WriteLine($"Modelo: {this.modelo}");
            Console.WriteLine($"Ano de Fabricação: {this.anoFabricacao}");
        }
    }
}
