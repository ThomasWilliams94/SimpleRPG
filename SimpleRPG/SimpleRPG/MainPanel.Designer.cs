namespace SimpleRPG
{
    partial class MainPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itsGameBoardPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // itsGameBoardPanel
            // 
            this.itsGameBoardPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.itsGameBoardPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.itsGameBoardPanel.Location = new System.Drawing.Point(100, 100);
            this.itsGameBoardPanel.Name = "itsGameBoardPanel";
            this.itsGameBoardPanel.Size = new System.Drawing.Size(500, 500);
            this.itsGameBoardPanel.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.itsGameBoardPanel);
            this.Name = "MainPanel";
            this.Size = new System.Drawing.Size(700, 700);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel itsGameBoardPanel;
    }
}
