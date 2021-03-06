﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNAssignment02
{
    public class Rectangle
    {
        private int width;
        private int length;

        public int Width { get => width; set => width = value; }
        public int Length { get => length; set => length = value; }

        //constructors
        public Rectangle()
        {
            width = 1;
            length = 1;
        }
        public Rectangle(int width, int length)
        {
            this.width = width;
            this.length = length;
        }
        public int GetLength()
        {
            return this.length;
        }
        public int SetLength(int length)
        {
            this.length = length;
            return this.length;
        }
        public int GetWidth()
        {
            return width;
        }
        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }
        public int GetPerimeter()
        {
            int perimeter = width * 2 + length * 2;
            return perimeter;
        }
        /// <summary>
        /// calculates area then returns it
        /// </summary>
        /// <returns></returns>
        public int GetArea()
        {
            int area = width * length;
            return area;
        }

    }
}
