using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPooUpaSaude
{
    internal class UnidadeSaude
    {

        // atributo junto com metodo get e set
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public ProfissionalSaude Responsavel { get; set; }

        //construtor vazio
        public UnidadeSaude()
        {
        }

        // construtor
        public UnidadeSaude(string nome, string sigla)
        {
            Nome = nome.ToUpper();
            Sigla = sigla.ToUpper();
        }

        public UnidadeSaude(string nome)
        {
            Nome = nome;
        }
    }
}
