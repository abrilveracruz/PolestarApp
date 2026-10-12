using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PolestarApp
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void BtnIniciarSesion_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtUsuario.Text)||
                string.IsNullOrWhiteSpace(TxtContrasena.Password))
            {
                TxtErrorLogin.Text = "Introduce el usuario y la contraseña";
                TxtErrorLogin.Visibility = Visibility.Visible;
                return;
            }
            TxtErrorLogin.Text = "Usuario o contraseña incorrectos";
            TxtErrorLogin.Visibility = Visibility.Visible;
        }

        private void BtnInicio_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ventanaPrincipal = new MainWindow();
            ventanaPrincipal.Show();
            this.Close();
        }

        private void BtnVehiculos_Click(object sender, RoutedEventArgs e)
        {
            VehiculosWindow ventanaVehiculos = new VehiculosWindow();
            ventanaVehiculos.Show();
            this.Close();
        }
    }
}
