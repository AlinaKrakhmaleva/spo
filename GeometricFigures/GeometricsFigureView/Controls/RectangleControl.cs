using System;
using System.Windows.Forms;

namespace GeometricsFigureView.Controls
{
    public partial class RectangleControl : UserControl
    {
        public RectangleControl()
        {
            InitializeComponent();
        }
        public GeometricFigures.Rectangle Rectangle
        {
            get
            {
                var rectangle = new GeometricFigures.Rectangle();
                try
                {
                    rectangle.Height = Convert.ToDouble(SideATextBox.Text);
                    rectangle.Width = Convert.ToDouble(SideBTextBox.Text);
                }
                catch (FormatException)
                {
                    var exception = new FormatException(@"Ошибка ввода данных!");
                    throw exception;
                }
                return rectangle;

            }
            set
            {
                SideATextBox.Text = value.Height.ToString();
                SideBTextBox.Text = value.Width.ToString();
                try
                {
                    double sideAtextBox = Convert.ToDouble(this.SideATextBox.Text);
                    double sideBtextBox = Convert.ToDouble(this.SideATextBox.Text);
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
