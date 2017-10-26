using System;
using System.Windows.Forms;
using GeometricFigures;

namespace GeometricsFigureView.Controls
{
    public partial class TriangleControl : UserControl
    {
        public TriangleControl()
        {
            InitializeComponent();
        }
        public Triangle Triangle
        {
            get
            {
                var triangle = new Triangle();
                try
                {
                    triangle.SetSides(Convert.ToDouble(SideATextBox.Text),
                                      Convert.ToDouble(SideBTextBox.Text),
                                      Convert.ToDouble(SideCTextBox.Text));
                }
                catch (FormatException)
                {
                    var exception = new FormatException(@"Ошибка ввода данных!");
                    throw exception;
                }
                return triangle;

            }
            set
            {
                SideATextBox.Text = value.SideA.ToString();
                SideBTextBox.Text = value.SideB.ToString();
                SideCTextBox.Text = value.SideC.ToString();
                try
                {
                    double sideAtextBox = Convert.ToDouble(this.SideATextBox.Text);
                    double sideBtextBox = Convert.ToDouble(this.SideBTextBox.Text);
                    double sideCtextBox = Convert.ToDouble(this.SideCTextBox.Text);
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
