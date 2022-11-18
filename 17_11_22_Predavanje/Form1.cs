using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_11_22_Predavanje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Pravokutnik p1 = new Pravokutnik(3,4);
            Kvadrat k1 = new Kvadrat(3, 4);
            Ispis(p1, k1);
            k1.Visina = 7;
            Kvadrat k2 = new Kvadrat(5);
            Ispis(k1,k2);
            k2.Visina = 7;
            Trokut t1 = new Trokut(3, 4);
            Ispis(k2, t1);
            t1.Visina = 20;
            Ispis(t1);

        }

        void Ispis(params GeometrijskiLik[] likovi )
        {
            for(int i = 0; i < likovi.Length; i++)
            {
                lblShowReturn.Text += $"{likovi[i].GetType().Name} - VISINA: {likovi[i].Visina} - ŠIRINA: {likovi[i].Sirina} - POVRŠINA: {likovi[i].Povrsina}\n";
            }
        }

        private void btnShow2_Click(object sender, EventArgs e)
        {
            Pacijent pacijent1 = new Pacijent();
            Namjestaj namjestaj1 = new Namjestaj();
            Gospodarstvo gospodarstvo1 = new Gospodarstvo();

            lblShowReturn2.Text += $"{pacijent1.Oporavak()} \n {namjestaj1.Oporavak()} \n {gospodarstvo1.Oporavak()} \n"; 
        }
    }
}
