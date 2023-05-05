using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPooUpaSaude
{
    internal class ProfissionalSaude
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string RegistroConselho { get; set; }

        public ProfissionalSaude()
        {
        }

        public ProfissionalSaude(string nome, string tipo, string registroConselho)
        {
            Nome = nome;
            Tipo = tipo;
            RegistroConselho = registroConselho;
        }

        public string SobreNome()
        {
            string[] lista = Nome.Split(' ');

            return lista[lista.Length -1] + " = " + RegistroConselho;
        }
    }
}
