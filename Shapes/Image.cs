﻿using System;
using System.Collections.Generic;
using System.Text;


namespace NixSolHomeTask1
{
    class Image : Point
    {
        public List<Point> figures = new List<Point>();

        public Image(double anchorPointX, double anchorPointY)
            : base(anchorPointX, anchorPointY) { }

        public void AddFigure(Point figure)
        {
            figures.Add(figure);
        }

        public override void Scale(double factor)
        {
            foreach(var figure in figures)
                figure.Scale(factor);
        }
    }
}
