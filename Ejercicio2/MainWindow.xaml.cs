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

namespace Ejercicio2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Brush ColorDeFondoTexto
        {
            get {return (Brush) GetValue(ColorDeFondoTextoProperty); }
            set {SetValue(ColorDeFondoTextoProperty, value);}
        }

        public static readonly DependencyProperty ColorDeFondoTextoProperty =
            DependencyProperty.Register("ColorDeFondoTexto", typeof(Brush), typeof(MainWindow), new PropertyMetadata(Brushes.Black));

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ColorDeFondoTexto = Brushes.LightBlue;
        }
    }
}
