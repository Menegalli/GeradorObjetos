using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class DefaultInputDialogForm : Form
    {
        public double RotationAngle { get; set; }
        public DefaultInputDialogForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(rotationAngleTextBox.Text, out double rotationAngle))
            {
                RotationAngle = rotationAngle;

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
