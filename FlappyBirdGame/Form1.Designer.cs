namespace FlappyBirdGame
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox boruAlt;
        private System.Windows.Forms.PictureBox boruUst;
        private System.Windows.Forms.PictureBox zemin;
        private System.Windows.Forms.Label skorText;
        private System.Windows.Forms.Timer gameTimer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.skorText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.zemin = new System.Windows.Forms.PictureBox();
            this.boruUst = new System.Windows.Forms.PictureBox();
            this.boruAlt = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            this.SuspendLayout();
            // 
            // skorText
            // 
            this.skorText.AutoSize = true;
            this.skorText.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.skorText.Location = new System.Drawing.Point(16, 11);
            this.skorText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skorText.Name = "skorText";
            this.skorText.Size = new System.Drawing.Size(108, 32);
            this.skorText.TabIndex = 4;
            this.skorText.Text = "Skor: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // zemin
            // 
            this.zemin.BackColor = System.Drawing.Color.SaddleBrown;
            this.zemin.Location = new System.Drawing.Point(0, 763);
            this.zemin.Margin = new System.Windows.Forms.Padding(4);
            this.zemin.Name = "zemin";
            this.zemin.Size = new System.Drawing.Size(667, 62);
            this.zemin.TabIndex = 3;
            this.zemin.TabStop = false;
            // 
            // boruUst
            // 
            this.boruUst.BackColor = System.Drawing.Color.Transparent;
            this.boruUst.Image = global::FlappyBirdGame.Properties.Resources.boruusttrans;
            this.boruUst.Location = new System.Drawing.Point(800, 0);
            this.boruUst.Margin = new System.Windows.Forms.Padding(4);
            this.boruUst.Name = "boruUst";
            this.boruUst.Size = new System.Drawing.Size(107, 246);
            this.boruUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.boruUst.TabIndex = 2;
            this.boruUst.TabStop = false;
            // 
            // boruAlt
            // 
            this.boruAlt.BackColor = System.Drawing.Color.Transparent;
            this.boruAlt.Image = global::FlappyBirdGame.Properties.Resources.borualttrans;
            this.boruAlt.Location = new System.Drawing.Point(541, 543);
            this.boruAlt.Margin = new System.Windows.Forms.Padding(4);
            this.boruAlt.Name = "boruAlt";
            this.boruAlt.Size = new System.Drawing.Size(107, 230);
            this.boruAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.boruAlt.TabIndex = 1;
            this.boruAlt.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.BackColor = System.Drawing.Color.Transparent;
            this.flappyBird.Image = global::FlappyBirdGame.Properties.Resources.Astrapicturebox;
            this.flappyBird.Location = new System.Drawing.Point(67, 246);
            this.flappyBird.Margin = new System.Windows.Forms.Padding(4);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(90, 90);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(645, 814);
            this.Controls.Add(this.skorText);
            this.Controls.Add(this.zemin);
            this.Controls.Add(this.boruUst);
            this.Controls.Add(this.boruAlt);
            this.Controls.Add(this.flappyBird);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}