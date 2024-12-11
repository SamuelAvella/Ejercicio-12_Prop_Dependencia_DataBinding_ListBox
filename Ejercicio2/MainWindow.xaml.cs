using System.Windows;
using System.Windows.Media;
namespace Ejemplo
{
    public partial class MainWindow : Window
    {
        public static readonly DependencyProperty ColorDeFondoTextoProperty =
        DependencyProperty.Register(
        "ColorDeFondoTexto",
        typeof(Brush),
        typeof(MainWindow),
        new PropertyMetadata(Brushes.White)
            );
        public Brush ColorDeFondoTexto
        {
            get { return (Brush)GetValue(ColorDeFondoTextoProperty); }
            set { SetValue(ColorDeFondoTextoProperty, value); }
        }
        public MainWindow()
        {
            InitializeComponent();
            MiTextBox.Background = ColorDeFondoTexto;
        }
        private void CambiarFondo_Click(object sender, RoutedEventArgs e)
        {
            ColorDeFondoTexto = ColorDeFondoTexto == Brushes.Yellow ? Brushes.White :
           Brushes.Yellow;
            MiTextBox.Background = ColorDeFondoTexto;
        }
    }
}
