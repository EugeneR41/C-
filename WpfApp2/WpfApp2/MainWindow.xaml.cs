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


namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string sign;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            if (screen.Text == "0" || screen.Text == "не число" || screen.Text == "err")
                screen.Text = "";
            screen.Text += ((sender as Button).Content as string);
        }

        private void div_Click(object sender, RoutedEventArgs e)
        {
            sign = ((sender as Button).Content as string);
            screen2.Text = screen.Text;
            screen.Text = "";
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = "0";
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
           int n = 0;
            if (screen.Text == "err")
                screen.Text = "0";
            if ((screen.Text != "не число") || (screen.Text != "err"))
                n = screen.Text.Length;
            if (n > 0)
                screen.Text = screen.Text.Remove(n - 1, 1);
                if (n == 0)
                    screen.Text = "0";
        }

        
        private void result_Click(object sender, RoutedEventArgs e)
        {
           double first = 0 , second = 0;
            if (screen2.Text != "err" && screen2.Text != "")
                first = Convert.ToDouble(screen2.Text);
            if (screen.Text != "err")
                second = Convert.ToDouble(screen.Text);
          
            switch (sign)
            {
                case "+":
                    first += second;
                    break;
                case "-":
                    first -= second;
                    break;
                case "*":
                    first *= second;
                    break;
                case "/":
                    if (screen.Text != "0")
                        first /= second;
                    else
                    {
                        screen.Text = "err"; 
                        return;
                    }
                    break;
            }
            screen.Text = first.ToString();
        }

        private void dot_Click(object sender, RoutedEventArgs e)
        {
            if (screen.Text.IndexOf(",") == -1 && screen.Text != "err")
            screen.Text += ",";
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Справкааааааа", "Справка");
        }
    }
}
