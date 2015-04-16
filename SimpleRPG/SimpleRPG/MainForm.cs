using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleRPG
{
    public partial class MainForm : Form
    {

        #region Members

        MainPanel itsMainPanel;

        #endregion

        public MainForm()
        {
            InitializeComponent();

            itsMainPanel = new MainPanel();
            itsMainPanel.Dock = DockStyle.Fill;

            this.Controls.Add(itsMainPanel);
        }
    }
}
