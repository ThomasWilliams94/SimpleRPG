using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SimpleRPG
{
    public partial class GameBoard : UserControl
    {
        #region Members

        #region Constants

        private const float itsThinPen = 3.0F;

        private const float itsBorder = 10.0F;

        private const float itsCellSeparation = 48.0F;
        
        private const float itsTopLeftXCentre = 9F;
        private const float itsTopLeftYCentre = 8F;

        private const float itsStartingPositionX = itsTopLeftXCentre + 2 * itsCellSeparation;
        private const float itsStartingPositionY = itsTopLeftYCentre + 9 * itsCellSeparation;

        private const float itsCharacterDiameter = 30.0F;

        #endregion

        float itsCurrentPositionX;
        float itsCurrentPositionY;

        #endregion


        public GameBoard()
        {
            InitializeComponent();

            itsCurrentPositionX = itsStartingPositionX;
            itsCurrentPositionY = itsStartingPositionY;

        }

        #region Properties

        public float CurrentPositionX
        {
            get
            {
                return itsCurrentPositionX;
            }
            set
            {
                itsCurrentPositionX = value;
            }
        }

        public float CurrentPositionY
        {
            get
            {
                return itsCurrentPositionY;
            }
            set 
            {
                itsCurrentPositionY = value;
            }
        }

        public float CellSeparation
        {
            get
            {
                return itsCellSeparation;
            }
        }

        #endregion

        #region Private Methods
        
        #endregion

        #region Events

        private void GameBoard_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void ItsBackground_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            SolidBrush solidBrush = new SolidBrush(Color.GhostWhite);

            Pen pen = new Pen(solidBrush, itsThinPen);

            // Draw the character at it's current position - bird's eye view 

            // Outline of Character
            g.DrawEllipse(pen, itsCurrentPositionX, itsCurrentPositionY,
                itsCharacterDiameter, itsCharacterDiameter);

            // Fill in character
            g.FillEllipse(solidBrush, itsCurrentPositionX, itsCurrentPositionY, 
                itsCharacterDiameter, itsCharacterDiameter);

        }

        #endregion

    }
}
