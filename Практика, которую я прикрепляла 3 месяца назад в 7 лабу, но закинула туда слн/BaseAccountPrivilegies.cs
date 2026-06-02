using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практика_16._03._26
{
    internal class BaseAccountPrivilegies : IPersonal
    {
        private static int _countId;
        private int _id;
        private int _balance;
        public int Id { get { return _id; } }
        public BaseAccountPrivilegies()
        {
            _id = _countId;
            _countId++;
        }
        public int Balance => _balance;

        public void Deposite(int money)
        {
            throw new NotImplementedException();
            _balance += money;
        }

        public void Withdraw(int money)
        {
            throw new NotImplementedException();
            if (money < 0)
            {
                Console.WriteLine();
                return;
            }
            _balance -= money;
        }
    }
}
