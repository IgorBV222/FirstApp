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

namespace FirstApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var symbol = ((Button)sender).Content.ToString();
            switch (symbol)
            {
                case " ":
                    ((Button)sender).Content = "X";
                    break;
                case "X":
                    ((Button)sender).Content = "O";
                    break;
                case "O":
                    ((Button)sender).Content = " ";
                    break;
                default:
                    break;
            }
            //MessageBox.Show(((Button)sender).Name);
        }
    }
}
