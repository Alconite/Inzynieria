using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja_Logowanie_Rejestracja
{
    public partial class Logowanie : Form
    {
        Rejestracja register_window = new Rejestracja();
        public string login, password;

        public Logowanie()
        {
            InitializeComponent();
        }

        private void Rejestracja_Click(object sender, EventArgs e)
        {
            register_window.ShowDialog();

        }
    }
}
