using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практика_16._03._26
{
    internal interface IPersonal
    {
        public int Balance => 0;
        void Deposite(int money);
        void Withdraw(int money);
    }
}
