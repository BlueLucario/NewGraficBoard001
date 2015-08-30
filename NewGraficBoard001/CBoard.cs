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
    class CBoard
    {
        private Canvas m_canvas;
        private int m_rows;
        private int m_columns;
        private CMarker[,] m_board;
        public CBoard(ref Canvas canvas, int rows, int columns)
        {
            m_canvas = canvas;
            m_rows = rows;
            m_columns = columns;
            m_board = new CMarker[m_rows, m_columns];
            Clear();
        }

        public void Clear()
        {
            for (int i = 0; i < m_rows; i++)
            {
                for (int j = 0; j < m_columns; j++)
                {
                    m_board[i, j] = null;
                }
            }
        }

        public CMarker this[int row, int column]
        {
            get
            {
                return m_board[row, column];
            }
            set
            {
                m_board[row, column] = value;
            }
        }

        public int Rows
        {
            get
            {
                return m_rows;
            }
        }

        public int Columns
        {
            get
            {
                return m_columns;
            }
        }

        public void Draw()
        {
            //draw board outline :)
            for (int i = 0; i <= m_rows; i++)
            {
                Line line = new Line();
                line.X1 = 0;
                line.Y1 = i * m_canvas.Height / m_rows;
                line.X2 = m_canvas.Width;
                line.Y2 = i * m_canvas.Height / m_rows;
                line.Stroke = Brushes.Black;
                line.StrokeThickness = 5;
                Canvas.SetTop(line, 0);
                Canvas.SetLeft(line, 0);
                m_canvas.Children.Add(line);
            }
            for (int i = 0; i <= m_columns; i++)
            {
                Line line = new Line();
                line.X1 = i * m_canvas.Width / m_columns;
                line.Y1 = 0;
                line.X2 = i * m_canvas.Width / m_columns;
                line.Y2 = m_canvas.Height;
                line.Stroke = Brushes.Black;
                line.StrokeThickness = 5;
                Canvas.SetTop(line, 0);
                Canvas.SetLeft(line, 0);
                m_canvas.Children.Add(line);
                //end draw board outline :P
            }

            //Draw markers :)
            int vsize = (int)(m_canvas.Height / m_rows);
            int hsize = (int)(m_canvas.Width / m_columns);
            for (int i = 0; i < m_rows; i++)
            {
                for (int j = 0; j < m_columns; j++)
                {
                    if (m_board[i, j] != null)
                    {
                        m_board[i, j].Draw(hsize*j,vsize*i);
                    }
                }
            }
        }

        public void GetRC(double X,double Y,out int row, out int column)
        {
            row = (int)(Y / m_canvas.ActualHeight * m_rows);
            column = (int)(X / m_canvas.ActualWidth * m_columns);
        }


    }
}
