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
    public partial class TranslateInputDialogForm : Form
    {
        public int PosX { get; set; }
        public int PosY { get; set; }
        public TranslateInputDialogForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(posXTextBox.Text, out int posX) &&
                int.TryParse(posYTextBox.Text, out int posY))
            {
                PosX = posX;
                PosY = posY;

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
