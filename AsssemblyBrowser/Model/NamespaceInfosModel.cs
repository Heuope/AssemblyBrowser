using System.Collections.Generic;

namespace AsssemblyBrowser.Model
{
    class NamespaceInfosModel
    {
        public string Name { get; set; }

        public List<TypeInfoModel> TypeInfoModels { get; set; }

        public NamespaceInfosModel(string name)
        {
            TypeInfoModels = new List<TypeInfoModel>();
            Name = name;
        }
    }
}
