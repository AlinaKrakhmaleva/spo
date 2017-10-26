using GeometricFigures;
using System;
using System.Windows.Forms;

namespace GeometricsFigureView
{
    public partial class AddFigureForm : Form
    {
        public AddFigureForm()
        {
            InitializeComponent();
        }

        public IFigure Figure
        {
            get
            {
                try
                {
                    var cathThrowFigure = figureControl.Figure;
                }
                catch (FormatException exception)
                {
                    MessageBox.Show(exception.Message);
                    return null;
                }
                return figureControl.Figure;
            }
            set
            {
                try
                {
                    figureControl.Figure = value;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    throw;
                }
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception A)
            {
                MessageBox.Show(A.Message, @"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CanselButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void figureControl_Load(object sender, EventArgs e)
        {

        }
    }
}
