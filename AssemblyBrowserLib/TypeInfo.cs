using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyBrowserLib
{
    class TypeInfo
    {
        public string Name { get; private set; }

        public List<MethodInfo> MethodsInfos { get; } = new List<MethodInfo>();
        public List<PropertyInfo> PropertyInfos { get; } = new List<PropertyInfo>();
        public List<FieldInfo> FieldsInfos { get; } = new List<FieldInfo>();
        public List<ConstructorsInfos> ConstructorsInfos { get; } = new List<ConstructorsInfos>();

        public TypeInfo(System.Reflection.TypeInfo typeInfo)
        {
            Name = typeInfo.Name;
        }
    }
}
