using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyBrowserLib
{
    public class NamespaceInfo
    {
        public string Name { get; private set; }

        public List<TypeInfo> typeInfos { get; } = new List<TypeInfo>();

        public NamespaceInfo(string name)
        {
            Name = $"Namespace : {name}";
        }
    }
}
