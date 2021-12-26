using System;
using Microsoft.Win32;

namespace RayVentoryInstaller.Resources
{
    static class IOHandler
    {

        public static string BrowseForFile(string filterString, string? initialDirectory)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = filterString;
            if(initialDirectory != null)
            {
                openFileDialog.InitialDirectory = initialDirectory;
            }
            else
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }
            
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == true)
            {
                return openFileDialog.FileName;
            }
            else
                return null;
        }

    }
}
