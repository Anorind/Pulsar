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

namespace Pulsar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ButtonClose.IsEnabled = false;
        }

        private void ButtonOpen_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            dlg.DefaultExt = ".txt";
            dlg.Filter = "Текстовые документы (.txt)|*.txt";

            bool? result = dlg.ShowDialog();

            if (result == true)
            {
                string filename = dlg.FileName;
                string text = System.IO.File.ReadAllText(filename);
                TextBox1.Text = text;
            }
        }


        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            ButtonClose.IsEnabled = false;
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedStyle = (sender as ComboBox).SelectedItem as ComboBoxItem;

            switch (selectedStyle.Content.ToString())
            {
                case "Стиль 1":
                    TextBox1.FontSize = 16;
                    TextBox1.FontFamily = new FontFamily("Times New Roman");
                    TextBox1.Foreground = Brushes.Blue;
                    TextBox2.FontSize = 16;
                    TextBox2.FontFamily = new FontFamily("Times New Roman");
                    TextBox2.Foreground = Brushes.Blue;
                    break;

                case "Стиль 2":
                    TextBox1.FontSize = 14;
                    TextBox1.FontFamily = new FontFamily("Arial");
                    TextBox1.Foreground = Brushes.Green;
                    TextBox2.FontSize = 14;
                    TextBox2.FontFamily = new FontFamily("Arial");
                    TextBox2.Foreground = Brushes.Green;
                    break;

                case "Стиль 3":
                    TextBox1.FontSize = 12;
                    TextBox1.FontFamily = new FontFamily("Courier New");
                    TextBox1.Foreground = Brushes.Red;
                    TextBox2.FontSize = 12;
                    TextBox2.FontFamily = new FontFamily("Courier New");
                    TextBox2.Foreground = Brushes.Red;
                    break;

                default:
                    break;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox1.Text) || string.IsNullOrEmpty(TextBox2.Text))
                ButtonClose.IsEnabled = true;
            else
                ButtonClose.IsEnabled = false;
        }
    }
}
