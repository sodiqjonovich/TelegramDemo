using MaterialDesignThemes.Wpf;
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

namespace TelegramDemo
{
    /// <summary>
    /// Interaction logic for MenuButton.xaml
    /// </summary>
    public partial class MenuButton : UserControl
    {
        public PackIconKind PackIconName { get; set; } = PackIconKind.ViewDashboard;
        public string ButtonName { get; set; }

        public MenuButton()
        {
            InitializeComponent();
        }

        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
            BrushConverter bc = new BrushConverter();
            ((Border)sender).Background = Brushes.White;
            dIcon.Foreground = (Brush)bc.ConvertFrom("#209F84");
            dashboardText.Foreground = (Brush)bc.ConvertFrom("#209F84");
        }

        private void Border_MouseLeave(object sender, MouseEventArgs e)
        {
            BrushConverter bc = new BrushConverter();
            ((Border)sender).Background = (Brush) bc.ConvertFrom("#209F84");
            dIcon.Foreground = Brushes.White;
            dashboardText.Foreground = Brushes.White;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            dashboardText.Content = ButtonName;
            dIcon.Kind = PackIconName;
        }
    }
}
