using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyBrowserLib
{
    public class MethodInfo
    {
        public string Name { get; private set; }

        public MethodInfo(System.Reflection.MethodInfo method)
        {
            Name = $"Method : {Namer.GetName(method.ReturnType)} {method.Name} (";

            var parametrs = method.GetParameters();

            List<string> temp = new List<string>();

            foreach (var parameter in parametrs)
            {
                temp.Add($"{Namer.GetName(parameter.ParameterType)} {parameter.Name} ");
            }

            Name += $"{string.Join(", ", temp.ToArray())})";
        }
    }
}
