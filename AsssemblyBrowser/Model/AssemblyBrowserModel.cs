using System.Collections.Generic;
using AssemblyBrowserLib;

namespace AsssemblyBrowser.Model
{
    class AssemblyBrowserModel
    {
        public List<NamespaceInfosModel> GetAssemblyInfos(string path)
        {
            var asm = new AssemblyBrowser();
            var converter = new Converter();

            return converter.Convert(asm.GetNamespaceInfos(path));
        }
    }
}
