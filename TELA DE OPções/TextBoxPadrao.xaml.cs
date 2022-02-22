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
        public static readonly DependencyProperty TituloProperty = DependencyProperty.Register("Titulo", typeof(string), typeof(TextBoxPadrao), new UIPropertyMetadata(null));
        public string Texto { get; set; }
        public static readonly DependencyProperty TextoProperty = DependencyProperty.Register("Texto", typeof(string), typeof(TextBoxPadrao), new UIPropertyMetadata(null));
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
            AdicionarAnimacoes();
        }

        #region Eventos
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            _obrigatorio = lbAviso.Visibility == Visibility.Visible;
            if (estahLivre) return;
            AnimacaoAtiva.Begin(lbTitulo);
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
        #endregion Eventos

        #region Metodos Privados

        private void AdicionarAnimacoes()
        {
            AdicionarEventosDasAnimacoes(ref AnimacaoAtiva, true);
            AdicionarEventosDasAnimacoes(ref AnimacaoDesativa, false);
        }

        private void AdicionarEventosDasAnimacoes(ref Storyboard storyboard, bool ativa)
        {
            storyboard = new Storyboard();
            storyboard.Children.Clear();
            storyboard.Children.Add(AnimacaoDaPosicaoDoTitulo(ativa));
            storyboard.Children.Add(AnimacaoDoTamanhoDoTitulo(ativa));
            storyboard.Children.Add(AnimacaoDoOpacidadeDoTitulo(ativa));
            storyboard.Children.Add(AnimacaoDoCorDoTitulo(ativa));
            storyboard.Children.Add(AnimacaoDoCorDaBorda(ativa));
        }

        private Timeline AnimacaoDaPosicaoDoTitulo(bool ativo)
        {
            ThicknessAnimation animacao = new ThicknessAnimation()
            {
                Duration = _duracaoAnimacao,
                To = ativo ? new Thickness(5, -8, 0, 0) : new Thickness(5, 0, 0, 0)
            };

            Storyboard.SetTargetName(animacao, "lbTitulo");
            Storyboard.SetTargetProperty(animacao, new PropertyPath(TextBlock.MarginProperty));
            return animacao;
        }
        private Timeline AnimacaoDoTamanhoDoTitulo(bool ativo)
        {
            DoubleAnimation animacao = new DoubleAnimation()
            {
                Duration = _duracaoAnimacao,
                To = ativo ? 12 : 18
            };
            Storyboard.SetTargetName(animacao, "lbTitulo");
            Storyboard.SetTargetProperty(animacao, new PropertyPath(TextBlock.FontSizeProperty));
            return animacao;
        }
        private Timeline AnimacaoDoOpacidadeDoTitulo(bool ativo)
        {
            DoubleAnimation animacao = new DoubleAnimation()
            {
                Duration = _duracaoAnimacao,
                To = ativo ? 1 : 0.5
            };
            Storyboard.SetTargetName(animacao, "lbTitulo");
            Storyboard.SetTargetProperty(animacao, new PropertyPath(TextBlock.OpacityProperty));
            return animacao;
        }
        private Timeline AnimacaoDoCorDoTitulo(bool ativo)
        {
            ColorAnimation animacao = new ColorAnimation()
            {
                Duration = _duracaoAnimacao,
                To = ativo ? Color.FromRgb(2, 117, 216) : Colors.DimGray
            };

            Storyboard.SetTargetName(animacao, "lbTitulo");
            Storyboard.SetTargetProperty(animacao, new PropertyPath("(0).(1)", TextBlock.ForegroundProperty, SolidColorBrush.ColorProperty));
            return animacao;
        }
        private Timeline AnimacaoDoCorDaBorda(bool ativo)
        {
            ColorAnimation animacao = new ColorAnimation()
            {
                Duration = _duracaoAnimacao,
                To = ativo ? Color.FromRgb(2, 117, 216) : Colors.DimGray
            };

            Storyboard.SetTargetName(animacao, "bdText");
            Storyboard.SetTargetProperty(animacao, new PropertyPath("(0).(1)", Border.BorderBrushProperty, SolidColorBrush.ColorProperty));
            return animacao;
        }

        #endregion Metodos Privados
    }
}
