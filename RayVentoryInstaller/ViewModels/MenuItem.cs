using System;
using System.Windows;
using MahApps.Metro.Controls;

namespace RayVentoryInstaller.ViewModels
{
    class MenuItem : HamburgerMenuIconItem
    {
        public static readonly DependencyProperty NavigationsDestinationsProperty = DependencyProperty.Register(
            nameof(NavigationDestination), typeof(Uri), typeof(MenuItem), new PropertyMetadata(default(Uri)));

        public Uri NavigationDestination
        {
            get => (Uri)this.GetValue(NavigationsDestinationsProperty);
            set => this.SetValue(NavigationsDestinationsProperty, value);
        }

        public static readonly DependencyProperty NavigationTypeProperty = DependencyProperty.Register(
            nameof(NavigationType), typeof(Type), typeof(MenuItem), new PropertyMetadata(default(Type)));

        public Type NavigationType
        {
            get => (Type)this.GetValue(NavigationTypeProperty);
            set => this.SetValue(NavigationTypeProperty, value);
        }

        public bool IsNavigation => this.NavigationDestination != null;
    }
}
