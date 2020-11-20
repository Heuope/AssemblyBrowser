using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using AssemblyBrowserLib;
using AsssemblyBrowser.Model;
using Microsoft.Win32;

namespace AsssemblyBrowser.ViewModel
{
    class DataViewModel : INotifyPropertyChanged
    {
        private List<NamespaceInfosModel> _namespaceInfos;
        private OpenFile _openCommand;
        private string _path;

        public List<NamespaceInfosModel> NamespaceInfos 
        { 
            get 
            {
                return _namespaceInfos;
            } 
            set
            {
                _namespaceInfos = value;
                OnPropertyChanged();
            }
        }

        public OpenFile OpenCommand
        {

            get
            {
                var openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = ".Net assembly files (*.exe, *.dll) |*.exe;*.dll";
                return _openCommand ??
                  (_openCommand = new OpenFile(obj =>
                  {
                      openFileDialog.ShowDialog();
                      Path = openFileDialog.FileName;
                  }));
            }
        }

        public string Path
        {
            get { return _path; }
            set
            {
                _path = value;
                NamespaceInfos = new AssemblyBrowserModel().GetAssemblyInfos(_path);
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
