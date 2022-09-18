namespace RockPaperScissors
{
    partial class Form1
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
            this.cmbİtems = new System.Windows.Forms.ComboBox();
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.lblUs = new System.Windows.Forms.Label();
            this.lblEnemy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbİtems
            // 
            this.cmbİtems.FormattingEnabled = true;
            this.cmbİtems.Location = new System.Drawing.Point(110, 199);
            this.cmbİtems.Name = "cmbİtems";
            this.cmbİtems.Size = new System.Drawing.Size(185, 21);
            this.cmbİtems.TabIndex = 0;
            // 
            // btnShoot
            // 
            this.btnShoot.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShoot.Location = new System.Drawing.Point(597, 295);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(173, 84);
            this.btnShoot.TabIndex = 1;
            this.btnShoot.Text = "Shoot";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose.Location = new System.Drawing.Point(110, 275);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(120, 41);
            this.btnChoose.TabIndex = 2;
            this.btnChoose.Text = "Lock";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // lblUs
            // 
            this.lblUs.AutoSize = true;
            this.lblUs.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUs.Location = new System.Drawing.Point(107, 121);
            this.lblUs.Name = "lblUs";
            this.lblUs.Size = new System.Drawing.Size(0, 30);
            this.lblUs.TabIndex = 3;
            // 
            // lblEnemy
            // 
            this.lblEnemy.AutoSize = true;
            this.lblEnemy.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemy.Location = new System.Drawing.Point(398, 120);
            this.lblEnemy.Name = "lblEnemy";
            this.lblEnemy.Size = new System.Drawing.Size(0, 30);
            this.lblEnemy.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEnemy);
            this.Controls.Add(this.lblUs);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.btnShoot);
            this.Controls.Add(this.cmbİtems);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbİtems;
        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Label lblUs;
        private System.Windows.Forms.Label lblEnemy;
    }
}

