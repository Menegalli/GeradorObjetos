namespace WinFormsApp1
{
    partial class TranslateInputDialogForm
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
            posXLabel = new Label();
            posYLabel = new Label();
            posXTextBox = new TextBox();
            posYTextBox = new TextBox();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(posXLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(posYLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(posXTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(posYTextBox, 1, 1);
            tableLayoutPanel1.Location = new Point(63, 43);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(289, 146);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // posXLabel
            // 
            posXLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            posXLabel.AutoSize = true;
            posXLabel.Location = new Point(52, 0);
            posXLabel.Name = "posXLabel";
            posXLabel.Size = new Size(39, 73);
            posXLabel.TabIndex = 0;
            posXLabel.Text = "Pos X:";
            posXLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // posYLabel
            // 
            posYLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            posYLabel.AutoSize = true;
            posYLabel.Location = new Point(52, 73);
            posYLabel.Name = "posYLabel";
            posYLabel.Size = new Size(39, 73);
            posYLabel.TabIndex = 1;
            posYLabel.Text = "Pos Y:";
            posYLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // posXTextBox
            // 
            posXTextBox.Anchor = AnchorStyles.Left;
            posXTextBox.Location = new Point(147, 25);
            posXTextBox.Name = "posXTextBox";
            posXTextBox.Size = new Size(139, 23);
            posXTextBox.TabIndex = 2;
            // 
            // posYTextBox
            // 
            posYTextBox.Anchor = AnchorStyles.Left;
            posYTextBox.Location = new Point(147, 98);
            posYTextBox.Name = "posYTextBox";
            posYTextBox.Size = new Size(139, 23);
            posYTextBox.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(buttonOk, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonCancel, 1, 0);
            tableLayoutPanel2.Location = new Point(63, 209);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(284, 36);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // buttonOk
            // 
            buttonOk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            buttonOk.Location = new Point(31, 3);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(79, 30);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += okButton_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            buttonCancel.Location = new Point(175, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 30);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += cancelButton_Click;
            // 
            // TranslateInputDialogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(400, 269);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "TranslateInputDialogForm";
            Text = "Translação";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label posXLabel;
        private Label posYLabel;
        private TextBox posXTextBox;
        private TextBox posYTextBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonOk;
        private Button buttonCancel;
    }
}