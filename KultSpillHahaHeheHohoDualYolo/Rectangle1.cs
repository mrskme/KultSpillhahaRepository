﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KultSpillHahaHeheHohoDualYolo
{
    class Rectangle1
    {
        private string _name;
        private int _width;
        private int _height;
        private Color _color;
         protected PictureBox newRectangle { get; } = new PictureBox(); 

        public Rectangle1(string name, int width, int height, Color color)
        {
            _name = name;
            _width = width;
            _height = height;
            newRectangle.BackColor = color;
        }

        public void SpawnRectangle(Form formInstance, int x, int y/*, Color color*/)
        {
            newRectangle.Name = _name;
            newRectangle.Width = _width;
            newRectangle.Height = _height;
            //newRectangle.BackColor = color;
            newRectangle.Location = new Point(x,y);
            formInstance.Controls.Add(newRectangle);
        }
    }
}
