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

        private string texto { get; set; }
        //public bool estahLivre { get => String.IsNullOrWhiteSpace(this.texto);}
        public bool estahLivre { get => true;}

        private Storyboard StoryBoardAtivando;
        private Storyboard StoryBoardDesativando;

        public TextBoxPadrao()
        {
            texto = "";
            InitializeComponent();
        }
        private void tbText_TextChanged(object sender, TextChangedEventArgs e)
        {
            texto = ((TextBox)sender).Text.Trim();
        }

        private void tbText_LostFocus(object sender, RoutedEventArgs e)
        {
            AnimacaoQuandoDaFocoNaTextBox();

            //StoryBoardAtivando.Begin();
        }

        private void AnimacaoQuandoDaFocoNaTextBox()
        {
            //var animacao = new ColorAnimation()
            //{
            //    Duration = new Duration(TimeSpan.FromSeconds(5)),
            //    To = System.Windows.Media.Color.FromRgb(255, 255, 255), 
            //};
            //StoryBoardAtivando = new Storyboard();
            //StoryBoardAtivando.Children.Add(animacao);
            //Storyboard.SetTargetName(animacao, bdText.Name);
            //var prop = new PropertyPath(Border.BackgroundProperty);
            //Storyboard.SetTargetProperty(animacao, prop);

            //< ThicknessAnimation
            //                      Storyboard.TargetName = "lbTitulo"
            //                      Storyboard.TargetProperty = "(Label.Margin)"
            //                      To = "0 -13 0 0"
            //                      Duration = "0:0:0.3"         
            //var animacao = new ThicknessAnimation()
            //{
            //    Duration = new Duration(TimeSpan.FromSeconds(5)),
            //    To =new Thickness(0, -5, 0, 0),
            //};
            //StoryBoardAtivando = new Storyboard();
            //StoryBoardAtivando.Children.Add(animacao);
            //Storyboard.SetTargetName(animacao, this.Template.Templa.Name);
            //var prop = new PropertyPath(TextBlock.MarginProperty);
            //Storyboard.SetTargetProperty(animacao, prop);
        }

        private void AnimacaoQuandoTiraOFocoNaTextBox()
        {

        }
    }
}
