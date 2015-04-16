namespace SimpleRPG
{
    partial class GameBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBoard));
            this.itsBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.itsBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // itsBackground
            // 
            this.itsBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itsBackground.Image = ((System.Drawing.Image)(resources.GetObject("itsBackground.Image")));
            this.itsBackground.InitialImage = ((System.Drawing.Image)(resources.GetObject("itsBackground.InitialImage")));
            this.itsBackground.Location = new System.Drawing.Point(0, 0);
            this.itsBackground.Name = "itsBackground";
            this.itsBackground.Size = new System.Drawing.Size(480, 480);
            this.itsBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.itsBackground.TabIndex = 0;
            this.itsBackground.TabStop = false;
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.itsBackground);
            this.Name = "GameBoard";
            this.Size = new System.Drawing.Size(480, 480);
            ((System.ComponentModel.ISupportInitialize)(this.itsBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox itsBackground;
    }
}
