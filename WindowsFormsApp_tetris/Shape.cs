using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_tetris
{
    class Shape
    {
        private int[,] horizontal;
        private int[,] rotation1;
        private int[,] rotation2;
        private int[,] rotation3;
        public int state;
        public int rotationsCount;
        public int[,] GetShape()
        {
            switch (state)
            {
                default:
                  return horizontal;

            }
        }
        public Shape(int[,] horizontal, int[,] rotation1, int[,] rotation2, int[,] rotation3)
        {
            state = 0;
            rotationsCount = 4;
            this.horizontal = horizontal;
            this.rotation1 = rotation1;
            this.rotation2 = rotation2;
            this.rotation3 = rotation3;
        }
        public Shape(int[,] horizontal, int[,] rotation1, int[,] rotation2)
        {
            state = 0;
            rotationsCount = 3;
            this.horizontal = horizontal;
            this.rotation1 = rotation1;
            this.rotation2 = rotation2;
        }
        public Shape(int[,] horizontal, int[,] rotation1)
        {
            state = 0;
            rotationsCount = 2;
            this.horizontal = horizontal;
            this.rotation1 = rotation1;
        }
        public Shape(int[,] horizontal)
        {
            state = 0;
            rotationsCount = 1;
            this.horizontal = horizontal;
        }
    }
}
