using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SimpleRPG
{
    public partial class MainPanel : UserControl
    {
        #region Members

        private GameBoard itsGameBoard;

        #endregion

        public MainPanel()
        {
            InitializeComponent();

            itsGameBoard = new GameBoard();
            itsGameBoard.Location = new Point(10, 10);

            itsGameBoardPanel.Controls.Add(itsGameBoard);

        }

        private void ItsUpButton_Click(object sender, EventArgs e)
        {
            itsGameBoard.CurrentPositionY -= itsGameBoard.CellSeparation;

            itsGameBoard.Refresh();
        }

        private void ItsRightButton_Click(object sender, EventArgs e)
        {
            itsGameBoard.CurrentPositionX += itsGameBoard.CellSeparation;

            itsGameBoard.Refresh();
        }

        private void ItsDownButton_Click(object sender, EventArgs e)
        {
            itsGameBoard.CurrentPositionY += itsGameBoard.CellSeparation;

            itsGameBoard.Refresh();
        }

        private void ItsLeftButton_Click(object sender, EventArgs e)
        {
            itsGameBoard.CurrentPositionX -= itsGameBoard.CellSeparation;

            itsGameBoard.Refresh();
        }
    }
}
