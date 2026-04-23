using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_09._04._26
{
    public abstract class Pink : Object
    {
        private string _input;
        public string Input => _input;
        protected Pink(string input)
        {
            _input = input;
        }
        public abstract void Rewiew();
        public virtual void ChangeText(string input)
        {
            _input = input;
            Rewiew();
        }
    }
}
