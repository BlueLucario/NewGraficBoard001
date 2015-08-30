using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace NewGraficBoard001
{
    class CGame
    {
        private Canvas m_canvas;
        private CBoard m_board;
        public CGame(ref Canvas canvas)
        {
            m_canvas = canvas;
        }

        public void Play()
        {
            m_board = new CBoard(ref m_canvas, 6, 8);
            //CMarker marker = new CMarker(ref m_canvas, "0");
            //m_board[5, 7] = marker;
            m_board.Draw();
        }

        public void ClickEvent(Point location) 
        {
            int row;
            int column;
            m_board.GetRC(location.X,location.Y,out row,out column);
            //MessageBox.Show(string.Format("Click Location: {0},{1}", row,column));
            CMarker marker = new CMarker(ref m_canvas, ")");
            m_board[row, column] = marker;
            m_board.Draw();
        }
    }
}
