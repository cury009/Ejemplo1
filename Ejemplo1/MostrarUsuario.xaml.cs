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

namespace Ejemplo1
{
    /// <summary>
    /// Lógica de interacción para MostrarUsuario.xaml
    /// </summary>
    public partial class MostrarUsuario : Window
    {
        public Usuario usuario { set; get; }
        public MostrarUsuario (Usuario usuario)
        {
            
            InitializeComponent();
            this.usuario = usuario;
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
