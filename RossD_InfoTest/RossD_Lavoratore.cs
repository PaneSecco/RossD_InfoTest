using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RossD_InfoTest
{
    internal class RossD_Lavoratore : RossD_Candidato //: IComperable<RossD_Lavoratore> : IEquetable<RossD_Lavoratore>
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

        public override string ToString()
        {
            return "matricola: " + Convert.ToString(RossD_Matricola) + " nome: " + RossD_Nome + " esperienze: " + Convert.ToString(RossD_Esperienze);
        }
        public override bool Equals(RossD_Candidato other)
        {
            if (this.RossD_Matricola == other.RossD_Matricola && this.RossD_Nome == other.RossD_Nome)
            {
                return true;
            }
            return false;
        }

        public bool Equals(RossD_Lavoratore other)
        {
            if (this.RossD_Esperienze == other.RossD_Esperienze)
            {
                return true;
            }
            return false;
        }
        public int CompareTo(RossD_Lavoratore uno, RossD_Lavoratore due)
        {
            if (uno.punteggio() == due.punteggio())
            {
                return 0;
            }
            if (uno.punteggio() > due.punteggio())
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
