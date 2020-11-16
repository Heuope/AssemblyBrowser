using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyBrowserLib
{
    class MethodInfo
    {
        public string Name { get; private set; }

        public MethodInfo(System.Reflection.MethodInfo methodInfo)
        {
            Name = $"Method : {methodInfo.ReturnType.Name} {methodInfo.Name} (";

            var parametrs = methodInfo.GetParameters();

            foreach (var parameter in parametrs)
            {
                Name += $"{parameter.Name} : {parameter.ParameterType.ToString()}, ";
            }

            Name += " )";
        }
    }
}
