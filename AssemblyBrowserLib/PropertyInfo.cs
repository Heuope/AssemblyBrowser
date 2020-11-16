using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyBrowserLib
{
    class PropertyInfo
    {
        public string Name { get; private set; }

        public PropertyInfo(string name)
        {
            Name = name;
        }
    }
}
