using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaLeitorGlicemia
{
    internal class Glicemia : IComparable
    {
        public int valorDaGlicemia;

        public string data;
        
        public Glicemia(string data, int valorDaGlicemia)
        {
            this.valorDaGlicemia = valorDaGlicemia;
            this.data = data;
        }

        public int CompareTo(object? obj)
        {
            Glicemia glicemia = (Glicemia)obj;
            if(this.valorDaGlicemia == glicemia.valorDaGlicemia)
            {
                return 0;
            } else if ( this.valorDaGlicemia < glicemia.valorDaGlicemia) // criterio de ornacao
            {
                return 1;
            }
            return 1;
        }



    }
}
