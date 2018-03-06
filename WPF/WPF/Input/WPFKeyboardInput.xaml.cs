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
using System.Windows.Shapes;

namespace WPF.Input
{
    /// <summary>
    /// WPFKeyboardInput.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class WPFKeyboardInput : Window
    {
        public WPFKeyboardInput()
        {
            InitializeComponent();
        }

        private void OnTextInputButtonClick(object sender, RoutedEventArgs e)
        {
            handle();
            e.Handled = true;
        }

        public void handle()
        {
            MessageBox.Show("Do you want to open a file?");
        }

        private void OnTextInputKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.O && Keyboard.Modifiers == ModifierKeys.Control)
            {
                handle();
                e.Handled = true;
            }
        }
    }
}
