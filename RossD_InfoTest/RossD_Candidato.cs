using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RossD_InfoTest
{
    public abstract class RossD_Candidato
    {
        private int RossD_matricola;
        private string RossD_nome;

        public RossD_Candidato()
        {
            RossD_Matricola = 0;
            RossD_Nome = null;
        }

        public RossD_Candidato(int matricola)
        {
            RossD_Matricola = matricola;
            RossD_Nome = null;
        }

        public RossD_Candidato(string nome)
        {
            RossD_Nome = nome;
            RossD_Matricola = 0;
        }

        public RossD_Candidato(string nome, int matricola)
        {
            RossD_Nome = nome;
            RossD_Matricola = matricola;
        }

        public int RossD_Matricola{ get; set;}
        public string RossD_Nome{ get; set;}

        public abstract bool isIdoneo();
        public abstract int punteggio();

        public abstract string ToString();
        public virtual bool Equals(RossD_Candidato other)
        {
            if (this.RossD_Matricola == other.RossD_Matricola && this.RossD_Nome == other.RossD_Nome)
            {
                return true;
            }
            return false;
        }
        /*
        public virtual bool EqualsType(RossD_Candidato other)
        {
            if (this.GetType is other.GetType)
            {
                return true;
            }
            return false;
        }
        */

        public virtual int GetHashCode()
        {
            return (RossD_Matricola, RossD_Nome).GetHashCode();
        }
    }
}
