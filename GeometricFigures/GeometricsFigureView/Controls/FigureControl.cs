using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeometricFigures;

namespace GeometricsFigureView.Controls
{
    public partial class FigureControl : UserControl
    {
        public FigureControl()
        {
            InitializeComponent();
            FigureComboBox1.Items.Add("Прямоугольник");
            FigureComboBox1.Items.Add("Треугольник");
            FigureComboBox1.Items.Add("Окружность");

            rectangleControl.Visible = false;
            triangleControl.Visible = false;
            circleControl.Visible = false;
        }
        public IFigure Figure
        {
            get
            {
                IFigure figure = null;
                int ss = FigureComboBox1.SelectedIndex;
                switch (ss)
                {
                    case 0:
                        {
                            try
                            {
                                figure = rectangleControl.Rectangle;
                            }
                            catch (FormatException exception)
                            {
                                throw exception;
                            }
                            break;
                        }
                    case 1:
                        {
                            try
                            {
                                figure = triangleControl.Triangle;
                            }
                            catch (FormatException exception)
                            {
                                throw exception;
                            }
                            break;
                        }
                    
                    case 2:
                        {
                            try
                            {
                                figure = circleControl.Circle;
                            }
                            catch (FormatException exception)
                            {
                                throw exception;
                            }
                            break;
                        }
                }
                return figure;
            }
            set
            {
                if (value is GeometricFigures.Rectangle)
                {
                    FigureComboBox1.SelectedIndex = 0;
                    try
                    {
                        rectangleControl.Rectangle = (GeometricFigures.Rectangle)value;
                    }
                    catch (FormatException exception)
                    {
                        throw exception;
                    }
                }
                else if (value is Triangle)
                {
                    FigureComboBox1.SelectedIndex = 1;
                    try
                    {
                        triangleControl.Triangle = (Triangle)value;
                    }
                    catch (FormatException exception)
                    {
                        throw exception;
                    }
                }

                else if (value is Circle)
                {
                    FigureComboBox1.SelectedIndex = 2;
                    try
                    {
                        circleControl.Circle = (Circle)value;
                    }
                    catch (FormatException exception)
                    {
                        throw exception;
                    }
                }
            }
        }
        private void figurecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            rectangleControl.Visible = (FigureComboBox1.SelectedIndex == 0);
            triangleControl.Visible = (FigureComboBox1.SelectedIndex == 1);
            circleControl.Visible = (FigureComboBox1.SelectedIndex == 2);
        }
    }
}
