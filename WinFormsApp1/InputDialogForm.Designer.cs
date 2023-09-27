namespace WinFormsApp1
{
    partial class InputDialogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputDialogForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            sideATextBox = new TextBox();
            sideBLabel = new Label();
            sideCLabel = new Label();
            sideCTextBox = new TextBox();
            sideALabel = new Label();
            sideBTextBox = new TextBox();
            buttonsPanel = new TableLayoutPanel();
            buttonOk = new Button();
            cancelButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.49495F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.50505F));
            tableLayoutPanel1.Controls.Add(sideATextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(sideBLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(sideCLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(sideCTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(sideALabel, 0, 0);
            tableLayoutPanel1.Controls.Add(sideBTextBox, 1, 1);
            tableLayoutPanel1.Location = new Point(85, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel1.Size = new Size(260, 110);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // sideATextBox
            // 
            sideATextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            sideATextBox.Location = new Point(69, 12);
            sideATextBox.Name = "sideATextBox";
            sideATextBox.Size = new Size(182, 23);
            sideATextBox.TabIndex = 0;
            // 
            // sideBLabel
            // 
            sideBLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            sideBLabel.AutoSize = true;
            sideBLabel.Location = new Point(12, 38);
            sideBLabel.Name = "sideBLabel";
            sideBLabel.Size = new Size(46, 33);
            sideBLabel.TabIndex = 2;
            sideBLabel.Text = "Lado B:";
            sideBLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sideCLabel
            // 
            sideCLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            sideCLabel.AutoSize = true;
            sideCLabel.Location = new Point(12, 71);
            sideCLabel.Name = "sideCLabel";
            sideCLabel.Size = new Size(47, 34);
            sideCLabel.TabIndex = 3;
            sideCLabel.Text = "Lado C:";
            sideCLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sideCTextBox
            // 
            sideCTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            sideCTextBox.Location = new Point(69, 79);
            sideCTextBox.Name = "sideCTextBox";
            sideCTextBox.Size = new Size(182, 23);
            sideCTextBox.TabIndex = 5;
            // 
            // sideALabel
            // 
            sideALabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            sideALabel.AutoSize = true;
            sideALabel.Location = new Point(12, 5);
            sideALabel.Name = "sideALabel";
            sideALabel.Size = new Size(47, 33);
            sideALabel.TabIndex = 1;
            sideALabel.Text = "Lado A:";
            sideALabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sideBTextBox
            // 
            sideBTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            sideBTextBox.Location = new Point(69, 45);
            sideBTextBox.Name = "sideBTextBox";
            sideBTextBox.Size = new Size(182, 23);
            sideBTextBox.TabIndex = 4;
            // 
            // buttonsPanel
            // 
            buttonsPanel.ColumnCount = 2;
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            buttonsPanel.Controls.Add(buttonOk, 0, 0);
            buttonsPanel.Controls.Add(cancelButton, 1, 0);
            buttonsPanel.Location = new Point(12, 139);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.RowCount = 1;
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            buttonsPanel.Size = new Size(406, 31);
            buttonsPanel.TabIndex = 1;
            // 
            // buttonOk
            // 
            buttonOk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            buttonOk.Location = new Point(64, 3);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 25);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cancelButton.Location = new Point(267, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 25);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancelar";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // InputDialogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 182);
            Controls.Add(buttonsPanel);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InputDialogForm";
            Text = "Gerador de Triangulo";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox sideATextBox;
        private TextBox sideBTextBox;
        private TextBox sideCTextBox;
        private TableLayoutPanel buttonsPanel;
        private Button buttonOk;
        private Button cancelButton;
        private Label sideALabel;
        private Label sideBLabel;
        private Label sideCLabel;
        private TableLayoutPanel inputPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}