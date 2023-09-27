namespace WinFormsApp1
{
    partial class DefaultInputDialogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            rotationAngleLabel = new Label();
            rotationAngleTextBox = new TextBox();
            labelDegrees = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonOk = new Button();
            buttonCancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 21F));
            tableLayoutPanel1.Controls.Add(rotationAngleLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(rotationAngleTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(labelDegrees, 2, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(352, 83);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // rotationAngleLabel
            // 
            rotationAngleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            rotationAngleLabel.AutoSize = true;
            rotationAngleLabel.Location = new Point(28, 0);
            rotationAngleLabel.Name = "rotationAngleLabel";
            rotationAngleLabel.Size = new Size(108, 83);
            rotationAngleLabel.TabIndex = 0;
            rotationAngleLabel.Text = "Ângulo de Rotação";
            rotationAngleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rotationAngleTextBox
            // 
            rotationAngleTextBox.Anchor = AnchorStyles.Left;
            rotationAngleTextBox.Location = new Point(168, 30);
            rotationAngleTextBox.Name = "rotationAngleTextBox";
            rotationAngleTextBox.Size = new Size(159, 23);
            rotationAngleTextBox.TabIndex = 1;
            // 
            // labelDegrees
            // 
            labelDegrees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelDegrees.AutoSize = true;
            labelDegrees.Location = new Point(333, 0);
            labelDegrees.Name = "labelDegrees";
            labelDegrees.Size = new Size(12, 83);
            labelDegrees.TabIndex = 2;
            labelDegrees.Text = "º";
            labelDegrees.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(buttonOk, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonCancel, 1, 0);
            tableLayoutPanel2.Location = new Point(12, 153);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(352, 33);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // buttonOk
            // 
            buttonOk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            buttonOk.Location = new Point(50, 3);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 27);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += okButton_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            buttonCancel.Location = new Point(226, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 27);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += cancelButton_Click;
            // 
            // DefaultInputDialogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 198);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "DefaultInputDialogForm";
            Text = "Rotacionar Objeto";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label rotationAngleLabel;
        private TextBox rotationAngleTextBox;
        private Label labelDegrees;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonOk;
        private Button buttonCancel;
    }
}