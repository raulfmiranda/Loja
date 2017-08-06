using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x416

namespace Loja
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Enabled;
        }

        private void linkProd1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Detalhamento));
        }
        private void linkProd2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Detalhamento));
        }
        private void linkProd3_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Detalhamento));
        }
        private void linkProd4_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Detalhamento));
        }
        private void linkProd5_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Detalhamento));
        }
        private void linkProd6_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Detalhamento));
        }
    }
}
