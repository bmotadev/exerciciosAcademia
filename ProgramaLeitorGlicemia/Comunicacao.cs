using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaLeitorGlicemia
{

    internal class Comunicacao
    {

        public static bool validaNome(string nome)
        {
            string[] vetor = nome.Split();
            if (vetor.Length < 2)
            {
                return false;
            }
            return true;
        }

        public static bool validaData(string data)
        {
            //   dd/mm/aaaa --- exemplo de 'preocupacao'
            string[] vetor = data.Split('/');

            if (vetor.Length != 3 || vetor[0].Length > 2 || vetor[1].Length > 2 || vetor[2].Length != 4)
            {
                return false;
            }
            return true;
        }

        public static void listar(List<Glicemia> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

    }
}