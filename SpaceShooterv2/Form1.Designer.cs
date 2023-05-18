namespace SpaceShooterv2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MoveBackground = new System.Timers.Timer();
            this.Player = new System.Windows.Forms.PictureBox();
            this.LeftMove = new System.Timers.Timer();
            this.RightMove = new System.Timers.Timer();
            this.UpMove = new System.Timers.Timer();
            this.DownMove = new System.Timers.Timer();
            this.MoveProtectile = new System.Timers.Timer();
            this.MoveEnemy = new System.Timers.Timer();
            this.EnemyProtectiles = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.MoveBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveProtectile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyProtectiles)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveBackground
            // 
            this.MoveBackground.Enabled = true;
            this.MoveBackground.Interval = 10D;
            this.MoveBackground.SynchronizingObject = this;
            // 
            // Player
            // 
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(265, 377);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(66, 68);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // LeftMove
            // 
            this.LeftMove.Enabled = true;
            this.LeftMove.Interval = 5D;
            this.LeftMove.SynchronizingObject = this;
            this.LeftMove.Elapsed += new System.Timers.ElapsedEventHandler(this.LeftMove_Elapsed);
            // 
            // RightMove
            // 
            this.RightMove.Enabled = true;
            this.RightMove.Interval = 5D;
            this.RightMove.SynchronizingObject = this;
            this.RightMove.Elapsed += new System.Timers.ElapsedEventHandler(this.RightMove_Elapsed);
            // 
            // UpMove
            // 
            this.UpMove.Enabled = true;
            this.UpMove.Interval = 5D;
            this.UpMove.SynchronizingObject = this;
            this.UpMove.Elapsed += new System.Timers.ElapsedEventHandler(this.UpMove_Elapsed);
            // 
            // DownMove
            // 
            this.DownMove.Enabled = true;
            this.DownMove.Interval = 5D;
            this.DownMove.SynchronizingObject = this;
            this.DownMove.Elapsed += new System.Timers.ElapsedEventHandler(this.DownMove_Elapsed);
            // 
            // MoveProtectile
            // 
            this.MoveProtectile.Enabled = true;
            this.MoveProtectile.Interval = 20D;
            this.MoveProtectile.SynchronizingObject = this;
            this.MoveProtectile.Elapsed += new System.Timers.ElapsedEventHandler(this.MoveProtectile_Elapsed);
            // 
            // MoveEnemy
            // 
            this.MoveEnemy.Enabled = true;
            this.MoveEnemy.SynchronizingObject = this;
            this.MoveEnemy.Elapsed += new System.Timers.ElapsedEventHandler(this.MoveEnemy_Elapsed);
            // 
            // EnemyProtectiles
            // 
            this.EnemyProtectiles.Enabled = true;
            this.EnemyProtectiles.Interval = 20D;
            this.EnemyProtectiles.SynchronizingObject = this;
            this.EnemyProtectiles.Elapsed += new System.Timers.ElapsedEventHandler(this.EnemyProtectiles_Elapsed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.Player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.MoveBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveProtectile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoveEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyProtectiles)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Timers.Timer EnemyProtectiles;

        private System.Timers.Timer MoveEnemy;

        private System.Timers.Timer MoveProtectile;

        private System.Timers.Timer LeftMove;
        private System.Timers.Timer RightMove;
        private System.Timers.Timer UpMove;
        private System.Timers.Timer DownMove;

        private System.Windows.Forms.PictureBox Player;

        private System.Timers.Timer MoveBackground;

        #endregion
    }
}