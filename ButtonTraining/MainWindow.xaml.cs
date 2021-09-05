using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ButtonTraining {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private int count = 0;
        private void Button_Click(object sender, RoutedEventArgs e) {
            var button = (Button)sender;
            button.Content = string.Format("{0}回", ++count);
        }

        private int repeatButtonCount = 0;
        private void RepeatButton_Click(object sender, RoutedEventArgs e) {
            var button = (RepeatButton)sender;
            button.Content = string.Format("{0}回", ++repeatButtonCount);
        }
    }
}
