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
        public bool estahLivre { get => String.IsNullOrWhiteSpace(this.texto); }

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
            if (string.IsNullOrEmpty(texto))
            {
               
            }
        }
    }
}
