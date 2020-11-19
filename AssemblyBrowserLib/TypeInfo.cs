using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyBrowserLib
{
    public class TypeInfo
    {
        public string Name { get; private set; }

        public List<MethodInfo> MethodsInfos { get; } = new List<MethodInfo>();
        public List<PropertyInfo> PropertyInfos { get; } = new List<PropertyInfo>();
        public List<FieldInfo> FieldsInfos { get; } = new List<FieldInfo>();
        public List<ConstructorsInfo> ConstructorsInfos { get; } = new List<ConstructorsInfo>();

        public TypeInfo(Type type)
        {
            Name = type.Name;
        }
    }
}
