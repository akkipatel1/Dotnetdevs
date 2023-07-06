using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDemoApp
{
    internal class Account
    {
        private int _Id;
       // public int Id;
        private string _Name;
        private decimal _Balance;
        private string _Address;
        public string Address { get; set; }//help in future
        private bool _IdAlreadyExist;
        public Account()
        {
            MessageBox.Show("Object is Created");
        }

        ~Account()
        {
            MessageBox.Show("Object is destroyed");
        }
        public int Id
        {
            get
            {
                return _Id;
            }

            set
            {
                if (_IdAlreadyExist)
                {
                    throw new ApplicationException("ID already exist");
                }
                else
                {
                    _Id = value;
                    _IdAlreadyExist = true;
                }
                
            }
        }

        public string Name
        {

            get
            {
                return _Name;
            }
            set
            {
                if (value.Length < 8)
                    _Name = value;
                else
                    throw new ApplicationException("Name should be no more than 8 Character");
            }
        }

        public decimal Balance
        {
            get
            {
                return _Balance;
            }
           /* set
            {
                _Balance = value;
            }*/
        }

        public void Deposite(decimal Amount)
        {
            this._Balance += Amount;
        }

        public void Withdraw(decimal Amount)
        {
            if (this._Balance - Amount > 500)
                this._Balance -= Amount;
            else
                throw new ApplicationException("Insufficient Funds");
        }
    }
}
