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

namespace KURS
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {

        private Frame mainFrame;
        public LoginPage()
        {
            InitializeComponent();

            mainFrame = new Frame();
            Content = mainFrame;
        }

        private void supplierFrame_Navigated(object sender, NavigationEventArgs e)
        {
            mainFrame.NavigationService.Navigate(new SupplierPage());
        }

        private void customerFrame_Navigated(object sender, NavigationEventArgs e)
        {
            mainFrame.NavigationService.Navigate(new CustomerPage());
        }

        private void productFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void invoiceFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void reportFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
