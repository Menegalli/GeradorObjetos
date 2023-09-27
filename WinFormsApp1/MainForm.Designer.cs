using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            buttonRotation = new Button();
            buttonSave = new Button();
            buttonGerarSquare = new Button();
            buttonTranslation = new Button();
            scaleButton = new Button();
            buttonGerarTriangle = new Button();
            panelTriangles = new Panel();
            panelRectangles = new Panel();
            panelSquares = new Panel();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button4 = new Button();
            teste = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(buttonRotation);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonGerarSquare);
            panel1.Controls.Add(buttonTranslation);
            panel1.Controls.Add(scaleButton);
            panel1.Controls.Add(buttonGerarTriangle);
            panel1.Controls.Add(panelTriangles);
            panel1.Controls.Add(panelRectangles);
            panel1.Controls.Add(panelSquares);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(teste);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1484, 921);
            panel1.TabIndex = 0;
            panel1.MouseClick += MainForm_MouseClick;
            // 
            // buttonRotation
            // 
            buttonRotation.Location = new Point(1309, 149);
            buttonRotation.Name = "buttonRotation";
            buttonRotation.Size = new Size(154, 23);
            buttonRotation.TabIndex = 18;
            buttonRotation.Text = "Rotação";
            buttonRotation.UseVisualStyleBackColor = true;
            buttonRotation.Click += buttonRotation_Click;
            // 
            // buttonSave
            // 
            buttonSave.Image = (System.Drawing.Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(1439, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(42, 42);
            buttonSave.TabIndex = 17;
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += saveImageButton_Click;
            // 
            // buttonGerarSquare
            // 
            buttonGerarSquare.Location = new Point(1309, 607);
            buttonGerarSquare.Name = "buttonGerarSquare";
            buttonGerarSquare.Size = new Size(154, 23);
            buttonGerarSquare.TabIndex = 16;
            buttonGerarSquare.Text = "Gerar Quadrado";
            buttonGerarSquare.UseVisualStyleBackColor = true;
            buttonGerarSquare.Click += buttonGerarSquare_Click;
            // 
            // buttonTranslation
            // 
            buttonTranslation.Location = new Point(1309, 120);
            buttonTranslation.Name = "buttonTranslation";
            buttonTranslation.Size = new Size(154, 23);
            buttonTranslation.TabIndex = 15;
            buttonTranslation.Text = "Translação";
            buttonTranslation.UseVisualStyleBackColor = true;
            buttonTranslation.Click += buttonTranslation_Click;
            // 
            // scaleButton
            // 
            scaleButton.Location = new Point(1309, 91);
            scaleButton.Name = "scaleButton";
            scaleButton.Size = new Size(154, 23);
            scaleButton.TabIndex = 14;
            scaleButton.Text = "Escala";
            scaleButton.UseVisualStyleBackColor = true;
            scaleButton.Click += scaleButton_Click;
            // 
            // buttonGerarTriangle
            // 
            buttonGerarTriangle.Location = new Point(1309, 636);
            buttonGerarTriangle.Name = "buttonGerarTriangle";
            buttonGerarTriangle.Size = new Size(154, 23);
            buttonGerarTriangle.TabIndex = 12;
            buttonGerarTriangle.Text = "Gerar Triangulo";
            buttonGerarTriangle.UseVisualStyleBackColor = true;
            buttonGerarTriangle.Click += CreateTriangleButton_Click;
            // 
            // panelTriangles
            // 
            panelTriangles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelTriangles.AutoSize = true;
            panelTriangles.BackColor = SystemColors.InactiveCaption;
            panelTriangles.Location = new Point(30, 303);
            panelTriangles.Margin = new Padding(0);
            panelTriangles.MaximumSize = new Size(1250, 586);
            panelTriangles.MinimumSize = new Size(1250, 295);
            panelTriangles.Name = "panelTriangles";
            panelTriangles.Size = new Size(1250, 295);
            panelTriangles.TabIndex = 11;
            panelTriangles.Paint += panelTriangles_Paint;
            panelTriangles.MouseClick += panelTriangles_MouseClick;
            // 
            // panelRectangles
            // 
            panelRectangles.BackColor = SystemColors.InactiveCaption;
            panelRectangles.Location = new Point(30, 588);
            panelRectangles.Margin = new Padding(0);
            panelRectangles.Name = "panelRectangles";
            panelRectangles.Size = new Size(1250, 291);
            panelRectangles.TabIndex = 11;
            panelRectangles.Paint += panelRectangles_Paint;
            panelRectangles.MouseClick += panelRectangles_MouseClick;
            // 
            // panelSquares
            // 
            panelSquares.BackColor = SystemColors.InactiveCaption;
            panelSquares.Location = new Point(30, 12);
            panelSquares.Margin = new Padding(0);
            panelSquares.Name = "panelSquares";
            panelSquares.Size = new Size(1250, 291);
            panelSquares.TabIndex = 9;
            panelSquares.Paint += panelSquares_Paint;
            panelSquares.MouseClick += MainForm_MouseClick;
            // 
            // button8
            // 
            button8.Location = new Point(1309, 727);
            button8.Name = "button8";
            button8.Size = new Size(154, 23);
            button8.TabIndex = 8;
            button8.Text = "Gerar Triangulo Isosceles";
            button8.UseVisualStyleBackColor = true;
            button8.Click += createTriangleIsoscelesButton_Click;
            // 
            // button7
            // 
            button7.Location = new Point(1309, 756);
            button7.Name = "button7";
            button7.Size = new Size(154, 23);
            button7.TabIndex = 7;
            button7.Text = "Gerar Triangulo Escaleno";
            button7.UseVisualStyleBackColor = true;
            button7.Click += createEscalenoTriangleButton_Click;
            // 
            // button6
            // 
            button6.Location = new Point(1351, 62);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 6;
            button6.Text = "Limpar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += panel1_Clear;
            // 
            // button4
            // 
            button4.Location = new Point(1309, 804);
            button4.Name = "button4";
            button4.Size = new Size(154, 23);
            button4.TabIndex = 4;
            button4.Text = "Gerar Retangulo Padrão";
            button4.UseVisualStyleBackColor = true;
            button4.Click += createRectangleButton_Click;
            // 
            // teste
            // 
            teste.Location = new Point(1309, 698);
            teste.Name = "teste";
            teste.Size = new Size(154, 23);
            teste.TabIndex = 0;
            teste.Text = "Gerar Triangulo Equilatero";
            teste.UseVisualStyleBackColor = true;
            teste.Click += createTriangleButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1309, 833);
            button1.Name = "button1";
            button1.Size = new Size(154, 23);
            button1.TabIndex = 1;
            button1.Text = "Gerar Quadrado Padrão";
            button1.UseVisualStyleBackColor = true;
            button1.Click += createSquareButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1484, 921);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Gerador de Objetos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button teste;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Panel panelSquares;
        private Panel panelTriangles;
        private Panel panelRectangles;
        private Button buttonGerarTriangle;
        private Button counterClockwiseButton;
        private Button scaleButton;
        private Button buttonTranslation;
        private Button buttonGerarSquare;
        private Button buttonSave;
        private Button buttonRotation;
    }
}