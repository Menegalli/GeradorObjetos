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
    public partial class SquareInputDialogForm : Form
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double SideD { get; set; }
        public SquareInputDialogForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(sideATextBox.Text, out double sideA) &&
                double.TryParse(sideBTextBox.Text, out double sideB) &&
                double.TryParse(sideCTextBox.Text, out double sideC) &&
                double.TryParse(sideDTextBox.Text, out double sideD))
            {
                SideA = sideA;
                SideB = sideB;
                SideC = sideC;
                SideD = sideD;

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Valores inválidos. Certifique-se de inserir números válidos para as posições.", "Erro");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
