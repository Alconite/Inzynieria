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
using System.Threading;

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
                if (NameBox.Text == "")
                    NameBox.BackColor = Color.LightCoral;
                if (SurnameBox.Text == "")
                    SurnameBox.BackColor = Color.LightCoral;
                if (LoginBox.Text == "")
                    LoginBox.BackColor = Color.LightCoral;
                if (PasswordBox.Text == "")
                    PasswordBox.BackColor = Color.LightCoral;
                if (EmailBox.Text == "")
                    EmailBox.BackColor = Color.LightCoral;

            }
        }

        private void Text_Change1(object sender, EventArgs e)
        {
            if (NameBox.Text != "")
                NameBox.BackColor = Color.White;
        }

        private void Text_Change2(object sender, EventArgs e)
        {
            if (SurnameBox.Text != "")
                SurnameBox.BackColor = Color.White;
        }

        private void Text_Change3(object sender, EventArgs e)
        {
            if (LoginBox.Text != "")
                LoginBox.BackColor = Color.White;
        }

        private void Text_Change4(object sender, EventArgs e)
        {
            if (PasswordBox.Text != "")
                PasswordBox.BackColor = Color.White;
        }

        private void Text_Change5(object sender, EventArgs e)
        {
            if (EmailBox.Text != "")
                EmailBox.BackColor = Color.White;
        }

    }
}
