using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private List<Shape> shapes = new List<Shape>();
        private List<Triangle> triangles = new List<Triangle>();
        private List<Square> squares = new List<Square>();
        private List<Rectangle> rectangles = new List<Rectangle>();
        private Shape selectedShape = null;
        private Shape newShape = null;
        private int spacing = 280;
        private int id = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            foreach (Shape shape in shapes)
            {
                if (shape != null)
                {
                    shape.DrawRotated(e.Graphics);
                }
            }
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (Shape shape in shapes)
            {
                if (shape != null)
                {
                    if (shape.Contains(e.Location))
                    {
                        selectedShape = shape;
                        Text = $@"Selecionado: Id: {selectedShape.Id}, TipoObjeto: {selectedShape.TipoObjeto}, Pos X: {e.Location.X}, Pos Y: {e.Location.Y}";
                        Refresh();
                        return;
                    }
                }
            }

            selectedShape = null;
            Text = "Gerador de Objetos";
        }

        private void UpdateTitle()
        {
            Text = $@"Selecionado: Id: {selectedShape.Id}, TipoObjeto: {selectedShape.TipoObjeto}";
        }

        private void panelRectangles_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (Shape shape in shapes)
            {
                if (shape != null)
                {
                    if (shape.Contains(e.Location))
                    {
                        selectedShape = shape;
                        Text = $@"Selecionado: Id: {selectedShape.Id}, TipoObjeto: {selectedShape.TipoObjeto}, Pos X: {e.Location.X}, Pos Y: {e.Location.Y}";
                        Refresh();
                        return;
                    }
                }
            }

            selectedShape = null;
            Text = "Gerador de Objetos";
        }

        private void panelTriangles_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (Shape shape in shapes)
            {
                if (shape != null)
                {
                    if (shape.Contains(e.Location))
                    {
                        selectedShape = shape;
                        Text = $@"Selecionado: Id: {selectedShape.Id}, TipoObjeto: {selectedShape.TipoObjeto}, Pos X: {e.Location.X}, Pos Y: {e.Location.Y}";
                        Refresh();
                        return;
                    }
                }
            }

            selectedShape = null;
            Text = "Gerador de Objetos";
        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            if (selectedShape != null)
            {
                selectedShape.Translate(50, 50);
                Refresh();
            }
        }

        private void panel1_Clear(object sender, EventArgs e)
        {
            selectedShape = null;
            Text = "Gerador de Objetos";
            shapes.Clear();
            triangles.Clear();
            panel1.Invalidate();
            Refresh();
        }

        private void rotateClockwiseButton_Click(object sender, EventArgs e)
        {
            if (selectedShape != null)
            {
                Shape copyShape = CloneShape(selectedShape);

                if (copyShape != null)
                {
                    copyShape.RotationAngle += 15.0;
                    shapes.Add(copyShape);
                    selectedShape = copyShape;
                    UpdateTitle();
                    Refresh();
                }
            }
        }

        private void rotateCounterclockwiseButton_Click(object sender, EventArgs e)
        {
            if (selectedShape != null)
            {
                Shape copyShape = CloneShape(selectedShape);

                if (copyShape != null)
                {
                    copyShape.RotationAngle -= 15.0;
                    shapes.Add(copyShape);
                    selectedShape = copyShape;
                    UpdateTitle();
                    Refresh();
                }
            }
        }

        private void scaleUniformButton_Click(object sender, EventArgs e)
        {
            if (selectedShape != null)
            {
                newShape = selectedShape;
                newShape.ScaleUniform(1.2);
                shapes.Add(newShape);
                Refresh();
            }
        }

        private void scaleNonUniformButton_Click(object sender, EventArgs e)
        {
            if (selectedShape != null)
            {
                selectedShape.ScaleNonUniform(1.5, 0.8);
                Refresh();
            }
        }

        private void createTriangleButton_Click(object sender, EventArgs e)
        {
            // Comprimento de um lado do triângulo em centímetros
            double sideLengthInCm = 4.0; // Defina o comprimento desejado em centímetros

            // Converter centímetros para pixels usando DPI padrão (96 DPI)
            double dpi = 96.0;
            int sideLengthInPixels = (int)(sideLengthInCm * dpi / 2.54);

            // Altura do triângulo equilátero
            double heightInPixels = sideLengthInPixels * Math.Sqrt(3) / 2;

            int x = 150;

            var triangles = shapes?.Where(y => y?.TipoObjeto == ObjectType.EquilateralTriangle).ToList();

            if (triangles.Count > 0)
            {
                var lastTriangle = triangles[triangles.Count - 1];
                x = lastTriangle.LastPosX + (sideLengthInPixels) + spacing;
            }

            // Coordenadas dos vértices
            Point vertexA = new Point(x, 50); // Vértice superior
            Point vertexB = new Point(vertexA.X - sideLengthInPixels / 2, (int)(vertexA.Y + heightInPixels)); // Vértice inferior esquerdo
            Point vertexC = new Point(vertexA.X + sideLengthInPixels / 2, (int)(vertexA.Y + heightInPixels)); // Vértice inferior direito

            // Crie um triângulo equilátero em pixels
            Triangle triangle = new Triangle(id, new Point[] { vertexA, vertexB, vertexC }, ObjectType.EquilateralTriangle, x);
            triangles.Add(triangle);
            shapes.Add(triangle);

            id += 1;
            Refresh();
        }

        private void createTriangleIsoscelesButton_Click(object sender, EventArgs e)
        {
            //// Crie um triângulo e adicione à lista de shapes
            ////Triangle triangle = new Triangle(new Point(100, 100), new Point(200, 100), new Point(150, 200));

            //Point[] vertices = new Point[]
            //{
            //    new Point(150, 100), // Vértice superior
            //    new Point(100, 300), // Vértice inferior esquerdo
            //    new Point(200, 300) // Vértice inferior direito
            //};

            //Triangle triangle = new Triangle(id, vertices, ObjectType.IsoscelesTriangle, 0);

            //shapes.Add(triangle);

            // Determina a posição para o novo triângulo isósceles
            int x = 150;


            // Comprimento da base e da altura do triângulo em centímetros
            double baseLengthInCm = 2.0; // Defina o comprimento desejado em centímetros
            double heightLengthInCm = 5.0; // Defina o comprimento desejado em centímetros

            // Converter centímetros para pixels usando DPI padrão (96 DPI)
            double dpi = 96.0;
            int baseLengthInPixels = (int)(baseLengthInCm * dpi / 2.54);

            // Altura do triângulo equilátero
            double heightInPixels = (int)(heightLengthInCm * dpi / 2.54); ;

            var isoscelesTriangles = triangles?.Where(t => t.TipoObjeto == ObjectType.IsoscelesTriangle).ToList();

            if (isoscelesTriangles?.Any() ?? false)
            {
                // Se já existem triângulos isósceles, coloca o novo ao lado do último
                Triangle lastIsoscelesTriangle = isoscelesTriangles[isoscelesTriangles.Count - 1];
                x = lastIsoscelesTriangle.LastPosX + baseLengthInPixels * 2 + spacing;
            }

            // Calcula as coordenadas dos vértices do novo triângulo isósceles
            Point vertexA = new Point(x, 50); // Vértice superior
            Point vertexB = new Point(vertexA.X - (int)baseLengthInPixels, (int)(vertexA.Y + heightInPixels)); // Vértice inferior esquerdo
            Point vertexC = new Point(vertexA.X + (int)baseLengthInPixels, (int)(vertexA.Y + heightInPixels)); // Vértice inferior direito

            // Crie um triângulo isósceles
            Triangle newIsoscelesTriangle = new Triangle(id, new Point[] { vertexA, vertexB, vertexC }, ObjectType.IsoscelesTriangle, x);
            triangles.Add(newIsoscelesTriangle);
            shapes.Add(newIsoscelesTriangle);


            id += 1;
            Refresh();
        }

        private void createEscalenoTriangleButton_Click(object sender, EventArgs e)
        {

            int x = 150;
            double baseLengthInCm = 3.0; // Defina o comprimento desejado em centímetros

            // Converter centímetros para pixels usando DPI padrão (96 DPI)
            double dpi = 96.0;
            int baseLengthInPixels = (int)(baseLengthInCm * dpi / 2.54);

            //// Crie um triângulo escaleno com base na classe original
            //Point[] vertices = new Point[]
            //{
            //    new Point(100, 200), // Vértice A
            //    new Point(350, 200), // Vértice B (mesma altura que A)
            //    new Point(175, 100)  // Vértice C (acima da base)
            //};

            var escalenoTriangles = triangles?.Where(t => t.TipoObjeto == ObjectType.EscalenoTriangle).ToList();

            if (escalenoTriangles?.Any() ?? false)
            {
                // Se já existem triângulos isósceles, coloca o novo ao lado do último
                Triangle lastEscalenoTriangle = escalenoTriangles[escalenoTriangles.Count - 1];
                x = lastEscalenoTriangle.GetVertices()[2].X + spacing;
            }

            Point vertexA = new Point(x, 250);
            Point vertexB = new Point(vertexA.X - (int)baseLengthInPixels, (int)vertexA.Y);
            Point vertexC = new Point(vertexA.X + (int)baseLengthInPixels, (int)(vertexA.Y / 2));

            //Triangle triangle = new Triangle(id, vertices, ObjectType.EscalenoTriangle, 0);
            Triangle triangle = new Triangle(id, new[] { vertexA, vertexB, vertexC }, ObjectType.EscalenoTriangle, 0);

            triangles.Add(triangle);
            shapes.Add(triangle);

            id += 1;
            Refresh();
        }

        private void createSquareButton_Click(object sender, EventArgs e)
        {
            //// Crie um quadrado e adicione à lista de shapes
            //Square square = new Square(new Point(300, 100), 100);
            //shapes.Add(square);
            //Refresh();

            int x = 50;

            // Comprimento de um lado do quadrado em centímetros
            double sideLengthInCm = 4.0; // Defina o comprimento desejado em centímetros

            // Converter centímetros para pixels usando DPI padrão (96 DPI)
            double dpi = 96.0;
            int sideLengthInPixels = (int)(sideLengthInCm * dpi / 2.54);

            List<Shape> squares = new List<Shape>();

            squares = shapes.Where(y => y?.TipoObjeto == ObjectType.Square).ToList();

            if (squares.Count > 0)
            {
                Shape lastSquare = squares[squares.Count - 1];
                x = (lastSquare.LastPosX + sideLengthInPixels) + spacing;
            }

            // Coordenadas do canto superior esquerdo do quadrado
            Point topLeftCorner = new Point(x, 50); // Defina a posição desejada

            // Crie um retângulo (quadrado) em pixels
            Square rectangle = new Square(id, topLeftCorner, sideLengthInPixels, ObjectType.Square, x);
            shapes.Add(rectangle);
            squares.Add(rectangle);
            id += 1;
            Refresh();
        }

        private void createRectangleButton_Click(object sender, EventArgs e)
        {
            //// Crie um retângulo e adicione à lista de shapes
            //Rectangle rectangle = new Rectangle(new Point(50, 50), 150, 80, 0.0, ObjectType.Rectangle);
            //shapes.Add(rectangle);
            //Refresh();

            int x = 50;

            // Largura do retângulo em centímetros
            double widthInCm = 4.0; // Defina a largura desejada em centímetros

            // Altura do retângulo em centímetros
            double heightInCm = 2.0; // Defina a altura desejada em centímetros

            // Converter centímetros para pixels usando DPI padrão (96 DPI)
            double dpi = 96.0;
            int widthInPixels = (int)(widthInCm * dpi / 2.54);
            int heightInPixels = (int)(heightInCm * dpi / 2.54);

            var rectangles = shapes.Where(y => y?.TipoObjeto == ObjectType.Rectangle).ToList();

            if (rectangles.Count > 0)
            {
                Shape lastRectangle = rectangles[rectangles.Count - 1];
                x = (lastRectangle.LastPosX + widthInPixels) + spacing;
            }

            // Coordenadas do canto superior esquerdo do retângulo
            Point topLeftCorner = new Point(x, 50); // Defina a posição desejada

            // Crie um retângulo com largura e altura em pixels
            Rectangle newRectangle = new Rectangle(id, topLeftCorner, widthInPixels, heightInPixels, 0.0, ObjectType.Rectangle, x);
            shapes.Add(newRectangle);
            rectangles.Add(newRectangle);
            id += 1;
            Refresh();
        }

        private void panelTriangles_Paint(object sender, PaintEventArgs e)
        {
            var triangles = shapes?.Where(y =>
                (y?.TipoObjeto == ObjectType.EquilateralTriangle ||
                 y?.TipoObjeto == ObjectType.IsoscelesTriangle ||
                 y?.TipoObjeto == ObjectType.EscalenoTriangle)).ToList();

            if (triangles.Count > 0)
            {
                foreach (Shape shape in triangles)
                {
                    if (shape != null)
                    {
                        shape.DrawRotated(e.Graphics);
                    }
                }
            }
        }

        private void panelSquares_Paint(object sender, PaintEventArgs e)
        {
            var squares = shapes?.Where(y => y?.TipoObjeto == ObjectType.Square).ToList();

            if (squares.Count > 0)
            {
                foreach (Shape shape in squares)
                {
                    if (shape != null)
                    {
                        shape.DrawRotated(e.Graphics);
                    }
                }
            }
        }

        private void panelRectangles_Paint(object sender, PaintEventArgs e)
        {
            var rectangles = shapes?.Where(y => y?.TipoObjeto == ObjectType.Rectangle).ToList();

            if (rectangles.Count > 0)
            {
                foreach (Shape shape in rectangles)
                {
                    if (shape != null)
                    {
                        shape.DrawRotated(e.Graphics, shape.Id);
                    }
                }
            }
        }

        private Triangle CreateTriangle(int startX, int startY, double sideA, double sideB, double sideC)
        {
            // Verifique se os comprimentos dos lados formam um triângulo válido
            if (IsValidTriangle(sideA, sideB, sideC))
            {
                Point vertexA = new Point(startX, startY);
                Point vertexB = new Point(startX - (int)(sideA * PixelsPerCm), startY + (int)(sideC * PixelsPerCm));
                Point vertexC = new Point(startX + (int)(sideB * PixelsPerCm), startY + (int)(sideC * PixelsPerCm));

                // Verifique o tipo de triângulo com base nos comprimentos dos lados
                if (sideA == sideB && sideB == sideC)
                {
                    return new Triangle(id, new[] { vertexA, vertexB, vertexC }, ObjectType.EquilateralTriangle,
                        startX);
                }
                else if (sideA == sideB || sideA == sideC || sideB == sideC)
                {
                    return new Triangle(id, new[] { vertexA, vertexB, vertexC }, ObjectType.IsoscelesTriangle,
                        startX);
                }
                else
                {
                    return new Triangle(id, new[] { vertexA, vertexB, vertexC }, ObjectType.EscalenoTriangle,
                        startX);
                }
            }
            else
            {
                MessageBox.Show("Os comprimentos dos lados não formam um triângulo válido.", "Erro");
                return null;
            }
        }

        private bool IsValidTriangle(double sideA, double sideB, double sideC)
        {
            // Verifica a desigualdade triangular para determinar se os lados formam um triângulo válido
            return (sideA + sideB > sideC) && (sideA + sideC > sideB) && (sideB + sideC > sideA);
        }

        private double PixelsPerCm
        {
            get
            {
                // Calcule a quantidade de pixels por centímetro com base na DPI padrão (96 DPI)
                double dpi = 96.0;
                return dpi / 2.54;
            }
        }

        public Shape CloneShape(Shape originalShape)
        {
            var x = 0;
            if (originalShape.TipoObjeto == ObjectType.EquilateralTriangle || originalShape.TipoObjeto == ObjectType.EscalenoTriangle || originalShape.TipoObjeto == ObjectType.IsoscelesTriangle)
            {
                Triangle originalTriangle = (Triangle)originalShape;
                var startX = originalTriangle.LastPosX + spacing;

                Point vertexA = new Point((originalTriangle.GetVertices()[0].X + spacing), originalTriangle.GetVertices()[0].Y);
                Point vertexB = new Point((originalTriangle.GetVertices()[1].X + spacing), originalTriangle.GetVertices()[1].Y);
                Point vertexC = new Point((originalTriangle.GetVertices()[2].X + spacing), originalTriangle.GetVertices()[2].Y);

                var clonedTriangle = new Triangle(
                    id,
                    new[] { vertexA, vertexB, vertexC },
                    originalTriangle.TipoObjeto,
                    originalTriangle.RotationAngle,
                    startX);

                id += 1;

                return clonedTriangle;

            }
            else if (originalShape.TipoObjeto == ObjectType.Rectangle)
            {
                Rectangle originalRectangle = (Rectangle)originalShape;
                x = originalRectangle.LastPosX + originalRectangle.Width + spacing;

                var newTopLeft = originalRectangle.TopLeft with { X = x };

                var clonedRectangle = new Rectangle(
                    id,
                    newTopLeft,
                    originalRectangle.Width,
                    originalRectangle.Height,
                    originalRectangle.RotationAngle,
                    originalRectangle.TipoObjeto,
                    x);

                id += 1;

                return clonedRectangle;
            }
            else if (originalShape.TipoObjeto == ObjectType.Square)
            {
                Square originalSquare = (Square)originalShape;
                x = originalSquare.LastPosX + originalSquare.sideLength + spacing;

                var newTopLeft = originalSquare.topLeft with { X = x };

                var clonedSquare = new Square(
                    id,
                    newTopLeft,
                    originalSquare.sideLength,
                    originalSquare.RotationAngle,
                    originalSquare.TipoObjeto,
                    x);

                id += 1;

                return clonedSquare;
            }
            // Adicione mais verificações para outras formas, se necessário
            else
            {
                // Lida com outras formas ou retorne null se não reconhecida
                return null;
            }
        }

        private void CreateTriangleButton_Click(object sender, EventArgs e)
        {
            // Crie um triângulo com base nos valores inseridos pelo usuário
            if (ShowInputDialog(out double sideA, out double sideB, out double sideC))
            {
                // Determine a posição para o novo triângulo
                int x = 200;

                if (triangles.Count > 0)
                {
                    // Se já existem triângulos, coloca o novo ao lado do último
                    Triangle lastTriangle = triangles[triangles.Count - 1];
                    x = lastTriangle.GetVertices()[2].X + spacing;
                }

                Triangle newTriangle = CreateTriangle(x, 100, sideA, sideB, sideC);

                if (newTriangle != null)
                {
                    triangles.Add(newTriangle);
                    shapes.Add(newTriangle);
                    Refresh();
                }
            }
        }

        private bool ShowInputDialog(out double sideA, out double sideB, out double sideC)
        {
            using (InputDialogForm inputForm = new InputDialogForm())
            {
                var x = Left + (Width - inputForm.Width) / 2;
                var y = Top + (Height - inputForm.Height) / 2;

                inputForm.StartPosition = FormStartPosition.CenterParent;

                DialogResult result = inputForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    sideA = inputForm.SideA;
                    sideB = inputForm.SideB;
                    sideC = inputForm.SideC;
                    return true;
                }
            }

            sideA = sideB = sideC = 0.0;
            return false;
        }

        private bool ShowScaleInputDialog(out double scaleX, out double scaleY)
        {
            using (ScaleInputDialogForm inputForm = new ScaleInputDialogForm())
            {

                inputForm.StartPosition = FormStartPosition.CenterParent;

                DialogResult result = inputForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    scaleX = inputForm.ScaleX;
                    scaleY = inputForm.ScaleY;
                    return true;
                }
            }

            scaleX = scaleY = 0.0;
            return false;
        }

        private bool ShowTranslateInputDialog(out int posX, out int posY)
        {
            using (TranslateInputDialogForm inputForm = new TranslateInputDialogForm())
            {

                inputForm.StartPosition = FormStartPosition.CenterParent;

                DialogResult result = inputForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    posX = inputForm.PosX;
                    posY = inputForm.PosY;
                    return true;
                }
            }

            posX = posY = 0;
            return false;
        }

        private bool ShowSquareInputDialog(out double sideA, out double sideB, out double sideC, out double sideD)
        {
            using (SquareInputDialogForm inputForm = new SquareInputDialogForm())
            {

                inputForm.StartPosition = FormStartPosition.CenterParent;

                DialogResult result = inputForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    sideA = inputForm.SideA;
                    sideB = inputForm.SideB;
                    sideC = inputForm.SideC;
                    sideD = inputForm.SideD;
                    return true;
                }
            }

            sideA = sideB = sideC = sideD = 0.0;
            return false;
        }

        private bool ShowRotationInputDialog(out double rotationAngle)
        {
            using (DefaultInputDialogForm inputForm = new DefaultInputDialogForm())
            {

                inputForm.StartPosition = FormStartPosition.CenterParent;

                DialogResult result = inputForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    rotationAngle = inputForm.RotationAngle;
                    return true;
                }
            }

            rotationAngle = 0.0;
            return false;
        }

        private void scaleButton_Click(object sender, EventArgs e)
        {
            if (selectedShape != null)
            {
                if (ShowScaleInputDialog(out double scaleX, out double scaleY))
                {
                    if (scaleX == scaleY)
                    {
                        Shape copyShape = CloneShape(selectedShape);

                        if (copyShape != null)
                        {
                            copyShape.ScaleUniform(scaleX);
                            shapes.Add(copyShape);
                            selectedShape = copyShape;
                            UpdateTitle();
                            Refresh();
                        }
                    }
                    else
                    {
                        Shape copyShape = CloneShape(selectedShape);

                        if (copyShape != null)
                        {
                            copyShape.ScaleNonUniform(scaleX, scaleY);
                            shapes.Add(copyShape);
                            selectedShape = copyShape;
                            UpdateTitle();
                            Refresh();
                        }
                    }
                }
            }
        }

        private void buttonTranslation_Click(object sender, EventArgs e)
        {
            if (selectedShape != null)
            {
                if (ShowTranslateInputDialog(out int posX, out int posY))
                {

                    Shape copyShape = CloneShape(selectedShape);

                    if (copyShape != null)
                    {
                        copyShape.Translate(posX, posY);
                        shapes.Add(copyShape);
                        selectedShape = copyShape;
                        UpdateTitle();
                        Refresh();
                    }
                }
            }

        }

        private void buttonGerarSquare_Click(object sender, EventArgs e)
        {
            if (ShowSquareInputDialog(out double sideA, out double sideB, out double sideC, out double sideD))
            {
                if (sideA == sideB && sideB == sideC && sideC == sideD)
                {
                    var newSquare = CreateSquare(sideA);
                    squares.Add(newSquare);
                    shapes.Add(newSquare);
                    Refresh();
                }
                else
                {
                    var newRectangle = CreateRectangle(sideA, sideB, sideC, sideD);
                    rectangles.Add(newRectangle);
                    shapes.Add(newRectangle);
                    Refresh();
                }
            }
        }

        private Square CreateSquare(double sides)
        {
            int x = 50;

            // Comprimento de um lado do quadrado em centímetros
            double sideLengthInCm = sides; // Defina o comprimento desejado em centímetros

            // Converter centímetros para pixels usando DPI padrão (96 DPI)
            double dpi = 96.0;
            int sideLengthInPixels = (int)(sideLengthInCm * dpi / 2.54);

            List<Shape> squares = new List<Shape>();

            squares = shapes.Where(y => y?.TipoObjeto == ObjectType.Square).ToList();

            if (squares.Count > 0)
            {
                Shape lastSquare = squares[squares.Count - 1];
                x = (lastSquare.LastPosX + sideLengthInPixels) + spacing;
            }

            // Coordenadas do canto superior esquerdo do quadrado
            Point topLeftCorner = new Point(x, 50); // Defina a posição desejada

            id += 1;

            // Crie um retângulo (quadrado) em pixels
            Square newSquare = new Square(id, topLeftCorner, sideLengthInPixels, ObjectType.Square, x);
            return newSquare;
        }

        private Rectangle CreateRectangle(double sideA, double sideB, double sideC, double sideD)
        {
            int x = 50;

            // Largura do retângulo em centímetros
            double widthInCm = sideB + sideD; // Defina a largura desejada em centímetros

            // Altura do retângulo em centímetros
            double heightInCm = sideA + sideC; // Defina a altura desejada em centímetros

            // Converter centímetros para pixels usando DPI padrão (96 DPI)
            double dpi = 96.0;
            int widthInPixels = (int)(widthInCm * dpi / 2.54);
            int heightInPixels = (int)(heightInCm * dpi / 2.54);

            var rectangles = shapes.Where(y => y?.TipoObjeto == ObjectType.Rectangle).ToList();

            if (rectangles.Count > 0)
            {
                Shape lastRectangle = rectangles[rectangles.Count - 1];
                x = (lastRectangle.LastPosX + widthInPixels) + spacing;
            }

            // Coordenadas do canto superior esquerdo do retângulo
            Point topLeftCorner = new Point(x, 50); // Defina a posição desejada

            // Crie um retângulo com largura e altura em pixels
            id += 1;
            Rectangle newRectangle = new Rectangle(id, topLeftCorner, widthInPixels, heightInPixels, 0.0, ObjectType.Rectangle, x);

            return newRectangle;
        }

        private void saveImageButton_Click(object sender, EventArgs e)
        {
            // Crie uma imagem que tenha o mesmo tamanho que o seu formulário
            Bitmap bmp = new Bitmap(this.Width, this.Height);

            // Crie um objeto Graphics a partir da imagem
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Desenhe todos os objetos na imagem

                foreach (var shape in shapes)
                {
                    if (shape != null)
                    {
                        shape.DrawRotated(g);
                    }
                }

                //foreach (Triangle triangle in triangles)
                //{
                //    if (triangle != null)
                //    {
                //        triangle.vertices[0].Y += 350;
                //        triangle.vertices[0].X += 350;
                //        triangle.Draw(g);
                //    }
                //}

                //foreach (Square square in squares)
                //{
                //    if (square != null)
                //    {
                //        square.topLeft.Y += 250;
                //        square.topLeft.X += 50;
                //        square.Draw(g);
                //    }
                //}

                //foreach (Rectangle rectangle in rectangles)
                //{
                //    if (rectangle != null)
                //    {
                //        rectangle.topLeft.Y -= 350;
                //        rectangle.topLeft.X += 100;
                //        rectangle.Draw(g);
                //    }
                //}
            }

            // Defina um nome de arquivo e caminho para salvar a imagem
            string fileName = $"objetos_{DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss")}.png"; // Escolha o nome desejado
            bmp.Save(fileName, ImageFormat.Png);

            // Libere a imagem
            bmp.Dispose();

            // Exiba uma mensagem informando que a imagem foi salva com sucesso
            MessageBox.Show("A imagem foi salva com sucesso como " + fileName, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonRotation_Click(object sender, EventArgs e)
        {
            if (selectedShape != null)
            {
                if (ShowRotationInputDialog(out double rotationAngle))
                {

                    Shape copyShape = CloneShape(selectedShape);

                    if (copyShape != null)
                    {
                        copyShape.RotationAngle += rotationAngle;
                        shapes.Add(copyShape);
                        selectedShape = copyShape;
                        UpdateTitle();
                        Refresh();
                    }
                }
            }

        }
    }

    public abstract class Shape
    {
        public int Id { get; set; }
        public double RotationAngle { get; set; } = 0;
        public ObjectType TipoObjeto { get; set; }
        public int LastPosX { get; set; }
        public abstract void Draw(Graphics g);
        public abstract void DrawRotated(Graphics graphics);
        public abstract void DrawRotated(Graphics graphics, int id);
        public abstract bool Contains(Point point);
        public abstract void Translate(int dx, int dy);
        public abstract void ScaleUniform(double scaleFactor);
        public abstract void ScaleNonUniform(double scaleX, double scaleY);
    }

    class Triangle : Shape
    {
        public Point[] vertices;
        public double scale;

        public Triangle(int id, Point p1, Point p2, Point p3, ObjectType tipoObjeto, int lastPosX)
        {
            Id = id;
            vertices = new Point[] { p1, p2, p3 };
            scale = 1.0;
            TipoObjeto = tipoObjeto;
            LastPosX = lastPosX;
        }

        public Triangle(int id, Point[] vertices, ObjectType tipoObjeto, int lastPosX)
        {
            Id = id;
            this.vertices = vertices;
            scale = 1.0;
            TipoObjeto = tipoObjeto;
            LastPosX = lastPosX;
        }

        public Triangle(int id, Point[] vertices, ObjectType tipoObjeto, double rotationAngle, int lastPosX)
        {
            Id = id;
            this.vertices = vertices;
            scale = 1.0;
            RotationAngle = rotationAngle;
            TipoObjeto = tipoObjeto;
            LastPosX = lastPosX;
        }

        public override void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color.Blue);
            g.FillPolygon(brush, vertices);

            // Desenha o contorno do triângulo (opcional)
            Pen pen = new Pen(Color.Black, 2);
            g.DrawPolygon(pen, vertices);
        }

        public override void DrawRotated(Graphics graphics)
        {
            // Cria uma matriz de transformação para realizar a rotação
            Matrix transformationMatrix = new Matrix();
            transformationMatrix.RotateAt((float)RotationAngle, CalculateCenter());

            // Aplica a transformação à tela
            graphics.Transform = transformationMatrix;

            // Desenha o triângulo com a rotação aplicada
            Draw(graphics);
        }

        public override void DrawRotated(Graphics graphics, int id)
        {
            throw new NotImplementedException();
        }

        public override bool Contains(Point point)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddPolygon(vertices);
            return path.IsVisible(point);
        }

        public override void Translate(int dx, int dy)
        {
            for (int i = 0; i < 3; i++)
            {
                vertices[i] = new Point(vertices[i].X + dx, vertices[i].Y + dy);
            }
        }

        public Point CalculateCenter()
        {
            int sumX = 0;
            int sumY = 0;

            foreach (Point vertex in vertices)
            {
                sumX += vertex.X;
                sumY += vertex.Y;
            }

            int centerX = sumX / vertices.Length;
            int centerY = sumY / vertices.Length;

            return new Point(centerX, centerY);
        }

        public override void ScaleUniform(double scaleFactor)
        {
            if (scaleFactor != 0.0)
            {
                // Atualiza o fator de escala uniforme
                scale *= scaleFactor;

                // Calcula o centro do triângulo
                Point center = CalculateCenter();

                // Aplica o fator de escala a cada vértice
                for (int i = 0; i < vertices.Length; i++)
                {
                    double deltaX = vertices[i].X - center.X;
                    double deltaY = vertices[i].Y - center.Y;

                    double newX = center.X + deltaX * scale;
                    double newY = center.Y + deltaY * scale;

                    vertices[i] = new Point((int)newX, (int)newY);
                }
            }
        }

        public override void ScaleNonUniform(double scaleX, double scaleY)
        {
            // Calcula o centro do triângulo
            Point center = CalculateCenter();

            // Aplica o fator de escala a cada vértice separadamente
            for (int i = 0; i < vertices.Length; i++)
            {
                double deltaX = vertices[i].X - center.X;
                double deltaY = vertices[i].Y - center.Y;

                double newX = center.X + deltaX * scaleX;
                double newY = center.Y + deltaY * scaleY;

                vertices[i] = new Point((int)newX, (int)newY);
            }
        }

        public Point[] GetVertices()
        {
            return vertices;
        }
    }

    class Square : Shape
    {
        public Point topLeft;
        public int sideLength;
        public int Width;
        public int Height;

        public Square(int id, Point topLeft, int sideLength, ObjectType tipoObjeto, int lastPosX)
        {
            Id = id;
            this.topLeft = topLeft;
            this.sideLength = sideLength;
            this.Width = sideLength;
            this.Height = sideLength;
            TipoObjeto = tipoObjeto;
            LastPosX = lastPosX;
        }

        public Square(int id, Point topLeft, int sideLength, double rotationAngle, ObjectType tipoObjeto, int lastPosX)
        {
            Id = id;
            this.topLeft = topLeft;
            this.sideLength = sideLength;
            this.Width = sideLength;
            this.Height = sideLength;
            RotationAngle = rotationAngle;
            TipoObjeto = tipoObjeto;
            LastPosX = lastPosX;
        }

        public override void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color.Yellow);
            g.FillRectangle(brush, topLeft.X, topLeft.Y, Width, Height);

            Pen pen = new Pen(Color.Black, 2);
            g.DrawRectangle(pen, topLeft.X, topLeft.Y, Width, Height);
        }

        public override void DrawRotated(Graphics graphics)
        {
            // Cria uma matriz de transformação para realizar a rotação
            Matrix transformationMatrix = new Matrix();
            transformationMatrix.RotateAt((float)RotationAngle, new Point(topLeft.X + Width / 2, topLeft.Y + Height / 2));

            // Aplica a transformação à tela
            graphics.Transform = transformationMatrix;

            // Define o retângulo a ser desenhado após a rotação
            //Rectangle rotatedRectangle = new Rectangle(Id, topLeft, sideLength, sideLength, 0.0, ObjectType.Square, LastPosX);

            // Preenche o retângulo com a cor definida
            Brush brush = new SolidBrush(Color.Yellow);
            graphics.FillRectangle(brush, topLeft.X, topLeft.Y, Width, Height);
        }

        public override void DrawRotated(Graphics graphics, int id)
        {
            throw new NotImplementedException();
        }

        public override bool Contains(Point point)
        {
            return (point.X >= topLeft.X && point.X <= topLeft.X + sideLength &&
                    point.Y >= topLeft.Y && point.Y <= topLeft.Y + sideLength);
        }

        public override void Translate(int dx, int dy)
        {
            topLeft = new Point(topLeft.X + dx, topLeft.Y + dy);
            LastPosX += dx;
        }

        public override void ScaleUniform(double scaleFactor)
        {
            if (scaleFactor == 0.0)
            {
                Width = 1;
                Height = 1;
            }
            else
            {
                Width = (int)(Width * scaleFactor);
                Height = (int)(Height * scaleFactor);
            }

        }

        public override void ScaleNonUniform(double scaleX, double scaleY)
        {
            Width = (scaleX == 0.0 ? (int)Width : (int)(Width * scaleX));
            Height = (scaleY == 0.0 ? (int)Height : (int)(Height * scaleY));
        }
    }

    class Rectangle : Shape
    {
        public Point TopLeft;
        public int Width;
        public int Height;

        public Rectangle(int id, Point topLeft, int width, int height, double rotationAngle, ObjectType tipoObjeto, int lastPosX)
        {
            Id = id;
            this.TopLeft = topLeft;
            this.Width = width;
            this.Height = height;
            this.RotationAngle = rotationAngle;
            TipoObjeto = tipoObjeto;
            LastPosX = lastPosX;
        }

        public override void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color.Red);
            g.FillRectangle(brush, TopLeft.X, TopLeft.Y, Width, Height);

            Pen pen = new Pen(Color.Black, 2);
            g.DrawRectangle(pen, TopLeft.X, TopLeft.Y, Width, Height);
        }

        public override void DrawRotated(Graphics graphics)
        {
            // Cria uma matriz de transformação para realizar a rotação
            Matrix transformationMatrix = new Matrix();
            transformationMatrix.RotateAt((float)base.RotationAngle, new Point(TopLeft.X + Width / 2, TopLeft.Y + Height / 2));

            // Aplica a transformação à tela
            graphics.Transform = transformationMatrix;

            // Define o retângulo a ser desenhado após a rotação
            //Rectangle rotatedRectangle = new Rectangle(Id, topLeft, sideLength, sideLength, 0.0, ObjectType.Square, LastPosX);

            // Preenche o retângulo com a cor definida
            Brush brush = new SolidBrush(Color.Yellow);
            graphics.FillRectangle(brush, TopLeft.X, TopLeft.Y, Width, Height);
        }

        public override bool Contains(Point point)
        {
            return (point.X >= TopLeft.X && point.X <= TopLeft.X + Width &&
                    point.Y >= TopLeft.Y && point.Y <= TopLeft.Y + Height);
        }

        public Point CalculateCenter()
        {
            int centerX = TopLeft.X + Width / 2;
            int centerY = TopLeft.Y + Height / 2;
            return new Point(centerX, centerY);
        }
        public override void DrawRotated(Graphics graphics, int id)
        {
            // Cria uma matriz de transformação para realizar a rotação
            Matrix transformationMatrix = new Matrix();
            transformationMatrix.RotateAt((float)base.RotationAngle, new Point(TopLeft.X + Width / 2, TopLeft.Y + Height / 2));

            // Aplica a transformação à tela
            graphics.Transform = transformationMatrix;

            // Define o retângulo a ser desenhado após a rotação
            //Rectangle rotatedRectangle = new Rectangle(Id, topLeft, width, height, 0.0, ObjectType.Rectangle, 0);

            //// Gera uma cor aleatória
            //Random random = new Random();
            //Color randomColor = Color.FromArgb(random.Next(256) + id, random.Next(256) + id, random.Next(256) + id);


            //// Cria um SolidBrush com a cor aleatória
            //Brush randomBrush = new SolidBrush(randomColor);
            //graphics.FillRectangle(randomBrush, topLeft.X, topLeft.Y, width, height);
            Brush brush = new SolidBrush(Color.Red);
            graphics.FillRectangle(brush, TopLeft.X, TopLeft.Y, Width, Height);

        }

        private Point RotatePoint(Point point, Point center, double angle)
        {
            double x = point.X - center.X;
            double y = point.Y - center.Y;

            double newX = x * Math.Cos(angle) - y * Math.Sin(angle);
            double newY = x * Math.Sin(angle) + y * Math.Cos(angle);

            return new Point((int)newX + center.X, (int)newY + center.Y);
        }

        public override void Translate(int dx, int dy)
        {
            TopLeft = new Point(TopLeft.X + dx, TopLeft.Y + dy);
        }

        public override void ScaleUniform(double scaleFactor)
        {
            if (scaleFactor != 0.0)
            {
                Width = (int)(Width * scaleFactor);
                Height = (int)(Height * scaleFactor);
            }
        }

        public override void ScaleNonUniform(double scaleX, double scaleY)
        {
            Width = (scaleX == 0.0 ? (int)Width : (int)(Width * scaleX));
            Height = (scaleY == 0.0 ? (int)Height : (int)(Height * scaleY));
        }
    }

    public enum ObjectType
    {
        EquilateralTriangle,
        IsoscelesTriangle,
        EscalenoTriangle,
        Square,
        Rectangle
    }

}
