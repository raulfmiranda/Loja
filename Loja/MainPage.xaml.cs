using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.SpeechSynthesis;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x416

namespace Loja
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Produto> produtos;
        private Info info;
        private bool iniciou;
        private MediaElement media;

        public MainPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Enabled;
            this.produtos = initProds();
            InitValuePage(produtos);
            info = new Info();
            info.Produtos = this.produtos;
            media = new MediaElement();
            this.iniciou = false;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (this.iniciou && e.Parameter != null)
            {
                this.info = (Info)e.Parameter;
                this.produtos = info.Produtos;
                InitValuePage(this.produtos);
            }
            this.iniciou = true;
        }

        private async void Falar(int prodId)
        {
            // The media object for controlling and playing audio.
            MediaElement mediaElement = this.media;

            // The object for controlling the speech synthesis engine (voice).
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();

            // Generate the audio stream from plain text.
            SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync(this.produtos[prodId].Nome);

            // Send the stream to the media object.
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();
        }

        private void InitValuePage(List<Produto> prods)
        {
            // Setando valores para produto 1
            imgProd1.Source = ImgSource(prods[0].ImgSource);
            tbProd1.Text = prods[0].Nome;
            tbValorProd1.Text = string.Format(CultureInfo.CurrentCulture, "{0:C}", prods[0].Valor);

            // Setando valores para produto 2
            imgProd2.Source = ImgSource(prods[1].ImgSource);
            tbProd2.Text = prods[1].Nome;
            tbValorProd2.Text = string.Format(CultureInfo.CurrentCulture, "{0:C}", prods[1].Valor);

            // Setando valores para produto 3
            imgProd3.Source = ImgSource(prods[2].ImgSource);
            tbProd3.Text = prods[2].Nome;
            tbValorProd3.Text = string.Format(CultureInfo.CurrentCulture, "{0:C}", prods[2].Valor);

            // Setando valores para produto 4
            imgProd4.Source = ImgSource(prods[3].ImgSource);
            tbProd4.Text = prods[3].Nome;
            tbValorProd4.Text = string.Format(CultureInfo.CurrentCulture, "{0:C}", prods[3].Valor);

            // Setando valores para produto 5
            imgProd5.Source = ImgSource(prods[4].ImgSource);
            tbProd5.Text = prods[4].Nome;
            tbValorProd5.Text = string.Format(CultureInfo.CurrentCulture, "{0:C}", prods[4].Valor);

            // Setando valores para produto 6
            imgProd6.Source = ImgSource(prods[5].ImgSource);
            tbProd6.Text = prods[5].Nome;
            tbValorProd6.Text = string.Format(CultureInfo.CurrentCulture, "{0:C}", prods[5].Valor);
        }

        private BitmapImage ImgSource(string imgSrc)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.UriSource = new Uri(imgSrc, UriKind.RelativeOrAbsolute);
            return bitmap;
        }

        private List<Produto> initProds()
        {
            List<Produto> prods = new List<Produto>();

            Produto p1 = new Produto("Coelho Azul", 80, "Coelho de pelúcia azul. Brinquedo para cachorros.", "ms-appx:/Assets/coelho-de-pelucia-brinquedo-para-caes-sao-pet-azul.jpg");
            Produto p2 = new Produto("Girafa", 85, "Girafa de pelúcia. Brinquedo para cachorros.", "ms-appx:/Assets/girafa-de-pelucia-brinquedo-para-cachorro-sao-pet.jpg");
            Produto p3 = new Produto("Patinho", 70, "Patinho de pelúcia. Brinquedo para cachorros.", "ms-appx:/Assets/patinho-de-pelucia-para-cachorro-americanpets-soft.jpg");
            Produto p4 = new Produto("Polvo", 97, "Polvo de pelúcia. Brinquedo para cachorros.", "ms-appx:/Assets/polvo-de-pelucia-brinquedo-de-cachorro-sao-pet.jpg");
            Produto p5 = new Produto("Tigre", 110, "Tigre de pelúcia. Brinquedo para cachorros.", "ms-appx:/Assets/tigre-de-pelucia-brinquedo-de-cachorro-saopet.jpg");
            Produto p6 = new Produto("Vaca", 73, "Vaca de pelúcia. Brinquedo para cachorros.", "ms-appx:/Assets/vaca-de-pelucia-brinquedo-de-cachorro-saopet.jpg");

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
            info.ProdAtual = 0;
            this.Frame.Navigate(typeof(Detalhamento), info);
        }
        private void linkProd2_Click(object sender, RoutedEventArgs e)
        {
            info.ProdAtual = 1;
            this.Frame.Navigate(typeof(Detalhamento), info);
        }
        private void linkProd3_Click(object sender, RoutedEventArgs e)
        {
            info.ProdAtual = 2;
            this.Frame.Navigate(typeof(Detalhamento), info);
        }
        private void linkProd4_Click(object sender, RoutedEventArgs e)
        {
            info.ProdAtual = 3;
            this.Frame.Navigate(typeof(Detalhamento), info);
        }
        private void linkProd5_Click(object sender, RoutedEventArgs e)
        {
            info.ProdAtual = 4;
            this.Frame.Navigate(typeof(Detalhamento), info);
        }
        private void linkProd6_Click(object sender, RoutedEventArgs e)
        {
            info.ProdAtual = 5;
            this.Frame.Navigate(typeof(Detalhamento), info);
        }

        private void linkImg1_Click(object sender, RoutedEventArgs e)
        {
            Falar(0);
        }
        private void linkImg2_Click(object sender, RoutedEventArgs e)
        {
            Falar(1);
        }
        private void linkImg3_Click(object sender, RoutedEventArgs e)
        {
            Falar(2);
        }
        private void linkImg4_Click(object sender, RoutedEventArgs e)
        {
            Falar(3);
        }
        private void linkImg5_Click(object sender, RoutedEventArgs e)
        {
            Falar(4);
        }
        private void linkImg6_Click(object sender, RoutedEventArgs e)
        {
            Falar(5);
        }
    }
}
