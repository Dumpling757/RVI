using System;
using System.Collections.ObjectModel;

using RayVentoryInstaller.Views;

namespace RayVentoryInstaller.ViewModels
{
    public class ShellViewModel //: BindableBase
    {
        private static readonly ObservableCollection<MenuItem> AppMenu = new ObservableCollection<MenuItem>();
        private static readonly ObservableCollection<MenuItem> AppOptionsMenu = new ObservableCollection<MenuItem>();

        // public ObservableCollection<MenuItem> Menu => AppMenu;

        // public ObservableCollection<MenuItem> OptionsMenu => AppOptionsMenu;
        /*
        public ShellViewModel()
        {
            // Build the menus
            this.Menu.Add(new MenuItem()
            {

                Label = "General",
                NavigationType = typeof(GeneralPage),
                NavigationDestination = new Uri("Views/GeneralPage.xaml", UriKind.RelativeOrAbsolute)
            });
            this.Menu.Add(new MenuItem()
            {
                
                Label = "ScanEngine",
                NavigationType = typeof(ScanEnginePage),
                NavigationDestination = new Uri("Views/ScanEnginePage.xaml", UriKind.RelativeOrAbsolute)
            });
            this.Menu.Add(new MenuItem()
            {
                
                Label = "Server",
                NavigationType = typeof(ServerPage),
                NavigationDestination = new Uri("Views/ServerPage.xaml", UriKind.RelativeOrAbsolute)
            });
            this.Menu.Add(new MenuItem()
            {
                
                Label = "DataHub",
                NavigationType = typeof(DataHubPage),
                NavigationDestination = new Uri("Views/DataHubPage.xaml", UriKind.RelativeOrAbsolute)
            });


            this.OptionsMenu.Add(new MenuItem()
            {
                
                Label = "Advanced",
                NavigationType = typeof(AdvancedPage),
                NavigationDestination = new Uri("Views/AdvancedPage.xaml", UriKind.RelativeOrAbsolute)
            });

        }
        */
    }

}
