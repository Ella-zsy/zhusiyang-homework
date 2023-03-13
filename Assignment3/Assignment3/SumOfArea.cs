using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class SumOfArea
    {
        abstract class FigureShape///抽象类
        {
            public abstract bool legal();
            public abstract double GraphicArea();
        }

        class Rectangle : FigureShape///长方形继承抽象类
        {
            private double area;
            private int _RectangleLength;
            public int RectangleLength
            {
                get => _RectangleLength;
                set => _RectangleLength = value;
            }
            private int _RectangleWidth;
            public int RectangleWidth
            {
                get => _RectangleWidth;
                set => _RectangleWidth = value;
            }
            public override bool legal()
            {
                if (_RectangleLength <= 0 || _RectangleWidth <= 0)
                    return false;
                else
                    return true;
            }

            public override double GraphicArea()
            {
                area = _RectangleLength * _RectangleWidth;
                return area;
            }
        }

        class Square : FigureShape///正方形继承抽象类
        {
            private double area;
            private int _elongate;
            public int elongate
            {
                get => _elongate;
                set => _elongate = value;
            }
            public override bool legal()
            {
                if (_elongate <= 0)
                    return false;
                else
                    return true;
            }

            public override double GraphicArea()
            {
                area = _elongate * _elongate;
                return area;
            }
        }

        class Triangle : FigureShape///三角形继承抽象类
        {
            private double area;
            private int _a;
            public int a
            {
                get => _a;
                set => _a = value;
            }
            private int _b;
            public int b
            {
                get => _b;
                set => _b = value;
            }
            private int _c;
            public int c
            {
                get => _c;
                set => _c = value;
            }
            public override bool legal()
            {
                if (a + b <= c || a + c <= b || b + c <= a || (a < 0 || b < 0 || c < 0))
                    return false;
                else
                    return true;
            }
            public override double GraphicArea()
            {
                area = Math.Pow((a + b + c) * (a + b) * (a + c) * (b + c), 0.5);
                return area;
            }
        }

        class Circle : FigureShape///圆形继承抽象类
        {
            private double area;
            private int _r;
            public int r
            {
                get => _r;
                set => _r = value;
            }
            public override bool legal()
            {
                if (_r <= 0)
                    return false;
                else
                    return true;
            }

            public override double GraphicArea()
            {
                area = Math.PI * _r * _r;
                return area;
            }
        }

        static void Main(string[] args)
        {
            Random rd = new Random();
            int s;
            double SumArea = 0;
            for (int i = 0; i < 10; i++)
            {
                s = rd.Next(0, 3);
                switch (s)
                {
                    case 0:
                        Rectangle rectangle = new Rectangle();
                        rectangle.RectangleLength = rd.Next(0, 30);
                        rectangle.RectangleWidth = rd.Next(0, 30);
                        SumArea += rectangle.GraphicArea();
                        Console.WriteLine($"生成了长为{rectangle.RectangleLength},宽为{rectangle.RectangleWidth}面积为{rectangle.GraphicArea()}的长方形");
                        break;
                    case 1:
                        Square square = new Square();
                        square.elongate = rd.Next(0, 30);
                        SumArea += square.GraphicArea();
                        Console.WriteLine($"生成了边长为{square.elongate}，面积为{square.GraphicArea()}的正方形");
                        break;
                    case 2:
                        Triangle triangle = new Triangle();
                        triangle.a = rd.Next(0, 30);
                        triangle.b = rd.Next(0, 30);
                        triangle.c = rd.Next(0, 30);
                        while (triangle.legal() == false)
                        {
                            triangle.a = rd.Next(0, 30);
                            triangle.b = rd.Next(0, 30);
                            triangle.c = rd.Next(0, 30);
                        }
                        SumArea += triangle.GraphicArea();
                        Console.WriteLine($"生成了边长为{triangle.a}、{triangle.b}、{triangle.c}，面积为{triangle.GraphicArea()}的三角形");
                        break;
                    case 3:
                        Circle circle = new Circle();
                        circle.r = rd.Next(0, 30);
                        SumArea += circle.GraphicArea();
                        Console.WriteLine($"生成了半径为{circle.r},面积为{circle.GraphicArea()}的圆形");
                        break;
                }
            }
            Console.WriteLine("随机生成的十个图形的总面积为:{0}", SumArea);
        }
    }
}
