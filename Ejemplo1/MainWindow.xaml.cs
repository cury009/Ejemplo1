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

namespace Ejemplo1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CrearUsuario();
        }

        private bool Validation()
        {
            bool validate = true;

            foreach(UIElement element in myGrid.Children)
            {
                if (element is TextBox)
                {
                    TextBox textBox = (TextBox)element;
                    if (textBox.Text.Equals(""))
                    {
                        textBox.BorderBrush = new SolidColorBrush(Colors.Red);
                        validate = false;
                    }
                    else
                    {
                        textBox.BorderBrush = new SolidColorBrush(Colors.LightGray);
                    }
                }
            }

            return validate;
        }
        private void CrearUsuario()
        {
            String nombre = nombreBox.Text;
            String apellido1 = apellido1Box.Text;
            String apellido2 = apellido2Box.Text;
            String direccion = direcconBox.Text;
            String codigo = codigoBox.Text;

           

            if(Validation())
            {
                warningLabel.Visibility = Visibility.Hidden;
                MessageBoxResult resultado = MessageBox.Show("Nombre: " + nombre + "\n" +
                           "Primer Apellido: " + apellido1 + "\n" +
                           "Segundo Apellido: " + apellido2 + "\n" +
                           "Direccion: " + direccion + "\n" +
                           "Codigo Postal: " + codigo + "\n\n" +
                           "¿Estos datos son correctos?",
                           "Registro de usuario",
                           MessageBoxButton.YesNoCancel, MessageBoxImage.Information);
                switch (resultado)
                {
                    case MessageBoxResult.Yes:
                        MessageBox.Show("Usuario registrado con éxito");
                        Usuario usuario = new Usuario(nombre, apellido1, apellido2, direccion, codigo);
                        Usuario.NuevoUsuario(usuario);
                        //MostrarUsuario mostrarUsuario = new MostrarUsuario(usuario);
                        //mostrarUsuario.Show();
                        break;
                    case MessageBoxResult.No:
                        break;
                    case MessageBoxResult.Cancel:
                        break;
                }
            }
            else
            {
                warningLabel.Visibility = Visibility.Visible;
            }
            //fin del if

           
        }//fin crear usuario
    }
}
