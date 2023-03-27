using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RossD_InfoTest
{
    public partial class Form1 : Form
    {
        List<RossD_Candidato> candidato;
        public Form1()
        {
            InitializeComponent();
            candidato = new List<RossD_Candidato>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("valore");
        }

        public void Aggiunta(RossD_Candidato nuovo)
        {
            candidato.Add(nuovo);
        }

        public string[] Visualizza()
        {
            string[] strings = new string[candidato.Count];
            for (int i=0; i< candidato.Count; i++)
            {
                strings[i] = candidato[i].ToString();
            }
            return strings;
        }

        public void Modifica(int matricola, string cambio)
        {
            for (int i = 0; i < candidato.Count; i++)
            {
                if(candidato[i].RossD_Matricola == matricola)
                {
                    candidato[i].RossD_Nome =cambio;
                    return;
                }
            }
            throw new Exception("La matricola inserita non esiste");
        }
        public void Cancella (int matricola)
        {
            for (int i = 0; i < candidato.Count; i++)
            {
                if (candidato[i].RossD_Matricola == matricola)
                {
                    candidato.Remove(candidato[i]);
                    return;
                }
            }
            throw new Exception("La matricola inserita non esiste");
        }

        public void AggiornaListView()
        {
            for (int i = 0; i < candidato.Count; i++)
            {
                
            }
        }
    }
}
