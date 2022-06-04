using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja_Logowanie_Rejestracja
{
    public partial class Rejestracja : Form
    {
        public string imie, nazwisko, login, haslo, poczta;
        public DateTime date;
        public bool kobieta;
        public Rejestracja()
        {
            InitializeComponent();
        }

        private void Rejestruj_Click(object sender, EventArgs e)
        {
            if ((NameBox.Text != "") && (SurnameBox.Text != "") && (LoginBox.Text != "") && (PasswordBox.Text != "") && (EmailBox.Text != "") && (MaleRB.Checked || FemaleRB.Checked))
            {
                if (Regex.IsMatch(NameBox.Text, @"^[\p{L}]+$") && Regex.IsMatch(SurnameBox.Text, @"^[\p{L}]+$"))
                {
                    imie = NameBox.Text;
                    nazwisko = SurnameBox.Text;
                    login = LoginBox.Text;
                    haslo = PasswordBox.Text;
                    poczta = EmailBox.Text;
                    if (MaleRB.Checked)
                        kobieta = false;
                    else
                        kobieta = true;
                }
                else
                    MessageBox.Show("Imie i Nazwisko musza zawierac tylko litery");
            }
            else
            {

            }
        }
    }
}
