using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyBrowserLib
{
    class NamespaceInfo
    {
        public string Name { get; private set; }

        public List<TypeInfo> typeInfos { get; } = new List<TypeInfo>();

        public NamespaceInfo(System.Reflection.Assembly assembly)
        {
            Name = $"Namespace : {assembly.FullName}";
        }
    }
}
