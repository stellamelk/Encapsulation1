using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation1
{
    class Bank
    {
        //hiding class data by declaring the variable as private
        private decimal _balance;
        //create public setter and getter
        public decimal getBalance()
        {
            return _balance;
        }
        public void setBalance(decimal balance)
        {
            _balance = balance; 
        }
    }
}
