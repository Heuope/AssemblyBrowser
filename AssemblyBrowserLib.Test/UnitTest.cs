using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;

namespace AssemblyBrowserLib.Test
{
    [TestClass]
    public class UnitTest
    {
        public List<int> A;

        [TestMethod]
        public void NamespaceNameTest()
        {
            string expected = "Namespace : TestClass";

            string path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\"));
            path += @"\TestClass\bin\Debug\netcoreapp3.1\TestClass.dll";

            var asm = new AssemblyBrowser().GetNamespaceInfos(path);

            Console.WriteLine(path);

            string actual = asm[0].Name;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TypeNameTest()
        {
            string expected = "Bar";

            string path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\"));
            path += @"\TestClass\bin\Debug\netcoreapp3.1\TestClass.dll";

            var asm = new AssemblyBrowser().GetNamespaceInfos(path);

            string actual = asm[0].typeInfos[0].Name;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MethodNameTest()
        {
            string expected = "Method : Void DoSomething ()";

            string path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\"));
            path += @"\TestClass\bin\Debug\netcoreapp3.1\TestClass.dll";

            var asm = new AssemblyBrowser().GetNamespaceInfos(path);

            string actual = asm[0].typeInfos[0].MethodsInfos[2].Name;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FieldNameTest()
        {
            string expected = "Field : String s";

            string path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\"));
            path += @"\TestClass\bin\Debug\netcoreapp3.1\TestClass.dll";

            var asm = new AssemblyBrowser().GetNamespaceInfos(path);

            string actual = asm[0].typeInfos[1].FieldsInfos[0].Name;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PropertyNameTest()
        {
            string expected = "Property : List<Foo> Foos";

            string path = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\"));
            path += @"\TestClass\bin\Debug\netcoreapp3.1\TestClass.dll";

            var asm = new AssemblyBrowser().GetNamespaceInfos(path);

            string actual = asm[0].typeInfos[0].PropertyInfos[0].Name;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BadFilePathTest()
        {
            string path = "";
            var asm = new AssemblyBrowser().GetNamespaceInfos(path);

            Assert.AreEqual(0, asm.Count);
        }
    }
}
