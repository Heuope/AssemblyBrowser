using System.Collections.ObjectModel;
using System.Windows;
using AsssemblyBrowser.ViewModel;

namespace AsssemblyBrowser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //var data = new DataViewModel(@"C:\Users\konst_9hggwum\OneDrive\Desktop\AssemblyBrowser\TestClass\bin\Debug\netcoreapp3.1\TestClass.dll");

            //treeView.ItemsSource = data.NamespaceInfos;
        }
    }
}
