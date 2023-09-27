namespace WinFormsApp1
{
    partial class SquareInputDialogForm
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
            sideALabel = new Label();
            sideBLabel = new Label();
            sideCLabel = new Label();
            sideDLabel = new Label();
            sideATextBox = new TextBox();
            sideBTextBox = new TextBox();
            sideCTextBox = new TextBox();
            sideDTextBox = new TextBox();
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
            tableLayoutPanel1.Controls.Add(sideALabel, 0, 0);
            tableLayoutPanel1.Controls.Add(sideBLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(sideCLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(sideDLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(sideATextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(sideBTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(sideCTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(sideDTextBox, 1, 3);
            tableLayoutPanel1.Location = new Point(27, 26);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.Size = new Size(229, 131);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // sideALabel
            // 
            sideALabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            sideALabel.AutoSize = true;
            sideALabel.Location = new Point(35, 0);
            sideALabel.Name = "sideALabel";
            sideALabel.Size = new Size(44, 31);
            sideALabel.TabIndex = 0;
            sideALabel.Text = "Lado A";
            sideALabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sideBLabel
            // 
            sideBLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            sideBLabel.AutoSize = true;
            sideBLabel.Location = new Point(35, 31);
            sideBLabel.Name = "sideBLabel";
            sideBLabel.Size = new Size(43, 31);
            sideBLabel.TabIndex = 1;
            sideBLabel.Text = "Lado B";
            sideBLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sideCLabel
            // 
            sideCLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            sideCLabel.AutoSize = true;
            sideCLabel.Location = new Point(35, 62);
            sideCLabel.Name = "sideCLabel";
            sideCLabel.Size = new Size(44, 35);
            sideCLabel.TabIndex = 2;
            sideCLabel.Text = "Lado C";
            sideCLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sideDLabel
            // 
            sideDLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            sideDLabel.AutoSize = true;
            sideDLabel.Location = new Point(35, 97);
            sideDLabel.Name = "sideDLabel";
            sideDLabel.Size = new Size(44, 34);
            sideDLabel.TabIndex = 3;
            sideDLabel.Text = "Lado D";
            sideDLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sideATextBox
            // 
            sideATextBox.Anchor = AnchorStyles.Left;
            sideATextBox.Location = new Point(117, 4);
            sideATextBox.Name = "sideATextBox";
            sideATextBox.Size = new Size(109, 23);
            sideATextBox.TabIndex = 4;
            // 
            // sideBTextBox
            // 
            sideBTextBox.Anchor = AnchorStyles.Left;
            sideBTextBox.Location = new Point(117, 35);
            sideBTextBox.Name = "sideBTextBox";
            sideBTextBox.Size = new Size(109, 23);
            sideBTextBox.TabIndex = 5;
            // 
            // sideCTextBox
            // 
            sideCTextBox.Anchor = AnchorStyles.Left;
            sideCTextBox.Location = new Point(117, 68);
            sideCTextBox.Name = "sideCTextBox";
            sideCTextBox.Size = new Size(109, 23);
            sideCTextBox.TabIndex = 6;
            // 
            // sideDTextBox
            // 
            sideDTextBox.Anchor = AnchorStyles.Left;
            sideDTextBox.Location = new Point(117, 102);
            sideDTextBox.Name = "sideDTextBox";
            sideDTextBox.Size = new Size(109, 23);
            sideDTextBox.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(buttonOk, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonCancel, 1, 0);
            tableLayoutPanel2.Location = new Point(27, 234);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(229, 29);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // buttonOk
            // 
            buttonOk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            buttonOk.Location = new Point(19, 3);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += okButton_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            buttonCancel.Location = new Point(134, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += cancelButton_Click;
            // 
            // SquareInputDialogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 275);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "SquareInputDialogForm";
            Text = "Gerador de Quadrado";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label sideALabel;
        private Label sideBLabel;
        private Label sideCLabel;
        private Label sideDLabel;
        private TextBox sideATextBox;
        private TextBox sideBTextBox;
        private TextBox sideCTextBox;
        private TextBox sideDTextBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonOk;
        private Button buttonCancel;
    }
}