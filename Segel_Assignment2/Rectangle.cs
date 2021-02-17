﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segel_Assignment2
{
    public class Rectangle
    {
        private int length;
        private int width;

        //default contructor
        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        //non-default constructor
        public Rectangle(int l, int w)
        {
            length = l;
            width = w;
        }

        public int GetLenght()
        {
            return length;
        }

        public int SetLength(int l)
        {
            length = l;
            return length;
        }

        public int GetWidth()
        {
            return width;
        }

        public int SetWidth(int w)
        {
            width = w;
            return width;
        }

        public int GetPerimeter()
        {
            return 2 * (length + width);
        }

        public int GetArea()
        {
            return length * width;
        }
    }
}

