namespace loja
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            flappyBird = new PictureBox();
            pipetop = new PictureBox();
            pipeBottom = new PictureBox();
            scoretxt = new Label();
            gametimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipetop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            SuspendLayout();
            // 
            // flappyBird
            // 
            flappyBird.Image = Properties.Resources.flappyBird;
            flappyBird.Location = new Point(151, 202);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new Size(125, 62);
            flappyBird.SizeMode = PictureBoxSizeMode.Zoom;
            flappyBird.TabIndex = 0;
            flappyBird.TabStop = false;
            // 
            // pipetop
            // 
            pipetop.Image = Properties.Resources.pipeTop;
            pipetop.Location = new Point(438, -2);
            pipetop.Name = "pipetop";
            pipetop.Size = new Size(99, 196);
            pipetop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipetop.TabIndex = 1;
            pipetop.TabStop = false;
            // 
            // pipeBottom
            // 
            pipeBottom.Image = Properties.Resources.pipeBottom;
            pipeBottom.Location = new Point(354, 437);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(125, 262);
            pipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBottom.TabIndex = 2;
            pipeBottom.TabStop = false;
            // 
            // scoretxt
            // 
            scoretxt.AutoSize = true;
            scoretxt.Font = new Font("Lucida Sans Unicode", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoretxt.Location = new Point(28, 22);
            scoretxt.Name = "scoretxt";
            scoretxt.Size = new Size(274, 73);
            scoretxt.TabIndex = 4;
            scoretxt.Text = "Score: 0";
            // 
            // gametimer
            // 
            gametimer.Enabled = true;
            gametimer.Interval = 20;
            gametimer.Tick += gameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(620, 699);
            Controls.Add(scoretxt);
            Controls.Add(pipeBottom);
            Controls.Add(pipetop);
            Controls.Add(flappyBird);
            Name = "Form1";
            Text = "Flappy Bird Game";
            KeyDown += gamekeyisdown;
            KeyUp += gamekeyisup;
            ((System.ComponentModel.ISupportInitialize)flappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipetop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox flappyBird;
        private PictureBox pipetop;
        private PictureBox pipeBottom;
        private Label scoretxt;
        private System.Windows.Forms.Timer gametimer;
    }
}
