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
    /// Lógica de interacción para VehiculosWindow.xaml
    /// </summary>
    public partial class VehiculosWindow : Window
    {
        public VehiculosWindow()
        {
            InitializeComponent();
        }

    private void BtnInicio_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ventanaPrincipal = new MainWindow();
            ventanaPrincipal.Show();
                this.Close();
        }
    private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow ventanaLogin = new LoginWindow();
            ventanaLogin.Show();
                 this.Close();
        }

    }
}
