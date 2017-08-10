using System;
using System.Collections.Generic;
using System.Globalization;
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

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=234238

namespace Loja
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class Detalhamento : Page
    {
        private List<Produto> produtos;
        private Info info;

        public Detalhamento()
        {
            this.InitializeComponent();
            produtos = new List<Produto>();
            info = new Info();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if(e.Parameter != null)
            {
                Info info = (Info)e.Parameter;
                rootPivot.SelectedIndex = info.ProdAtual;
                this.produtos = info.Produtos;
                InitValuePage(this.produtos);
            }
        }

        private void InitValuePage(List<Produto> prods)
        {
            // Setando valores para produto 1
            pvProd1.Header = prods[0].Nome;
            tbDescProd1.Text = prods[0].Descricao;
            tbValorProd1.Text = string.Format(CultureInfo.CurrentCulture, "{0:C}", prods[0].Valor);

            // Setando valores para produto 2
            pvProd2.Header = prods[1].Nome;
            tbDescProd2.Text = prods[1].Descricao;
            tbValorProd2.Text = string.Format(CultureInfo.CurrentCulture, "{0:C}", prods[1].Valor);

            // Setando valores para produto 3
            pvProd3.Header = prods[2].Nome;
            tbDescProd3.Text = prods[2].Descricao;
            tbValorProd3.Text = string.Format(CultureInfo.CurrentCulture, "{0:C}", prods[2].Valor);

            // Setando valores para produto 4
            pvProd4.Header = prods[3].Nome;
            tbDescProd4.Text = prods[3].Descricao;
            tbValorProd4.Text = string.Format(CultureInfo.CurrentCulture, "{0:C}", prods[3].Valor);

            // Setando valores para produto 5
            pvProd5.Header = prods[4].Nome;
            tbDescProd5.Text = prods[4].Descricao;
            tbValorProd5.Text = string.Format(CultureInfo.CurrentCulture, "{0:C}", prods[4].Valor);

            // Setando valores para produto 6
            pvProd6.Header = prods[5].Nome;
            tbDescProd6.Text = prods[5].Descricao;
            tbValorProd6.Text = string.Format(CultureInfo.CurrentCulture, "{0:C}", prods[5].Valor);
        }

        private void btVoltar_Click(object sender, RoutedEventArgs e)
        {
            this.info.Produtos = this.produtos;
            this.Frame.Navigate(typeof(MainPage), info);
        }

        private void btEditar1_Click(object sender, RoutedEventArgs e)
        {
            this.info.ProdAtual = 0;
            this.info.Produtos = this.produtos;
            this.Frame.Navigate(typeof(EditarPage), info);
        }

        private void btEditar2_Click(object sender, RoutedEventArgs e)
        {
            this.info.ProdAtual = 1;
            this.info.Produtos = this.produtos;
            this.Frame.Navigate(typeof(EditarPage), info);
        }

        private void btEditar3_Click(object sender, RoutedEventArgs e)
        {
            this.info.ProdAtual = 2;
            this.info.Produtos = this.produtos;
            this.Frame.Navigate(typeof(EditarPage), info);
        }

        private void btEditar4_Click(object sender, RoutedEventArgs e)
        {
            this.info.ProdAtual = 3;
            this.info.Produtos = this.produtos;
            this.Frame.Navigate(typeof(EditarPage), info);
        }

        private void btEditar5_Click(object sender, RoutedEventArgs e)
        {
            this.info.ProdAtual = 4;
            this.info.Produtos = this.produtos;
            this.Frame.Navigate(typeof(EditarPage), info);
        }

        private void btEditar6_Click(object sender, RoutedEventArgs e)
        {
            this.info.ProdAtual = 5;
            this.info.Produtos = this.produtos;
            this.Frame.Navigate(typeof(EditarPage), info);
        }
    }
}
