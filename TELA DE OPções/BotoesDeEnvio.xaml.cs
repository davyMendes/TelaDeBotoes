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
using System.Windows.Shapes;

namespace TELA_DE_OPções
{
    /// <summary>
    /// Lógica interna para BotoesDeEnvio.xaml
    /// </summary>
    public partial class BotoesDeEnvio : Window
    {
        public BotoesDeEnvio()
        {
            InitializeComponent();    
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var lista = new List<Cliente>() 
            { 
                new Cliente("000000000001","a","Itapema","UF"),
                new Cliente("000000000002","b","Itapema","UF"),
                new Cliente("000000000003","v","Itapema","UF"),
                new Cliente("000000000004","d","Itapema","UF"),
                new Cliente("000000000005","z","Itapema","UF"),
                new Cliente("000000000006","t","Itapema","UF"),
                new Cliente("000000000007","g","Itapema","UF"),
                new Cliente("000000000008","a","Itapema","UF")   
            };
            DatagridPrincipal.ItemsSource = lista;
        }
    }
}
