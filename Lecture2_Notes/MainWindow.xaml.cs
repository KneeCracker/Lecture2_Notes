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

namespace Lecture2_Notes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        //Hello 
        //04-26-2024
        public MainWindow()
        {
            InitializeComponent();

            string userFirstName = txtfirstName.Text;

            //message box
            //MessageBox.Show(userFirstName);

        }

        private void btnPopUpMessage_Click(object sender, RoutedEventArgs e)
        {
            string userFirstName = txtfirstName.Text;

            int a = 5;
            int b = 3;
            int sum = a + b;

            MessageBox.Show(sum.ToString());
        }
    }
}