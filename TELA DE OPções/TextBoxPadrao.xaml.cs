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
        public string Titulo { get; set; }
        public static readonly DependencyProperty TextoPrincipalProperty = DependencyProperty.Register("Titulo", typeof(string), typeof(TextBoxPadrao), new UIPropertyMetadata(null));
        public bool CampoObrigatorio { get; set; }
        private bool _obrigatorio;
        public static readonly DependencyProperty CampoObrigatorioProperty = DependencyProperty.Register("CampoObrigatorio", typeof(bool), typeof(TextBoxPadrao), new UIPropertyMetadata(null));
        private bool estahLivre { get => String.IsNullOrWhiteSpace(tbText.Text); }
        private static Duration _duracaoAnimacao = new Duration(TimeSpan.FromMilliseconds(200));

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
            {
                AnimacaoDesativa.Begin(lbTitulo);
                if (_obrigatorio)
                {
                    lbTitulo.Foreground = Brushes.Red;
                    bdText.BorderBrush = Brushes.Red;
                    lbAviso.Visibility = Visibility.Visible;
                }
            }
            else
                lbAviso.Visibility = Visibility.Collapsed;
        }

        private void AdicionarAnimacaoAtiva()
        {

            ThicknessAnimation animacaoReposiciona = new ThicknessAnimation()
            {
                Duration = _duracaoAnimacao,
                To = new Thickness(5, -8, 0, 0)
            };

            Storyboard.SetTargetName(animacaoReposiciona, "lbTitulo");
            Storyboard.SetTargetProperty(animacaoReposiciona, new PropertyPath(TextBlock.MarginProperty));


            DoubleAnimation animationAumentaTamanho1 = new DoubleAnimation()
            {
                Duration = _duracaoAnimacao,
                To = 12
            };
            Storyboard.SetTargetName(animationAumentaTamanho1, "lbTitulo");
            Storyboard.SetTargetProperty(animationAumentaTamanho1, new PropertyPath(TextBlock.FontSizeProperty));


            DoubleAnimation animationAumentaTamanho2 = new DoubleAnimation()
            {
                Duration = _duracaoAnimacao,
                To = 1
            };
            Storyboard.SetTargetName(animationAumentaTamanho2, "lbTitulo");
            Storyboard.SetTargetProperty(animationAumentaTamanho2, new PropertyPath(TextBlock.OpacityProperty));

            ColorAnimation animacaoCor = new ColorAnimation()
            {
                Duration = _duracaoAnimacao,
                To = Color.FromRgb(2, 117, 216)
            };

            Storyboard.SetTargetName(animacaoCor, "lbTitulo");
            Storyboard.SetTargetProperty(animacaoCor, new PropertyPath("(0).(1)", TextBlock.ForegroundProperty, SolidColorBrush.ColorProperty));

            ColorAnimation animacaoCor2 = new ColorAnimation()
            {
                Duration = _duracaoAnimacao,
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
            ThicknessAnimation animacaoReposiciona = new ThicknessAnimation()
            {
                Duration = _duracaoAnimacao,
                To = new Thickness(5, 0, 0, 0)
            };

            Storyboard.SetTargetName(animacaoReposiciona, "lbTitulo");
            Storyboard.SetTargetProperty(animacaoReposiciona, new PropertyPath(TextBlock.MarginProperty));

            DoubleAnimation animationAumentaTamanho1 = new DoubleAnimation()
            {
                Duration = _duracaoAnimacao,
                To = 18
            };
            Storyboard.SetTargetName(animationAumentaTamanho1, "lbTitulo");
            Storyboard.SetTargetProperty(animationAumentaTamanho1, new PropertyPath(TextBlock.FontSizeProperty));


            DoubleAnimation animationAumentaTamanho2 = new DoubleAnimation()
            {
                Duration = _duracaoAnimacao,
                To = 0.5
            };
            Storyboard.SetTargetName(animationAumentaTamanho2, "lbTitulo");
            Storyboard.SetTargetProperty(animationAumentaTamanho2, new PropertyPath(TextBlock.OpacityProperty));

            ColorAnimation animacaoCor = new ColorAnimation()
            {
                Duration = _duracaoAnimacao,
                To = Colors.DimGray
            };

            Storyboard.SetTargetName(animacaoCor, "lbTitulo");
            Storyboard.SetTargetProperty(animacaoCor, new PropertyPath("(0).(1)", TextBlock.ForegroundProperty, SolidColorBrush.ColorProperty));

            ColorAnimation animacaoCor2 = new ColorAnimation()
            {
                Duration = _duracaoAnimacao,
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

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            _obrigatorio = lbAviso.Visibility == Visibility.Visible;
        }
    }
}
