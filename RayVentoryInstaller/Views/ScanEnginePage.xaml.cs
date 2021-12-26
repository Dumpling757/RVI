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
using RayVentoryInstaller.Resources;



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

                tb_MsiFile.Text = IOHandler.BrowseForFile("Scan Engine Installer (*.msi) | *.msi", null);

        }

        private void b_browseRSL_Click(object sender, RoutedEventArgs e)
        {

                tb_LicFile.Text = IOHandler.BrowseForFile("Scan Engine License File (*.rsl) | *.rsl", null);

        }
    }
}
