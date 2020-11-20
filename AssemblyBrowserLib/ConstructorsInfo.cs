using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyBrowserLib
{
    public class ConstructorsInfo
    {
        public string Name { get; private set; }

        public ConstructorsInfo(System.Reflection.ConstructorInfo constructor)
        {
            Name = $"Constructor : {Namer.GetName(constructor.DeclaringType)} (";

            var parametrs = constructor.GetParameters();

            List<string> temp = new List<string>();

            foreach (var parameter in parametrs)
            {
                temp.Add($"{Namer.GetName(parameter.ParameterType)} {parameter.Name} ");
            }

            Name += $"{string.Join(", ", temp.ToArray())})";
        }
    }
}
