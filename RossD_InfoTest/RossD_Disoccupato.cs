using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RossD_InfoTest
{
    public class RossD_Disoccupato : RossD_Candidato, IComparable<RossD_Disoccupato>, IEquatable<RossD_Disoccupato> 
    {
        private int RossD_voto;
        private bool RossD_lode;

        public int RossD_Voto
        {
            get { return RossD_voto; }

            set {
                if (value > 110 || value<0)
                {
                    throw new Exception(" il valore inserito supera il limite di 110");
                }
                else
                {
                    RossD_voto = value;
                }
                }
        }

        public bool RossD_Lode
        {
            get { return RossD_lode; }

            set
            {
                RossD_lode = value;
            }
        }
        public RossD_Disoccupato(): base()
        {
            RossD_Voto = 0;
            RossD_Lode = false;
        }
        public RossD_Disoccupato(int voto, bool lode) : base()
        {
            RossD_Voto= voto;
            RossD_Lode = lode;
        }

        public override int punteggio()
        {
            int rapportato = RossD_Voto / 110 * 100;
            if (RossD_Lode== true)
            {
                rapportato += 5;
                return rapportato;
            }
            else
            {
                return rapportato;
            }
        }

        public override bool isIdoneo()
        {
            if (RossD_Voto >= 72)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return "matricola: " + Convert.ToString(RossD_Matricola) + " nome: " + RossD_Nome + " voto: " + RossD_Voto + " lode: " + RossD_Lode;
        }


        public bool Equals(RossD_Disoccupato other)
        {
            if (base.Equals(other) == true && other.punteggio() == this.punteggio())
                return true;
            else
                return false;
        }

        public int CompareTo(RossD_Disoccupato uno)
        {
            if (uno.punteggio() == this.punteggio())
            {
                return 0;
            }
            if (uno.punteggio() > this.punteggio())
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

    }
}
