using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;



namespace RayVentoryInstaller.Views
{
    /// <summary>
    /// Interaction logic for ScanEngine.xaml
    /// </summary>
    public partial class ScanEngine : Page
    {
        public ScanEngine()
        {
            InitializeComponent();
        }

        private void b_BrowseMsi_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Scan Engine Installer (*.msi)";
            tb_MsiFile.Text = openFileDialog.FileName;

        }

        private void b_browseRSL_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Scan Engine License File (*.rsl)";
            tb_LicFile.Text = openFileDialog.FileName;

        }
    }
}
