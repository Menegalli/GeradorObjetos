using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ScaleInputDialogForm : Form
    {
        public double ScaleX { get; private set; }
        public double ScaleY { get; private set; }

        public ScaleInputDialogForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(scaleXTextBox.Text, out double scaleXValue) &&
                double.TryParse(scaleYTextBox.Text, out double scaleYValue))
            {
                ScaleX = scaleXValue;
                ScaleY = scaleYValue;

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Valores inválidos. Certifique-se de inserir números válidos para as escalas.", "Erro");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
