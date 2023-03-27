using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RossD_InfoTest
{
    public class RossD_Disoccupato : RossD_Candidato
    {
        private int RossD_voto;
        private bool RossD_lode;

        public int RossD_Voto
        {
            get { return RossD_voto; }

            set {
                if (value > 110)
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

        }
        public RossD_Disoccupato(int voto, bool lode) : base()
        {
            RossD_Voto= voto;
            RossD_Lode = lode;
        }

        public override int punteggio()
        {
            int rapportato = RossD_Voto;
            if (RossD_Lode== true)
            {
                rapportato += 5;
                return RossD_Voto / 110 * 100;
            }
            else
            {
                return RossD_Voto / 110 * 100;
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
    }
}
