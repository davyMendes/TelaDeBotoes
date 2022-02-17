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
    /// <summary>
    /// Interação lógica para BotaoPesquisar.xam
    /// </summary>
    public partial class BotaoPesquisar : UserControl
    {
        public static readonly DependencyProperty NormalImageProperty = DependencyProperty.Register("NormalImage", typeof(ImageSource), typeof(BotaoPesquisar), new UIPropertyMetadata(null));

        public static readonly DependencyProperty TextoPrincipalProperty = DependencyProperty.Register("TextoPrincipal", typeof(string), typeof(BotaoPesquisar), new UIPropertyMetadata(null));

        public static readonly DependencyProperty TextoSecundarioProperty = DependencyProperty.Register("TextoSecundario", typeof(string), typeof(BotaoPesquisar), new UIPropertyMetadata(null));

        public static readonly DependencyProperty CorPrimariaProperty = DependencyProperty.Register("CorPrimaria", typeof(SolidColorBrush), typeof(BotaoPesquisar), new UIPropertyMetadata(null));

        public static readonly DependencyProperty CorSecundariaProperty = DependencyProperty.Register("CorSecundaria", typeof(SolidColorBrush), typeof(BotaoPesquisar), new UIPropertyMetadata(null));

        public ImageSource NormalImage
        {
            get { return (ImageSource)GetValue(NormalImageProperty); }
            set { SetValue(NormalImageProperty, value); }
        }
        public string TextoPrincipal { get; set; }
        public string TextoSecundario { get; set; }
        public SolidColorBrush CorPrincipal { get; set; }
        public SolidColorBrush CorSecundaria { get; set; }

        public BotaoPesquisar()
        {        
            InitializeComponent();
        }


        public event RoutedEventHandler Click;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (Click != null)
            {
                Click(this, e);
            }
        }
    }
}
