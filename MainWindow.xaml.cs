using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PolestarApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }
     
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow ventanaLogin = new LoginWindow();
            ventanaLogin.Show();
        }
        private void BtnInicarSesion_Click(object sender, RoutedEventArgs e)
        { TxtErrorLogin.Visibility = Visibility.Visible; }

        private void BtnVehiculos_CLick(object sender, RoutedEventArgs e)
        {
            VehiculosWindow ventanaVehiculos = new VehiculosWindow();
            ventanaVehiculos.Show();
        }

        private void Polestar_España_Loaded(object sender, RoutedEventArgs e)
        { 
            var animacion = new System.Windows.Media.Animation.DoubleAnimation
            {
                From = 0,
                To = 1,
                Duration = TimeSpan.FromSeconds(1.2)
            };

            TítuloPrincipal.BeginAnimation(
                System.Windows.UIElement.OpacityProperty,
                animacion);
        }
    

    }
}