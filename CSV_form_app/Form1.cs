using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CSV_form_app
{
    public partial class Form1 : Form
    {
        static List<Dolgozo> dolgozok = new List<Dolgozo>();
        DatabaseConnect connect;

        public Form1()
        {
            connect = new DatabaseConnect();
            InitializeComponent();

            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            Frissit();
        }

        private void Frissit()
        {
            dolgozok.Clear();
            dolgozok = connect.SelectDolgozok();
            dolgozok_listbox.Items.Clear();
            dolgozok_listbox.Items.AddRange(dolgozok.ToArray());
            rekordszam.Text = "Dolgozók száma: "+dolgozok.Count().ToString();
        }

        private void dolgozok_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hozzaadas_Click(object sender, EventArgs e)
        {
            Dolgozo dolg;
            string nev = nev_inp.Text;
            string nem;
            if (ferfi.Checked)
            {
                nem = "férfi";
            }
            else
            {
                nem = "nő";
            }
            string reszleg_ = reszleg.Text;
            int belepes_ev = (int)belepes_eve.Value;
            int berezes_ = int.Parse(berezes.Text);

            dolg = new Dolgozo(nev, nem, reszleg_, belepes_ev, berezes_);

            connect.InsertDolgozo(dolg);

            Frissit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
