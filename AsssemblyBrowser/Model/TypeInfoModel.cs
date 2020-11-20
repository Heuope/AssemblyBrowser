using System.Collections.Generic;

namespace AsssemblyBrowser.Model
{
    internal class TypeInfoModel
    {
        public string Name { get; set; }

        public List<string> Describe { get; set; }

        public TypeInfoModel(string typeName)
        {
            Describe = new List<string>();
            Name = typeName;
        }
    }
}