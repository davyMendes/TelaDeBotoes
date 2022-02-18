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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TELA_DE_OPções
{
    public partial class TextBoxPadrao : UserControl
    {

        public static readonly DependencyProperty TextoPrincipalProperty = DependencyProperty.Register("Titulo", typeof(string), typeof(TextBoxPadrao), new UIPropertyMetadata(null));

        public static readonly DependencyProperty CorPrimariaProperty = DependencyProperty.Register("CorPrincipal", typeof(SolidColorBrush), typeof(TextBoxPadrao), new UIPropertyMetadata(null));

        public static readonly DependencyProperty CorSecundariaProperty = DependencyProperty.Register("CorSecundaria", typeof(SolidColorBrush), typeof(TextBoxPadrao), new UIPropertyMetadata(null));

        public string Titulo { get; set; }
        public SolidColorBrush CorPrincipal { get; set; }
        public SolidColorBrush CorSecundaria { get; set; }
        public bool estahLivre { get => String.IsNullOrWhiteSpace(tbText.Text); }

        private Storyboard AnimacaoAtiva;
        private Storyboard AnimacaoDesativa;

        public TextBoxPadrao()
        {          
            InitializeComponent();
            AdicionarAnimacaoAtiva();
            AdicionarAnimacaoDesativa();
        }      
        private void tbText_GotFocus(object sender, RoutedEventArgs e)
        {
            AnimacaoAtiva.Begin(lbTitulo);
        }
        private void tbText_LostFocus(object sender, RoutedEventArgs e)
        {
            if (estahLivre)
                AnimacaoDesativa.Begin(lbTitulo);
        }

        private void AdicionarAnimacaoAtiva()
        {
            var duracao = new Duration(TimeSpan.FromMilliseconds(300));

            ThicknessAnimation animacaoReposiciona = new ThicknessAnimation()
            {
                Duration = duracao,
                To = new Thickness(5, -8, 0, 0)
            };

            Storyboard.SetTargetName(animacaoReposiciona, "lbTitulo");
            Storyboard.SetTargetProperty(animacaoReposiciona, new PropertyPath(TextBlock.MarginProperty));


            DoubleAnimation animationAumentaTamanho1 = new DoubleAnimation()
            {
                Duration = duracao,
                To = 10
            };
            Storyboard.SetTargetName(animationAumentaTamanho1, "lbTitulo");
            Storyboard.SetTargetProperty(animationAumentaTamanho1, new PropertyPath(TextBlock.FontSizeProperty));


            DoubleAnimation animationAumentaTamanho2 = new DoubleAnimation()
            {
                Duration = duracao,
                To = 1
            };
            Storyboard.SetTargetName(animationAumentaTamanho2, "lbTitulo");
            Storyboard.SetTargetProperty(animationAumentaTamanho2, new PropertyPath(TextBlock.OpacityProperty));

            ColorAnimation animacaoCor = new ColorAnimation()
            {
                Duration = duracao,
                To = Color.FromRgb(2, 117, 216)
            };

            Storyboard.SetTargetName(animacaoCor, "lbTitulo");
            Storyboard.SetTargetProperty(animacaoCor, new PropertyPath("(0).(1)", TextBlock.ForegroundProperty, SolidColorBrush.ColorProperty));

            ColorAnimation animacaoCor2 = new ColorAnimation()
            {
                Duration = duracao,
                To = Color.FromRgb(2, 117, 216)
            };

            Storyboard.SetTargetName(animacaoCor2, "bdText");
            Storyboard.SetTargetProperty(animacaoCor2, new PropertyPath("(0).(1)", Border.BorderBrushProperty, SolidColorBrush.ColorProperty));


            AnimacaoAtiva = new Storyboard();

            AnimacaoAtiva.Children.Clear();
            AnimacaoAtiva.Children.Add(animacaoReposiciona);
            AnimacaoAtiva.Children.Add(animationAumentaTamanho1);
            AnimacaoAtiva.Children.Add(animationAumentaTamanho2);
            AnimacaoAtiva.Children.Add(animacaoCor);
            AnimacaoAtiva.Children.Add(animacaoCor2);
        }
        private void AdicionarAnimacaoDesativa()
        {
            var duracao = new Duration(TimeSpan.FromMilliseconds(300));

            ThicknessAnimation animacaoReposiciona = new ThicknessAnimation()
            {
                Duration = duracao,
                To = new Thickness(5, 0, 0, 0)
            };

            Storyboard.SetTargetName(animacaoReposiciona, "lbTitulo");
            Storyboard.SetTargetProperty(animacaoReposiciona, new PropertyPath(TextBlock.MarginProperty));

            DoubleAnimation animationAumentaTamanho1 = new DoubleAnimation()
            {
                Duration = duracao,
                To = 18
            };
            Storyboard.SetTargetName(animationAumentaTamanho1, "lbTitulo");
            Storyboard.SetTargetProperty(animationAumentaTamanho1, new PropertyPath(TextBlock.FontSizeProperty));


            DoubleAnimation animationAumentaTamanho2 = new DoubleAnimation()
            {
                Duration = duracao,
                To = 0.5
            };
            Storyboard.SetTargetName(animationAumentaTamanho2, "lbTitulo");
            Storyboard.SetTargetProperty(animationAumentaTamanho2, new PropertyPath(TextBlock.OpacityProperty));

            ColorAnimation animacaoCor = new ColorAnimation()
            {
                Duration = duracao,
                To = Colors.DimGray
            };

            Storyboard.SetTargetName(animacaoCor, "lbTitulo");
            Storyboard.SetTargetProperty(animacaoCor, new PropertyPath("(0).(1)", TextBlock.ForegroundProperty, SolidColorBrush.ColorProperty));

            ColorAnimation animacaoCor2 = new ColorAnimation()
            {
                Duration = duracao,
                To = Colors.DimGray
            };

            Storyboard.SetTargetName(animacaoCor2, "bdText");
            Storyboard.SetTargetProperty(animacaoCor2, new PropertyPath("(0).(1)", Border.BorderBrushProperty, SolidColorBrush.ColorProperty));

            AnimacaoDesativa = new Storyboard();

            AnimacaoDesativa.Children.Clear();
            AnimacaoDesativa.Children.Add(animacaoReposiciona);
            AnimacaoDesativa.Children.Add(animationAumentaTamanho1);
            AnimacaoDesativa.Children.Add(animationAumentaTamanho2);
            AnimacaoDesativa.Children.Add(animacaoCor);
            AnimacaoDesativa.Children.Add(animacaoCor2);
        }    
    }
}
