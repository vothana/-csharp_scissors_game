namespace scissors_game
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
            this.lblRock = new System.Windows.Forms.Label();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.yourChoicePic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.alienChoicePic = new System.Windows.Forms.PictureBox();
            this.youWinSupricePic = new System.Windows.Forms.PictureBox();
            this.yourPoint = new System.Windows.Forms.Button();
            this.alienPoint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yourChoicePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienChoicePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.youWinSupricePic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRock
            // 
            this.lblRock.AutoSize = true;
            this.lblRock.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRock.Location = new System.Drawing.Point(199, 46);
            this.lblRock.Name = "lblRock";
            this.lblRock.Size = new System.Drawing.Size(289, 30);
            this.lblRock.TabIndex = 1;
            this.lblRock.Text = "Rock  , Paper , or Scissors ?";
            // 
            // btnRock
            // 
            this.btnRock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRock.Font = new System.Drawing.Font("Skirmisher", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRock.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRock.Location = new System.Drawing.Point(53, 101);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(166, 59);
            this.btnRock.TabIndex = 4;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = false;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaper.Font = new System.Drawing.Font("Skirmisher", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPaper.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPaper.Location = new System.Drawing.Point(254, 101);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(166, 59);
            this.btnPaper.TabIndex = 5;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = false;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnScissors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScissors.Font = new System.Drawing.Font("Skirmisher", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnScissors.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnScissors.Location = new System.Drawing.Point(460, 101);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(166, 59);
            this.btnScissors.TabIndex = 6;
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = false;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // yourChoicePic
            // 
            this.yourChoicePic.Image = global::scissors_game.Properties.Resources.You;
            this.yourChoicePic.Location = new System.Drawing.Point(53, 232);
            this.yourChoicePic.Name = "yourChoicePic";
            this.yourChoicePic.Size = new System.Drawing.Size(230, 225);
            this.yourChoicePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yourChoicePic.TabIndex = 7;
            this.yourChoicePic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Skirmisher", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(319, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "VS";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblWinner.Font = new System.Drawing.Font("Skirmisher", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWinner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblWinner.Location = new System.Drawing.Point(53, 530);
            this.lblWinner.MinimumSize = new System.Drawing.Size(570, 10);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(570, 42);
            this.lblWinner.TabIndex = 9;
            this.lblWinner.Text = "___";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // alienChoicePic
            // 
            this.alienChoicePic.Image = global::scissors_game.Properties.Resources.Alien;
            this.alienChoicePic.Location = new System.Drawing.Point(393, 232);
            this.alienChoicePic.Name = "alienChoicePic";
            this.alienChoicePic.Size = new System.Drawing.Size(230, 225);
            this.alienChoicePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alienChoicePic.TabIndex = 10;
            this.alienChoicePic.TabStop = false;
            // 
            // youWinSupricePic
            // 
            this.youWinSupricePic.BackColor = System.Drawing.Color.Transparent;
            this.youWinSupricePic.Image = global::scissors_game.Properties.Resources.sss;
            this.youWinSupricePic.Location = new System.Drawing.Point(-6, 463);
            this.youWinSupricePic.Name = "youWinSupricePic";
            this.youWinSupricePic.Size = new System.Drawing.Size(684, 232);
            this.youWinSupricePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.youWinSupricePic.TabIndex = 11;
            this.youWinSupricePic.TabStop = false;
            this.youWinSupricePic.Visible = false;
            // 
            // yourPoint
            // 
            this.yourPoint.Enabled = false;
            this.yourPoint.FlatAppearance.BorderSize = 0;
            this.yourPoint.Font = new System.Drawing.Font("Skirmisher", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yourPoint.Location = new System.Drawing.Point(199, 633);
            this.yourPoint.Name = "yourPoint";
            this.yourPoint.Size = new System.Drawing.Size(104, 55);
            this.yourPoint.TabIndex = 12;
            this.yourPoint.Text = "0";
            this.yourPoint.UseVisualStyleBackColor = true;
            // 
            // alienPoint
            // 
            this.alienPoint.Enabled = false;
            this.alienPoint.FlatAppearance.BorderSize = 0;
            this.alienPoint.Font = new System.Drawing.Font("Skirmisher", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.alienPoint.Location = new System.Drawing.Point(358, 633);
            this.alienPoint.Name = "alienPoint";
            this.alienPoint.Size = new System.Drawing.Size(105, 55);
            this.alienPoint.TabIndex = 13;
            this.alienPoint.Text = "0";
            this.alienPoint.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Skirmisher", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(309, 652);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "VS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(675, 689);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.alienPoint);
            this.Controls.Add(this.yourPoint);
            this.Controls.Add(this.alienChoicePic);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yourChoicePic);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.lblRock);
            this.Controls.Add(this.youWinSupricePic);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yourChoicePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienChoicePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.youWinSupricePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblRock;
        private Button btnRock;
        private Button btnPaper;
        private Button btnScissors;
        private PictureBox yourChoicePic;
        private Label label1;
        private Label lblWinner;
        private PictureBox alienChoicePic;
        private PictureBox youWinSupricePic;
        private Button yourPoint;
        private Button alienPoint;
        private Label label2;
    }
}