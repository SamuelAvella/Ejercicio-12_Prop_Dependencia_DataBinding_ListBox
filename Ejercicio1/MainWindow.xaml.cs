using System.Windows;

public partial class MainWindow : Window
{
    // Definir la DependencyProperty
    public static readonly DependencyProperty TamañoTextoProperty =
        DependencyProperty.Register(
            "TamañoTexto", // Nombre de la propiedad
            typeof(double), // Tipo de la propiedad
            typeof(MainWindow), // Tipo de la clase que contiene la propiedad
            new PropertyMetadata(12.0)); // Valor predeterminado

    // Propiedad pública que envuelve la DependencyProperty
    public double TamañoTexto
    {
        get { return (double)GetValue(TamañoTextoProperty); }
        set { SetValue(TamañoTextoProperty, value); }
    }

    public MainWindow()
    {
        InitializeComponent();
        this.DataContext = this; // Establecer el DataContext de la ventana al propio objeto
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        TamañoTexto += 2.0; // Aumentar el tamaño del texto al hacer clic
    }
}
