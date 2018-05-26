using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string liczba_pierwsza;
        string liczba_druga;
        char rodzaj_dzialania = ' ';

        private void p0_Click(object sender, EventArgs e)
        {
            dzialanie(0);
        }
        private void p1_Click(object sender, EventArgs e)
        {
            dzialanie(1);
        }
        private void p2_Click(object sender, EventArgs e)
        {
            dzialanie(2);
        }
        private void p3_Click(object sender, EventArgs e)
        {
            dzialanie(3);
        }
        private void p4_Click(object sender, EventArgs e)
        {
            dzialanie(4);
        }
        private void p5_Click(object sender, EventArgs e)
        {
            dzialanie(5);
        }

        private void p6_Click(object sender, EventArgs e)
        {
            dzialanie(6);
        }
        private void p7_Click(object sender, EventArgs e)
        {
            dzialanie(7);
        }
        private void p8_Click(object sender, EventArgs e)
        {
            dzialanie(8);
        }
        private void p9_Click(object sender, EventArgs e)
        {
            dzialanie(9);
        }



        private void iloraz_Click(object sender, EventArgs e)
        {
            rodzaj_dzialania = '/';
            text_wynik.Text = "";
        }



        private void iloczyn_Click(object sender, EventArgs e)
        {
            rodzaj_dzialania = '*';
            text_wynik.Text = "";
        }

        private void roznica_Click(object sender, EventArgs e)
        {
            rodzaj_dzialania = '-';
            text_wynik.Text = "";
        }

        private void suma_Click(object sender, EventArgs e)
        {
            rodzaj_dzialania = '+';
            text_wynik.Text = "";
        }

        private void wynik_Click(object sender, EventArgs e)
        {   
            switch(rodzaj_dzialania)
            {
                case ('+'):
                    {
                        text_wynik.Text = (int.Parse(liczba_pierwsza) + int.Parse(liczba_druga)).ToString();
                        break; }
                case ('-'):
                    {
                        text_wynik.Text = (int.Parse(liczba_pierwsza) - int.Parse(liczba_druga)).ToString();
                        break;}
                case ('*'):
                    {
                        text_wynik.Text = (int.Parse(liczba_pierwsza) * int.Parse(liczba_druga)).ToString();
                        break; }
                case ('/'):
                    {
                        text_wynik.Text = (int.Parse(liczba_pierwsza) / int.Parse(liczba_druga)).ToString();
                        break;
                    }
            }
            liczba_pierwsza = "";
            liczba_druga = "";
            rodzaj_dzialania = ' ';

        }

        private void dzialanie(int liczba)
        {
            if(rodzaj_dzialania == ' ')
            {
                liczba_pierwsza += liczba;
                text_wynik.Text = liczba_pierwsza;
            }
            else
            {
                liczba_druga += liczba;
                text_wynik.Text = liczba_druga;
            }
        }


        private void text_wynik_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
