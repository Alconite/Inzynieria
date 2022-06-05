using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_Logowanie_Rejestracja.model
{
    public class Account : INotifyPropertyChanged
    {
        private string _Login;
        public string Login
        {
            get { return this._Login; }
            set
            {
                if (this._Login != value)
                {
                    this._Login = value;
                    this.NotifyPropertyChanged("Login");
                }
            }
        }

        private string _Password;
        public string Password
        {
            get { return this._Password; }
            set
            {
                if (this._Password != value)
                {
                    this._Password = value;
                    this.NotifyPropertyChanged("Password");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
