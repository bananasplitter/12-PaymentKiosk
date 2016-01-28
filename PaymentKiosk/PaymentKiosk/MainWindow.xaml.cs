using PaymentKiosk.core;
using PaymentKiosk.core.Service;
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

namespace PaymentKiosk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonCharge_Click(object sender, RoutedEventArgs e)
        {
            var customer = new Customer
            {
                FullName = textBoxCustomerName.Text,
                TelephoneNumber = textBoxTelephone.Text
            };

            var credCard = new CreditCard
            {
                CcNumber = textBox_CreditCardNumber.Text,
                CVCCode = textBox_SecNum.Text,
                ExpireDate = DateTime.Parse(textBox_ExpDate.Text)
            };
            try
            {

                bool success = MoneyService.Charge(customer, credCard, decimal.Parse(textBox_ChargeAmount.Text));
                if (success)
                {
                    MessageBox.Show("Payment Successful");
                }
                else
                {
                    MessageBox.Show("Payment Not Successful");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
