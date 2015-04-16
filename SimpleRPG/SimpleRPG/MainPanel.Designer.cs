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
            this.itsDownButton = new System.Windows.Forms.Button();
            this.itsUpButton = new System.Windows.Forms.Button();
            this.itsLeftButton = new System.Windows.Forms.Button();
            this.itsRightButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itsGameBoardPanel
            // 
            this.itsGameBoardPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.itsGameBoardPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.itsGameBoardPanel.Location = new System.Drawing.Point(100, 48);
            this.itsGameBoardPanel.Name = "itsGameBoardPanel";
            this.itsGameBoardPanel.Size = new System.Drawing.Size(500, 500);
            this.itsGameBoardPanel.TabIndex = 0;
            // 
            // itsDownButton
            // 
            this.itsDownButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.itsDownButton.Location = new System.Drawing.Point(328, 652);
            this.itsDownButton.Name = "itsDownButton";
            this.itsDownButton.Size = new System.Drawing.Size(45, 45);
            this.itsDownButton.TabIndex = 5;
            this.itsDownButton.Text = "Down";
            this.itsDownButton.UseVisualStyleBackColor = true;
            this.itsDownButton.Click += new System.EventHandler(this.ItsDownButton_Click);
            // 
            // itsUpButton
            // 
            this.itsUpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.itsUpButton.Location = new System.Drawing.Point(328, 554);
            this.itsUpButton.Name = "itsUpButton";
            this.itsUpButton.Size = new System.Drawing.Size(45, 45);
            this.itsUpButton.TabIndex = 8;
            this.itsUpButton.Text = "Up";
            this.itsUpButton.UseVisualStyleBackColor = true;
            this.itsUpButton.Click += new System.EventHandler(this.ItsUpButton_Click);
            // 
            // itsLeftButton
            // 
            this.itsLeftButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.itsLeftButton.Location = new System.Drawing.Point(277, 604);
            this.itsLeftButton.Name = "itsLeftButton";
            this.itsLeftButton.Size = new System.Drawing.Size(45, 45);
            this.itsLeftButton.TabIndex = 6;
            this.itsLeftButton.Text = "Left";
            this.itsLeftButton.UseVisualStyleBackColor = true;
            this.itsLeftButton.Click += new System.EventHandler(this.ItsLeftButton_Click);
            // 
            // itsRightButton
            // 
            this.itsRightButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.itsRightButton.Location = new System.Drawing.Point(379, 604);
            this.itsRightButton.Name = "itsRightButton";
            this.itsRightButton.Size = new System.Drawing.Size(45, 45);
            this.itsRightButton.TabIndex = 7;
            this.itsRightButton.Text = "Right";
            this.itsRightButton.UseVisualStyleBackColor = true;
            this.itsRightButton.Click += new System.EventHandler(this.ItsRightButton_Click);
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.itsDownButton);
            this.Controls.Add(this.itsUpButton);
            this.Controls.Add(this.itsLeftButton);
            this.Controls.Add(this.itsRightButton);
            this.Controls.Add(this.itsGameBoardPanel);
            this.Name = "MainPanel";
            this.Size = new System.Drawing.Size(700, 700);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel itsGameBoardPanel;
        private System.Windows.Forms.Button itsDownButton;
        private System.Windows.Forms.Button itsUpButton;
        private System.Windows.Forms.Button itsLeftButton;
        private System.Windows.Forms.Button itsRightButton;
    }
}
