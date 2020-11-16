namespace DemoAssessment1
{
    partial class RRGame
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
            this.RRCover = new System.Windows.Forms.PictureBox();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.ShootBtn = new System.Windows.Forms.Button();
            this.ShootAwayBtn = new System.Windows.Forms.Button();
            this.SpinBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ScoreBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RRCover)).BeginInit();
            this.SuspendLayout();
            // 
            // RRCover
            // 
            this.RRCover.Image = global::DemoAssessment1.Properties.Resources.Nagant_Revolver;
            this.RRCover.Location = new System.Drawing.Point(190, 26);
            this.RRCover.Name = "RRCover";
            this.RRCover.Size = new System.Drawing.Size(403, 195);
            this.RRCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RRCover.TabIndex = 0;
            this.RRCover.TabStop = false;
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(103, 251);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(135, 65);
            this.LoadBtn.TabIndex = 1;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // ShootBtn
            // 
            this.ShootBtn.Location = new System.Drawing.Point(436, 251);
            this.ShootBtn.Name = "ShootBtn";
            this.ShootBtn.Size = new System.Drawing.Size(135, 65);
            this.ShootBtn.TabIndex = 2;
            this.ShootBtn.Text = "Shoot";
            this.ShootBtn.UseVisualStyleBackColor = true;
            this.ShootBtn.Click += new System.EventHandler(this.ShootBtn_Click);
            // 
            // ShootAwayBtn
            // 
            this.ShootAwayBtn.Location = new System.Drawing.Point(590, 251);
            this.ShootAwayBtn.Name = "ShootAwayBtn";
            this.ShootAwayBtn.Size = new System.Drawing.Size(135, 65);
            this.ShootAwayBtn.TabIndex = 3;
            this.ShootAwayBtn.Text = "Shoot Away";
            this.ShootAwayBtn.UseVisualStyleBackColor = true;
            this.ShootAwayBtn.Click += new System.EventHandler(this.ShootAwayBtn_Click);
            // 
            // SpinBtn
            // 
            this.SpinBtn.Location = new System.Drawing.Point(270, 251);
            this.SpinBtn.Name = "SpinBtn";
            this.SpinBtn.Size = new System.Drawing.Size(135, 65);
            this.SpinBtn.TabIndex = 4;
            this.SpinBtn.Text = "Spin";
            this.SpinBtn.UseVisualStyleBackColor = true;
            this.SpinBtn.Click += new System.EventHandler(this.SpinBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(342, 358);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(159, 54);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ScoreBtn
            // 
            this.ScoreBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ScoreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreBtn.Location = new System.Drawing.Point(148, 358);
            this.ScoreBtn.Name = "ScoreBtn";
            this.ScoreBtn.Size = new System.Drawing.Size(159, 54);
            this.ScoreBtn.TabIndex = 6;
            this.ScoreBtn.Text = "Score";
            this.ScoreBtn.UseVisualStyleBackColor = false;
            this.ScoreBtn.Click += new System.EventHandler(this.ScoreBtn_Click);
            // 
            // RRGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ScoreBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SpinBtn);
            this.Controls.Add(this.ShootAwayBtn);
            this.Controls.Add(this.ShootBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.RRCover);
            this.Name = "RRGame";
            this.Text = "RR Game";
            ((System.ComponentModel.ISupportInitialize)(this.RRCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox RRCover;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button ShootBtn;
        private System.Windows.Forms.Button ShootAwayBtn;
        private System.Windows.Forms.Button SpinBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button ScoreBtn;
    }
}

