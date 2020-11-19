using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyBrowserLib
{
    public class PropertyInfo
    {
        public string Name { get; private set; }

        public PropertyInfo(System.Reflection.PropertyInfo property)
        {
            Name = $"Property : {Namer.GetName(property.PropertyType)} {property.Name}";
        }
    }
}
