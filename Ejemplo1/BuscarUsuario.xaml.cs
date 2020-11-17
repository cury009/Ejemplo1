using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Lógica de interacción para BuscarUsuario.xaml
    /// </summary>
    public partial class BuscarUsuario : Window
    {
        public ObservableCollection<Usuario> listaUsuarios  { get; set;}
        public BuscarUsuario()
        {
            InitializeComponent();
            this.listaUsuarios = Usuario.listaUsuarios;
            this.DataContext = this;
        }
    }
}
