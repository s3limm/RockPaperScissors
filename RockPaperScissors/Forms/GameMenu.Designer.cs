namespace RockPaperScissors
{
    partial class GameMenu
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
            this.components = new System.ComponentModel.Container();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCounting = new System.Windows.Forms.Label();
            this.lblUserScore = new System.Windows.Forms.Label();
            this.lblcpuScore = new System.Windows.Forms.Label();
            this.picCpu = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.lblCpuChoise = new System.Windows.Forms.Label();
            this.lblUserChoise = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRock.Location = new System.Drawing.Point(85, 382);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(119, 44);
            this.btnRock.TabIndex = 6;
            this.btnRock.Tag = "R";
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.MakingChoise);
            // 
            // btnPaper
            // 
            this.btnPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPaper.Location = new System.Drawing.Point(333, 382);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(125, 44);
            this.btnPaper.TabIndex = 6;
            this.btnPaper.Tag = "P";
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.MakingChoise);
            // 
            // btnScissors
            // 
            this.btnScissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnScissors.Location = new System.Drawing.Point(599, 382);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(117, 44);
            this.btnScissors.TabIndex = 6;
            this.btnScissors.Tag = "S";
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.MakingChoise);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblCounting
            // 
            this.lblCounting.AutoSize = true;
            this.lblCounting.Enabled = false;
            this.lblCounting.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCounting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCounting.Location = new System.Drawing.Point(360, 20);
            this.lblCounting.Name = "lblCounting";
            this.lblCounting.Size = new System.Drawing.Size(0, 73);
            this.lblCounting.TabIndex = 8;
            // 
            // lblUserScore
            // 
            this.lblUserScore.AutoSize = true;
            this.lblUserScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserScore.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUserScore.Location = new System.Drawing.Point(64, 170);
            this.lblUserScore.Name = "lblUserScore";
            this.lblUserScore.Size = new System.Drawing.Size(114, 20);
            this.lblUserScore.TabIndex = 9;
            this.lblUserScore.Text = "User Result :";
            // 
            // lblcpuScore
            // 
            this.lblcpuScore.AutoSize = true;
            this.lblcpuScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcpuScore.ForeColor = System.Drawing.SystemColors.Window;
            this.lblcpuScore.Location = new System.Drawing.Point(567, 170);
            this.lblcpuScore.Name = "lblcpuScore";
            this.lblcpuScore.Size = new System.Drawing.Size(154, 20);
            this.lblcpuScore.TabIndex = 9;
            this.lblcpuScore.Text = "Computer Result :";
            // 
            // picCpu
            // 
            this.picCpu.Image = global::RockPaperScissors.Properties.Resources.PAPER;
            this.picCpu.Location = new System.Drawing.Point(344, 132);
            this.picCpu.Name = "picCpu";
            this.picCpu.Size = new System.Drawing.Size(100, 100);
            this.picCpu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCpu.TabIndex = 10;
            this.picCpu.TabStop = false;
            // 
            // picUser
            // 
            this.picUser.Image = global::RockPaperScissors.Properties.Resources.ROCK;
            this.picUser.Location = new System.Drawing.Point(344, 238);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(100, 100);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 10;
            this.picUser.TabStop = false;
            // 
            // lblCpuChoise
            // 
            this.lblCpuChoise.AutoSize = true;
            this.lblCpuChoise.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCpuChoise.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCpuChoise.Location = new System.Drawing.Point(308, 98);
            this.lblCpuChoise.Name = "lblCpuChoise";
            this.lblCpuChoise.Size = new System.Drawing.Size(101, 19);
            this.lblCpuChoise.TabIndex = 11;
            this.lblCpuChoise.Text = "Cpu\'s Choise :";
            // 
            // lblUserChoise
            // 
            this.lblUserChoise.AutoSize = true;
            this.lblUserChoise.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserChoise.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUserChoise.Location = new System.Drawing.Point(308, 350);
            this.lblUserChoise.Name = "lblUserChoise";
            this.lblUserChoise.Size = new System.Drawing.Size(96, 19);
            this.lblUserChoise.TabIndex = 11;
            this.lblUserChoise.Text = "Your Choise :";
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUserChoise);
            this.Controls.Add(this.lblCpuChoise);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.picCpu);
            this.Controls.Add(this.lblcpuScore);
            this.Controls.Add(this.lblUserScore);
            this.Controls.Add(this.lblCounting);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Name = "GameMenu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picCpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCounting;
        private System.Windows.Forms.Label lblUserScore;
        private System.Windows.Forms.Label lblcpuScore;
        private System.Windows.Forms.PictureBox picCpu;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Label lblCpuChoise;
        private System.Windows.Forms.Label lblUserChoise;
    }
}

