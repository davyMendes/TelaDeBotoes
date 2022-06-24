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
                new Cliente("000000000001","TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT","Itapema","UF"),
                new Cliente("000000000002","TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT","Itapema","UF"),
                new Cliente("000000000003","TTTTTTTTTTTTTTTTTTTTTTTTT","Itapema","UF"),
                new Cliente("000000000004","TTTTTTTTTTT","Itapema","UF"),
                new Cliente("000000000005","TTTTTT","Itapema","UF"),
                new Cliente("000000000006","TTTTTTTTTTTTTTTTT","Itapema","UF"),
                new Cliente("000000000007","TTTTTTTTTTTTTTTT","Itapema","UF"),
                new Cliente("000000000008","TTTTTTTTTTTTTTTTTTTTTTT","Itapema","UF")   
            };
            DatagridPrincipal.ItemsSource = lista;
         
        }
    }
}
