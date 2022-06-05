using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_Logowanie_Rejestracja
{
    public class Accounts
    {
        public string xlogin { get; set; }
        public string xpassword { get; set; }

        public Accounts()
        {

        }
        public Accounts(Accounts accounts)
        {
            this.xlogin = accounts.xlogin;
            this.xpassword = accounts.xpassword;
        }
        public Accounts(string xlogin, string xpassword)
        {
            this.xlogin = xlogin;
            this.xpassword = xpassword;
        }
    }
}
