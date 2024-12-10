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

namespace Ejercicio1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int TamañoDeTexto
        {
            get { return (int)GetValue(TamañoDeTextoProperty); }
            set { SetValue(TamañoDeTextoProperty, value);}
        }

        public static readonly DependencyProperty TamañoDeTextoProperty =
            DependencyProperty.Register("TamañoDeTexto", typeof(int), typeof(MainWindow), new PropertyMetadata(12));
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            TamañoDeTexto += 2;
        }
    }
}
