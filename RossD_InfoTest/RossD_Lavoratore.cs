using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RossD_InfoTest
{
    internal class RossD_Lavoratore : RossD_Candidato
    {
        private int RossD_esperienze;

        public int RossD_Esperienze
        {
            get { return RossD_esperienze; }
            set
            {
                if (value >= 5 || value < 0)
                {
                    throw new Exception("fuori dal range");
                }
                else
                {
                    RossD_esperienze = value;
                }
            }
        }

        public RossD_Lavoratore() : base()
        {
            RossD_Esperienze = 0;
        }

        public RossD_Lavoratore(int esperienze) : base()
        {
            RossD_Esperienze = esperienze;
        }

        public override int punteggio()
        {
            int punti = RossD_Esperienze * 20;
            return punti;
        }

        public override bool isIdoneo()
        {
            if (punteggio() >= 60)
            {
                return true;
            }
            return false;
        }
    }
}
