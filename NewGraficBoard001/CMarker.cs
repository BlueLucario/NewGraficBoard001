using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace NewGraficBoard001
{
    class CMarker
    {
        private Canvas m_canvas;
        private string m_name;
        private int m_size = 80;//This needs to be done later
        public CMarker(ref Canvas canvas, string name)
        {
            m_name = name;
            m_canvas = canvas;

        }

        public void Draw(int X, int Y)
        {
            if (m_name.ToUpper() == "X")
            {
                Line line = new Line();
                line.Stroke = Brushes.Black;
                line.StrokeThickness = 3;

                line.X1 = 2;
                line.Y1 = 2;
                line.X2 = m_size - 2;
                line.Y2 = m_size - 2;
                Canvas.SetTop(line, Y);
                Canvas.SetLeft(line, X);
                m_canvas.Children.Add(line);

                Line line2 = new Line();
                line2.Stroke = Brushes.Black;
                line2.StrokeThickness = 3;

                line2.X1 = 2;
                line2.Y1 = m_size - 2;
                line2.X2 = m_size - 2;
                line2.Y2 = 2;
                Canvas.SetTop(line2, Y);
                Canvas.SetLeft(line2, X);
                m_canvas.Children.Add(line2);

            }
            else if (m_name.ToUpper() == "O" || m_name == "0" || m_name == ")")
            {
                Ellipse circle = new Ellipse();
                circle.Width = m_size;
                circle.Height = m_size;
                circle.Stroke = Brushes.Black;
                circle.StrokeThickness = 3;

                Canvas.SetTop(circle, Y);
                Canvas.SetLeft(circle, X);
                m_canvas.Children.Add(circle);
            }
            else if (m_name == "*" || m_name == "8")
            {
                Ellipse circle = new Ellipse();
                circle.Width = m_size;
                circle.Height = m_size;
                circle.Stroke = Brushes.Black;
                circle.StrokeThickness = 3;
                Canvas.SetTop(circle, Y);
                Canvas.SetLeft(circle, X);
                m_canvas.Children.Add(circle);

                Line line1 = new Line();
                line1.Stroke = Brushes.Blue;
                line1.StrokeThickness = 3;
                line1.X1 = m_size * 0.5;
                line1.Y1 = m_size * 0;
                line1.X2 = m_size * 0.85;
                line1.Y2 = m_size * 0.85;//1
                Canvas.SetTop(line1, Y);
                Canvas.SetLeft(line1, X);
                m_canvas.Children.Add(line1);

                Line line2 = new Line();
                line2.Stroke = Brushes.Green;
                line2.StrokeThickness = 3;
                line2.X1 = m_size * 0.85;
                line2.Y1 = m_size * 0.85;//1
                line2.X2 = m_size * 0.05;
                line2.Y2 = m_size * 0.34;//38
                Canvas.SetTop(line2, Y);
                Canvas.SetLeft(line2, X);
                m_canvas.Children.Add(line2);

                Line line3 = new Line();
                line3.Stroke = Brushes.Yellow;
                line3.StrokeThickness = 3;
                line3.X1 = m_size * 0.05;
                line3.Y1 = m_size * 0.34;//38
                line3.X2 = m_size * 0.95;
                line3.Y2 = m_size * 0.34;//38
                Canvas.SetTop(line3, Y);
                Canvas.SetLeft(line3, X);
                m_canvas.Children.Add(line3);

                Line line4 = new Line();
                line4.Stroke = Brushes.Red;
                line4.StrokeThickness = 3;
                line4.X1 = m_size * 0.95;
                line4.Y1 = m_size * 0.34;//38
                line4.X2 = m_size * 0.15;
                line4.Y2 = m_size * 0.85;//1
                Canvas.SetTop(line4, Y);
                Canvas.SetLeft(line4, X);
                m_canvas.Children.Add(line4);

                Line line5 = new Line();
                line5.Stroke = Brushes.Purple;
                line5.StrokeThickness = 3;
                line5.X1 = m_size * 0.15;
                line5.Y1 = m_size * 0.85;//1
                line5.X2 = m_size * 0.5;
                line5.Y2 = m_size * 0;
                Canvas.SetTop(line5, Y);
                Canvas.SetLeft(line5, X);
                m_canvas.Children.Add(line5);
            }
            else
            {
                throw new Exception("Illegal Marker name... Bub :P");
            }
        }

    }
}
