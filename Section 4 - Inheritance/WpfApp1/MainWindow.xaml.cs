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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //var button = (Button)sender; // Safe to do since this is an event handler for a Button click
            //button. -- Has access to all button properties and methods

            // If there are situations where you are downcasting an object and you are not sure about the runtime type of an object, use the as keyword
            var button = sender as Button;
            if (button != null )
            {
                MessageBox.Show(button.ActualHeight.ToString());
            }



            MessageBox.Show("Hello World!");


        }
    }
}
