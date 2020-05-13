namespace Simon
{
    partial class SimonWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.redPnl = new System.Windows.Forms.Panel();
            this.yellowPnl = new System.Windows.Forms.Panel();
            this.greenPnl = new System.Windows.Forms.Panel();
            this.bluePnl = new System.Windows.Forms.Panel();
            this.startBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // redPnl
            // 
            this.redPnl.BackColor = System.Drawing.Color.Red;
            this.redPnl.Location = new System.Drawing.Point(33, 35);
            this.redPnl.Name = "redPnl";
            this.redPnl.Size = new System.Drawing.Size(233, 182);
            this.redPnl.TabIndex = 0;
            // 
            // yellowPnl
            // 
            this.yellowPnl.BackColor = System.Drawing.Color.Yellow;
            this.yellowPnl.Location = new System.Drawing.Point(288, 35);
            this.yellowPnl.Name = "yellowPnl";
            this.yellowPnl.Size = new System.Drawing.Size(233, 182);
            this.yellowPnl.TabIndex = 1;
            // 
            // greenPnl
            // 
            this.greenPnl.BackColor = System.Drawing.Color.Lime;
            this.greenPnl.Location = new System.Drawing.Point(288, 238);
            this.greenPnl.Name = "greenPnl";
            this.greenPnl.Size = new System.Drawing.Size(233, 182);
            this.greenPnl.TabIndex = 3;
            // 
            // bluePnl
            // 
            this.bluePnl.BackColor = System.Drawing.Color.Blue;
            this.bluePnl.Location = new System.Drawing.Point(33, 238);
            this.bluePnl.Name = "bluePnl";
            this.bluePnl.Size = new System.Drawing.Size(233, 182);
            this.bluePnl.TabIndex = 2;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(193, 446);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(175, 75);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // SimonWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 544);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.greenPnl);
            this.Controls.Add(this.yellowPnl);
            this.Controls.Add(this.bluePnl);
            this.Controls.Add(this.redPnl);
            this.Name = "SimonWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simon Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel redPnl;
        private System.Windows.Forms.Panel yellowPnl;
        private System.Windows.Forms.Panel greenPnl;
        private System.Windows.Forms.Panel bluePnl;
        private System.Windows.Forms.Button startBtn;
    }
}

