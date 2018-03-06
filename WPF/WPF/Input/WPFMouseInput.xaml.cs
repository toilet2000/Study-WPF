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
    /// WPFMouseInput.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class WPFMouseInput : Window
    {
        public WPFMouseInput()
        {
            InitializeComponent();
        }

        private void OnMouseEnter(object sender, MouseEventArgs e)
        {
            Rectangle source = e.Source as Rectangle;
            if (source != null)
                source.Fill = Brushes.SlateGray;
            txt1.Text = "Mouse Enter";
        }

        private void OnMouseLeave(object sender, MouseEventArgs e)
        {
            Rectangle source = sender as Rectangle;
            if (source != null)
                source.Fill = Brushes.AliceBlue;
            txt1.Text = "Mouse Leave";
            txt2.Text = "";
            txt3.Text = "";
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            Rectangle source = sender as Rectangle;
            if (source != null)
            {
                Point pnt = e.GetPosition(source);
                txt2.Text = "Mouse Move: " + pnt.ToString();
            }
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            Rectangle source = sender as Rectangle;
            if (source != null)
            {
                Point pnt = e.GetPosition(source);
                txt3.Text = "Mouse Clicked: " + pnt.ToString();

                source.Fill = Brushes.Beige;
            }
        }
    }
}
