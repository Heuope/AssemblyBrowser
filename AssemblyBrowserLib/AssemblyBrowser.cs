using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace AssemblyBrowserLib
{
    public class AssemblyBrowser
    {
        public List<NamespaceInfo> GetNamespaceInfos(string path)
        {
            var namespaceNames = new Dictionary<string, NamespaceInfo>();

            try
            {
                var asm = Assembly.LoadFile(path);

                foreach (var type in asm.GetTypes())
                {
                    if (Attribute.GetCustomAttribute(type, typeof(CompilerGeneratedAttribute)) == null)
                    {
                        var typeInfo = new TypeInfo(type);

                        if (Attribute.GetCustomAttribute(type, typeof(CompilerGeneratedAttribute)) == null && !namespaceNames.ContainsKey(type.Namespace))
                        {
                            namespaceNames.Add(type.Namespace, new NamespaceInfo(type.Namespace));
                        }

                        foreach (var method in type.GetMethods())
                        {
                            if (Attribute.GetCustomAttribute(method, typeof(CompilerGeneratedAttribute)) == null)
                            {
                                typeInfo.MethodsInfos.Add(new MethodInfo(method));
                            }
                        }

                        foreach (var field in type.GetFields())
                        {
                            if (Attribute.GetCustomAttribute(field, typeof(CompilerGeneratedAttribute)) == null)
                            {
                                typeInfo.FieldsInfos.Add(new FieldInfo(field));
                            }
                        }

                        foreach (var property in type.GetProperties())
                        {
                            if (Attribute.GetCustomAttribute(property, typeof(CompilerGeneratedAttribute)) == null)
                            {
                                typeInfo.PropertyInfos.Add(new PropertyInfo(property));
                            }
                        }

                        foreach (var constructor in type.GetConstructors())
                        {
                            if (Attribute.GetCustomAttribute(constructor, typeof(CompilerGeneratedAttribute)) == null)
                            {
                                typeInfo.ConstructorsInfos.Add(new ConstructorsInfo(constructor));
                            }
                        }

                        namespaceNames[type.Namespace].typeInfos.Add(typeInfo);
                    }
                }
            }
            catch (Exception)
            {

            }

            return namespaceNames.Select(x => x.Value).ToList();
        }
    }
}
