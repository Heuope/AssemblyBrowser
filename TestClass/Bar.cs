using System;
using System.Collections.Generic;
using System.Text;

namespace TestClass
{
    class Bar
    {
        private List<Foo> _foos;

        public List<Foo> Foos { get => _foos; set => _foos = value; }

        public Bar()
        {
            Foos = new List<Foo>();
        }

        public void DoSomething()
        {

        }
    }
}
