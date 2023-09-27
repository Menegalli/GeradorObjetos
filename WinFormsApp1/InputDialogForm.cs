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
    public partial class InputDialogForm : Form
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        public InputDialogForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(sideATextBox.Text, out double sideAValue) &&
                double.TryParse(sideBTextBox.Text, out double sideBValue) &&
                double.TryParse(sideCTextBox.Text, out double sideCValue))
            {
                SideA = sideAValue;
                SideB = sideBValue;
                SideC = sideCValue;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Valores inválidos. Certifique-se de inserir números válidos para os lados.", "Erro");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
