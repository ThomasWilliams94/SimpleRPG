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
    }
}
