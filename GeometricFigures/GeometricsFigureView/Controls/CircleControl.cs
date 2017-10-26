using System;
using System.Windows.Forms;
using GeometricFigures;

namespace GeometricsFigureView.Controls
{
    public partial class CircleControl : UserControl
    {
        public CircleControl()
        {
            InitializeComponent();
        }
        public Circle Circle
        {
            get
            {
                var circle = new Circle();
                try
                {
                    circle.Radius = Convert.ToDouble(RadiusTextBox.Text);
                }
                catch (FormatException)
                {
                    var exception = new FormatException(@"Ошибка ввода данных!");
                    throw exception;
                }
                return circle;

            }
            set
            {
                RadiusTextBox.Text = value.Radius.ToString();
                try
                {
                    double radiusTextBox = Convert.ToDouble(this.RadiusTextBox.Text);
                }
                catch (FormatException)
                {
                    var exception = new FormatException(@"Ошибка ввода данных!");
                    throw exception;
                }
            }
        }
    }
}
