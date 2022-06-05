using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplikacja_Logowanie_Rejestracja.model;

namespace Aplikacja_Logowanie_Rejestracja
{
    public partial class Logowanie : Form
    {
        public ObservableCollection<Account> userList { get; }
        public Account account { get; set; }
        public string login, password;

        public Logowanie()
        {
            InitializeComponent();
            DatabaseService DatabaseService = new DatabaseService();
            DatabaseService.createConnection();
            userList = DatabaseService.executeProcedureSelect<Account>("tbUser");
        }


        private void Rejestracja_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            Rejestracja register_window = new Rejestracja(this, button.Name);

            register_window.ShowDialog();

        }

        private void Zaloguj_Click(object sender, EventArgs e)
        {

        }

        public void addUserToUserList()
        {
            userList.Add(this.account);
        }
    }
}
