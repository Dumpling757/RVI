using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using ControlzEx.Theming;
using MenuItem = RayVentoryInstaller.ViewModels.MenuItem;

namespace RayVentoryInstaller
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private const char empty = '\0';
        private readonly Navigation.NavigationServiceEx navigationServiceEx;
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            /*
            this.navigationServiceEx = new Navigation.NavigationServiceEx();
            this.navigationServiceEx.Navigated += this.NavigationServiceEx_OnNavigated;
            // this.HamburgerMenuControl.Content = this.navigationServiceEx.Frame;

            this.Loaded += (sender, args) => this.navigationServiceEx.Navigate(new Uri("Views/Generalpage.xml"));
            */
        }

        /*   private void hmMenu_ItemInvoked(object sender, HamburgerMenuItemInvokedEventArgs e)
           {
               this.HamburgerMenuControl.Content = e.InvokedItem;

           }
           private void HamburgerMenuControl_OnItemInvoked(object sender, HamburgerMenuItemInvokedEventArgs e)
           {
               if (e.InvokedItem is MenuItem menuItem && menuItem.IsNavigation)
               {
                   this.navigationServiceEx.Navigate(menuItem.NavigationDestination);
               }
           }

           private void NavigationServiceEx_OnNavigated(object sender, NavigationEventArgs e)
           {
               // select the menu item
               this.HamburgerMenuControl.SelectedItem = this.HamburgerMenuControl
                                                            .Items
                                                            .OfType<MenuItem>()
                                                            .FirstOrDefault(x => x.NavigationDestination == e.Uri);
               this.HamburgerMenuControl.SelectedOptionsItem = this.HamburgerMenuControl
                                                                   .OptionsItems
                                                                   .OfType<MenuItem>()
                                                                   .FirstOrDefault(x => x.NavigationDestination == e.Uri);
           }
        */
        /*
        private void NavigationServiceEx_OnNavigated(object sender, NavigationEventArgs e)
        {

        }
        */
        private void b_Navigation_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            string buttonContent = (string)button.Content;
            if (buttonContent == "Scan Engine")
                buttonContent = "ScanEngine";
            //UriBuilder uriBuilder = new UriBuilder("Views", button.Content + "Page.xml");
            string uristring = $"Views/{buttonContent}Page.xaml";
            // Uri uri = uriBuilder.Uri;
            Uri uri = new System.Uri(uristring, UriKind.Relative);

                this.MainFrame.Navigate(uri, (this.MainFrame));            
        }
    }
}
