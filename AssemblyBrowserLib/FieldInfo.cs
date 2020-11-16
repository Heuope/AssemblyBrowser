using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyBrowserLib
{
    class FieldInfo
    {
        public string Name { get; private set; }

        public FieldInfo(System.Reflection.FieldInfo fieldInfo)
        {
            Name = $"Field : {fieldInfo.FieldType.ToString()}";
        }
    }
}
