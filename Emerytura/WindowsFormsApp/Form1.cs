using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        const int WiekEmerytalny = 65;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonWyslij_Click(object sender, EventArgs e)
        {
            string wynik = "Witaj " + textBoxImie.Text + " " + textBoxNazwisko.Text;
            int wiek = int.Parse(textBoxWiek.Text);
            string wynik2;
            if(wiek > WiekEmerytalny)
            {
                wynik2 = "Jesteś emerytem";
            }
            else
            {
                wynik2 = $"Do emerytury zostało Ci {WiekEmerytalny - wiek}!";
            }
            labelWynik.Text = wynik + "\n" + wynik2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
