using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_tetris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[,] mat = new int[18, 10];
        int[,] currentShape;
        const int recSizeX = 25;
        const int recSizeY = 25;

        private void Form1_Load(object sender, EventArgs e)
        {
            scorelabel.Location = new Point(mat.GetLength(1) * recSizeX + 5, scorelabel.Location.Y);
            this.Width = (int)Math.Round(mat.GetLength(1) * recSizeX * 1.4);
            this.Height = (int)Math.Round(mat.GetLength(0) * recSizeY * 1.1);

            FillMat();
            GenerateShapes();

            GameUpdateTimer.Start();
        }

        private void GameUpdateTimer_Tick(object sender, EventArgs e)
        {

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DisplayMat2();
            //for(int y=0;y<mat.GetLength(0);y++)
            //    for(int x=0;x<mat.GetLength(1);x++)
            //       DisplayMat(x*recSizeX, y*recSizeY);
        }

        private void FillMat()
        {
            for (int i = 0; i < mat.GetLength(0); i++)
                for (int j = 0; j < mat.GetLength(1); j++)
                    mat[i, j] = 0;
        }

        private void DisplayMat(int x, int y)
        {
            SolidBrush myBrush = new SolidBrush(Color.Black);
            Pen p = new Pen(myBrush);
            Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.DrawRectangle(p, new Rectangle(x, y, recSizeX, recSizeY));
            myBrush.Dispose();
            formGraphics.Dispose();
        }
        private void DisplayMat2()
        {
            SolidBrush myBrush = new SolidBrush(Color.Black);
            Pen p = new Pen(myBrush);
            Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.DrawRectangle(p, new Rectangle(2, 2, recSizeX * mat.GetLength(1), recSizeY * mat.GetLength(0)));
            myBrush.Dispose();
            formGraphics.Dispose();
        }
        private void GenerateShapes()
        {
            //Square:
            int[,] shape1h = new int[,] { {0,0,0,0 },{0,1,1,0 },{0,1,1,0 },{0,0,0,0 } };
            Shape shape1 = new Shape(shape1h);
            //Line:
            int[,] shape2h = new int[,] { {0,1,0,0 }, { 0, 1, 0, 0 }, { 0, 1, 0, 0 }, { 0, 1, 0, 0 } };
            int[,] shape2r1 = new int[,] { {0,0,0,0 }, { 1, 1, 1, 1 } , { 0, 0, 0, 0 } , { 0, 0, 0, 0 } };
            Shape shape2 = new Shape(shape2h, shape2r1);
            //T Shape:
            int[,] shape3h = new int[,] { { 0, 1, 0, 0 }, { 1, 1, 1, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
            int[,] shape3r1 = new int[,] { { 0, 1, 0, 0 }, { 0, 1, 1, 0 }, { 0, 1, 0, 0 }, { 0, 0, 0, 0 } };
            int[,] shape3r2 = new int[,] { { 0, 0, 0, 0 }, { 1, 1, 1, 0 }, { 0, 1, 0, 0 }, { 0, 0, 0, 0 } };
            int[,] shape3r3 = new int[,] { { 0, 1, 0, 0 }, { 1, 1, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 0, 0 } };
            Shape shape3 = new Shape(shape3h, shape3r1, shape3r2, shape3r3);
            //Stairs1:
            int[,] shape4h = new int[,] { { 0, 0, 0, 0 }, { 1, 1, 0, 0 }, { 0, 1, 1, 0 }, { 0, 0, 0, 0 } };
            int[,] shape4r1 = new int[,] { { 0, 1, 0, 0 }, { 1, 1, 0, 0 }, { 1, 0, 0, 0 }, { 0, 0, 0, 0 } };
            Shape shape4 = new Shape(shape4h, shape4r1);
            //Stairs2:
            int[,] shape5h = new int[,] { { 0, 0, 0, 0 }, { 0, 1, 1, 0 }, { 1, 1, 0, 0 }, { 0, 0, 0, 0 } };
            int[,] shape5r1 = new int[,]{ { 0, 1, 0, 0 }, { 0, 1, 1, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 0 } }; 
        }
    }
}
