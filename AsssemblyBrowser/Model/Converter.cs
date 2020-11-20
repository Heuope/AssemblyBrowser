using System.Collections.Generic;
using AssemblyBrowserLib;

namespace AsssemblyBrowser.Model
{
    class Converter
    {
        public List<NamespaceInfosModel> Convert(List<NamespaceInfo> namespaceInfos)
        {
            var result = new List<NamespaceInfosModel>();

            foreach (var namespaceInfo in namespaceInfos)
            {
                var tempNamespaceModel = new NamespaceInfosModel(namespaceInfo.Name);

                foreach (var typeInfo in namespaceInfo.typeInfos)
                {
                    var tempTypeModel = new TypeInfoModel(typeInfo.Name);

                    foreach (var field in typeInfo.FieldsInfos)
                    {
                        tempTypeModel.Describe.Add(field.Name);
                    }

                    foreach (var property in typeInfo.PropertyInfos)
                    {
                        tempTypeModel.Describe.Add(property.Name);
                    }

                    foreach (var constructor in typeInfo.ConstructorsInfos)
                    {
                        tempTypeModel.Describe.Add(constructor.Name);
                    }

                    foreach (var method in typeInfo.MethodsInfos)
                    {
                        tempTypeModel.Describe.Add(method.Name);
                    }

                    tempNamespaceModel.TypeInfoModels.Add(tempTypeModel);
                }

                result.Add(tempNamespaceModel);
            }

            return result;
        }
    }
}
