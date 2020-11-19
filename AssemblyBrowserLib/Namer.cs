using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssemblyBrowserLib
{
    public static class Namer
    {
        public static string GetName(Type type)
        {
            if (type.IsGenericType)
            {
                var genericArguments = type.GetGenericArguments();
                var typeDefeninition = type.Name;
                var unmangledName = typeDefeninition.Substring(0, typeDefeninition.IndexOf("`"));
                return unmangledName + "<" + string.Join(",", genericArguments.Select(GetName)) + ">";
            }
            else
            {
                return type.Name;
            }
        }
    }
}
