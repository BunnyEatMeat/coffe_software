using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class AccountDTO
    {
        string _userName;
        string _passWord;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string PassWord
        {
            get { return _passWord; }
            set { _passWord = value; }
        }
    }//end
}
