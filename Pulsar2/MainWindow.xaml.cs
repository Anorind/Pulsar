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
using System.Windows.Threading;

namespace Pulsar2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Random _random = new Random();
        public MainWindow()
        {
            InitializeComponent();

            PulsarCircle.MouseEnter += PulsarCircle_MouseEnter;
            PulsarCircle.MouseLeave += PulsarCircle_MouseLeave;
        }

        private void PulsarCircle_MouseEnter(object sender, MouseEventArgs e)
        {
            PulsarCircle.Fill = new RadialGradientBrush
            {
                GradientStops = new GradientStopCollection
                {
                    new GradientStop(Colors.Orange, _random.NextDouble()),
                    new GradientStop(Colors.Yellow, _random.NextDouble())
                }
            };
        }
        private void PulsarCircle_MouseLeave(object sender, MouseEventArgs e)
        {
            PulsarCircle.Fill = new RadialGradientBrush
            {
                GradientStops = new GradientStopCollection
                {
                    new GradientStop(Colors.Orange, _random.NextDouble()),
                    new GradientStop(Colors.Yellow, _random.NextDouble())
                }
            };
        }
    }
}

