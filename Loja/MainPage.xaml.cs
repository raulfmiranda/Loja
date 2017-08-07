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
            List<Produto> produtos = initProds();
        }

        private List<Produto> initProds()
        {
            List<Produto> prods = new List<Produto>();

            Produto p1 = new Produto("Coelho Azul", 80, "Coelho de pelúcia azul. Brinquedo para cachorros.", "Assets/coelho-de-pelucia-brinquedo-para-caes-sao-pet-azul.jpg");
            Produto p2 = new Produto("Girafa", 85, "Girafa de pelúcia. Brinquedo para cachorros.", "Assets/girafa-de-pelucia-brinquedo-para-cachorro-sao-pet.jpg");
            Produto p3 = new Produto("Patinho", 70, "Patinho de pelúcia. Brinquedo para cachorros.", "Assets/patinho-de-pelucia-para-cachorro-americanpets-soft.jpg");
            Produto p4 = new Produto("Polvo", 97, "Polvo de pelúcia. Brinquedo para cachorros.", "Assets/polvo-de-pelucia-brinquedo-de-cachorro-sao-pet.jpg");
            Produto p5 = new Produto("Tigre", 110, "Tigre de pelúcia. Brinquedo para cachorros.", "Assets/tigre-de-pelucia-brinquedo-de-cachorro-saopet.jpg");
            Produto p6 = new Produto("Vaca", 73, "Vaca de pelúcia. Brinquedo para cachorros.", "Assets/vaca-de-pelucia-brinquedo-de-cachorro-saopet.jpg");

            prods.Add(p1);
            prods.Add(p2);
            prods.Add(p3);
            prods.Add(p4);
            prods.Add(p5);
            prods.Add(p6);

            return prods;
        }

        private void linkProd1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Detalhamento), 0);
        }
        private void linkProd2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Detalhamento), 1);
        }
        private void linkProd3_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Detalhamento), 2);
        }
        private void linkProd4_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Detalhamento), 3);
        }
        private void linkProd5_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Detalhamento), 4);
        }
        private void linkProd6_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Detalhamento), 5);
        }
    }
}
