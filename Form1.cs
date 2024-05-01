using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpFinalNote
{
    public partial class Form1 : Form
    {
        private const double MaxTp1 = 25;
        private const double MaxTp2 = 35;
        private const double MaxTp3 = 40;
        private const double MaxExamenPratique = 100;
        private const double MaxExamenFinal = 100;
     




        string noteGlo;
        double noteGlobal;


        double valtp1, valtp2, valtp3;
        int virgul = 2;
        double ttp;
        double valpra, valfinal;


        double notAtp1;
        double notAtp2;
        double notAtp3;
        double notApra;
        double notAfin;
        public Form1()
        {
            InitializeComponent();
        }

        private void tbTp1_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbTotp_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNoglo_TextChanged(object sender, EventArgs e)
        {

        }

        private void note_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNoteglo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            string examprt = tbEprat.Text;
            string tpfinal = tpEfin.Text;
            string tp1 = tbTp1.Text;
            string tp2 = tbTp2.Text;
            string tp3 = tbTp3.Text;

            if (double.TryParse(tp1 = tbTp1.Text, out valtp1))
            {

                if (valtp1 >= 0 && valtp1 <= 25)
                {
                    notAtp1 = (double)((valtp1 / 25) * 20);
                }
                else
                {
                    tbTp1.Text = string.Empty;
                    MessageBox.Show("entrez une valeur positif et inferieur a 25 pour la note du TP1");
                }
            }
            else
            {
                tbTp1.Text = string.Empty;
                MessageBox.Show("la valeur du TP1 n est pas valide");
            }
            if (double.TryParse(tp2= tbTp2.Text, out valtp2))
            {

                if (valtp2 >= 0 && valtp2 <= 35)
                {
                    notAtp2 = (double)((valtp2 / 35) * 20);
                }
                else
                {
                    tbTp2.Text = string.Empty;
                    MessageBox.Show("entrez une valeur positif et inferieur a 35  pour la note du TP2");
                }
            }
            else
            {
                tbTp2.Text = string.Empty;
                MessageBox.Show("la valeur du TP2 n est pas valide");
            }
            if (double.TryParse(tp3 = tbTp3.Text, out valtp3))
            {

                if (valtp3 >= 0 && valtp3 <= 40)
                {
                    notAtp3 = (double)((valtp3 / 40) * 20);
                }
                else
                {
                    tbTp3.Text = string.Empty;
                    MessageBox.Show("entrez une valeur positif et inferieur a 40 pour la note du TP3");
                }
            }
            else
            {
                tbTp3.Text = string.Empty;
                MessageBox.Show("la valeur du TP3 n est pas valide");
            }
            if (double.TryParse(examprt= tbEprat.Text, out valpra))
            {

                if (valpra >= 0 && valpra <= 100)
                {
                    notApra = (double)((valpra / 100) * 20);
                }
                else
                {
                    tbEprat.Text = string.Empty;
                    MessageBox.Show("entrez une valeur positif et inferieur a 100 pour la note de l examen pratique");
                }
            }
            else
            {
                tbEprat.Text = string.Empty;
                MessageBox.Show("la valeur de l examen pratique n est pas valide");
            }
            if (double.TryParse(tpfinal= tpEfin.Text, out valfinal))
            {

                if (valfinal >= 0 && valfinal <= 100)
                {
                    notAfin = (double)((valfinal / 100) * 20);

                }
                else
                {
                    tpEfin.Text = string.Empty;
                    MessageBox.Show("entrez une valeur positif et inferieur a 100 pour la note de l examen final");
                }
            }
            else
            {
                tpEfin.Text = string.Empty;
                MessageBox.Show("la valeur de l examen final n est pas valide");
            }
            ttp = (double)((notAtp1 + notAtp2 + notAtp3));


            totaltp.Text = ttp.ToString("N" + virgul);

            if (double.TryParse(noteGlo, out noteGlobal))
            {
                                          
            }
            double ttpp = (double)(notAfin * 0.4 + notApra * 0.2);
            noteGlobal = (double)((ttp / 3 * 0.4 + ttpp));
            tbNoteG.Text = noteGlobal.ToString("N" + virgul);

            if (noteGlobal < 10)
            {
                button3.Text = "E";
            }
            else
            {
                if (noteGlobal >= 10 && noteGlobal < 14)
                {
                    button3.Text = "D";
                }
                if (noteGlobal < 16 && noteGlobal >= 14)
                {
                    button3.Text = "C"; ;
                }
                if (noteGlobal < 18 && noteGlobal >= 16)
                {
                    button3.Text = "B";
                }
                if (noteGlobal >= 18)
                {
                    button3.Text = "A";
                }
            }

        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            tbTp1.Text = "";
            tbTp2.Text = "";
            tbTp3.Text = "";
            tbEprat.Text = "";
            tpEfin.Text = "";
            tbNoteG.Text = "";
            totaltp.Text = "";
            button3.Text = "";
        }

        private void btnQuiter_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult quiter;
                quiter = MessageBox.Show("voulez vous vraiment quiter ?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (quiter == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbLettre_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void tbNoteG_Click(object sender, EventArgs e)
        {

        }
    }
}
