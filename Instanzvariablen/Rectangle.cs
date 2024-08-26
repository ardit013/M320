using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instanzvariablen
{
    public class Rectangle
    {
        private int length;
        private readonly int width;
        private int height = 10;

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public Rectangle() { }

        public int GetLength()
        {
            return length;
        }

        public int GetWidth()
        {
            return width;
        }

        public int GetHeight()
        {
            return height;
        }

        public void SetHeight(int height)
        {
            this.height = height;
        }
    }
}
