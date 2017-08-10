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

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=234238

namespace Loja
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class EditarPage : Page
    {
        private List<Produto> produtos;
        private Info info;

        public EditarPage()
        {
            this.InitializeComponent();
            this.info = new Info();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter != null)
            {
                this.info = (Info)e.Parameter;
                this.produtos = info.Produtos;
                InitValuePage(this.produtos[info.ProdAtual]);
            }
        }

        private void InitValuePage(Produto produto)
        {
            this.tboxNome.Text = produto.Nome;
            this.tboxValor.Text = produto.Valor.ToString();
            this.tboxDesc.Text = produto.Descricao;
        }

        private void btCadastrar_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(this.tboxNome.Text) && 
                !string.IsNullOrWhiteSpace(this.tboxValor.Text) &&
                !string.IsNullOrWhiteSpace(this.tboxDesc.Text))
            {
                this.produtos[this.info.ProdAtual].Nome = this.tboxNome.Text;
                this.produtos[this.info.ProdAtual].Valor = decimal.Parse(this.tboxValor.Text);
                this.produtos[this.info.ProdAtual].Descricao = this.tboxDesc.Text;
                this.info.Produtos = this.produtos;
                this.tbErroMsg.Text = "";

                this.Frame.Navigate(typeof(Detalhamento), info);
            }
            else
            {
                this.tbErroMsg.Text = "Preencha todos os campos.";
            }            
        }

        private void btCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Detalhamento), info);
        }
    }
}
