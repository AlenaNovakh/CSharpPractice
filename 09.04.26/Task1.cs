using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_09._04._26
{
    //не забыть, что все таски от Розового
    public class Task1 : Pink
    {
        private int _output;
        public int Output => _output;
        public Task1(string text) : base(text)
        {
            _output = 0;
            //можно создать свой метод и вписать сюда
        }
        public override void Rewiew()
        {
            _output = 134;
        }
        public override string ToString()
        {
            return $"{_input}{Environment.NewLine}{_output}";
        }
    }
}
