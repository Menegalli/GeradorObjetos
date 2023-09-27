namespace WinFormsApp1
{
    partial class ScaleInputDialogForm
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
            scaleXLabel = new Label();
            scaleXTextBox = new TextBox();
            scaleYTextBox = new TextBox();
            scaleYLabel = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonOk = new Button();
            buttonCancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 236F));
            tableLayoutPanel1.Controls.Add(scaleXLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(scaleXTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(scaleYTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(scaleYLabel, 0, 1);
            tableLayoutPanel1.Location = new Point(96, 123);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(315, 79);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // scaleXLabel
            // 
            scaleXLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            scaleXLabel.AutoSize = true;
            scaleXLabel.Location = new Point(5, 0);
            scaleXLabel.Name = "scaleXLabel";
            scaleXLabel.Size = new Size(68, 39);
            scaleXLabel.TabIndex = 0;
            scaleXLabel.Text = "Escala de X:";
            scaleXLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // scaleXTextBox
            // 
            scaleXTextBox.Anchor = AnchorStyles.Left;
            scaleXTextBox.Location = new Point(82, 8);
            scaleXTextBox.Name = "scaleXTextBox";
            scaleXTextBox.Size = new Size(218, 23);
            scaleXTextBox.TabIndex = 1;
            // 
            // scaleYTextBox
            // 
            scaleYTextBox.Anchor = AnchorStyles.Left;
            scaleYTextBox.Location = new Point(82, 47);
            scaleYTextBox.Name = "scaleYTextBox";
            scaleYTextBox.Size = new Size(215, 23);
            scaleYTextBox.TabIndex = 2;
            // 
            // scaleYLabel
            // 
            scaleYLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            scaleYLabel.AutoSize = true;
            scaleYLabel.Location = new Point(5, 39);
            scaleYLabel.Name = "scaleYLabel";
            scaleYLabel.Size = new Size(68, 40);
            scaleYLabel.TabIndex = 3;
            scaleYLabel.Text = "Escala de Y:";
            scaleYLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(buttonOk, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonCancel, 1, 0);
            tableLayoutPanel2.Location = new Point(96, 307);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(315, 35);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // buttonOk
            // 
            buttonOk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            buttonOk.Location = new Point(43, 3);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(70, 29);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += okButton_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            buttonCancel.Location = new Point(198, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 29);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += cancelButton_Click;
            // 
            // ScaleInputDialogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 354);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "ScaleInputDialogForm";
            Text = "Preenchimento de Escala";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label scaleXLabel;
        private TextBox scaleXTextBox;
        private TextBox scaleYTextBox;
        private Label scaleYLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonOk;
        private Button buttonCancel;
    }
}