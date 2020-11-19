using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyBrowserLib
{
    public class FieldInfo
    {
        public string Name { get; private set; }

        public FieldInfo(System.Reflection.FieldInfo field)
        {
            Name = $"Field : {Namer.GetName(field.FieldType)} {field.Name}";
        }
    }
}
