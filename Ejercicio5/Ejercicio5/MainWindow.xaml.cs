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

namespace Ejercicio5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var estudiantes = new ListCollectionView(new List<Estudiante>
        {
            new Estudiante { Nombre = "Ana", Edad = 20, Nota = 9.0, Curso = "Matemáticas" },
            new Estudiante { Nombre = "Luis", Edad = 22, Nota = 7.5, Curso = "Matemáticas" },
            new Estudiante { Nombre = "María", Edad = 21, Nota = 8.5, Curso = "Física" },
            new Estudiante { Nombre = "Pedro", Edad = 23, Nota = 6.0, Curso = "Física" },
            new Estudiante { Nombre = "Sofía", Edad = 20, Nota = 9.5, Curso = "Química" },
            new Estudiante { Nombre = "Carlos", Edad = 22, Nota = 7.0, Curso = "Química" },
        });

            estudiantes.GroupDescriptions.Add(new PropertyGroupDescription("Curso"));
            lbEstudiantes.ItemsSource = estudiantes;
        }

        private void lbEstudiantes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbEstudiantes.SelectedItem is Estudiante estudianteSeleccionado)
            {
                tbDetalles.Text = $"Detalles del Estudiante:\n" +
                                   $"Nombre: {estudianteSeleccionado.Nombre}\n" +
                                   $"Edad: {estudianteSeleccionado.Edad}\n" +
                                   $"Nota: {estudianteSeleccionado.Nota}\n" +
                                   $"Curso: {estudianteSeleccionado.Curso}";
            }
        }
    }

    public class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Nota { get; set; }
        public string Curso { get; set; }
    }

}
